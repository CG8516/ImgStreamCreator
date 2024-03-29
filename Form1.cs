﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ImgStreamCreator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        enum VidEncoder {
            mjpeg,
            mpeg1
        }

        enum AudioEncoder {
            none,
            mp2
        }

        VidEncoder vidEncoder = VidEncoder.mpeg1;
        AudioEncoder audioEncoder = AudioEncoder.mp2;

        private void buttonOpenVideo_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            var dialogResult = ofd.ShowDialog();
            if(dialogResult == DialogResult.OK)
                textBoxVideoInput.Text = ofd.FileName;
        }

        private void buttonOutputFolder_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "vid";
            sfd.Filter = "Efpse vid files (*.vid)|*.vid";
            var dialogResult = sfd.ShowDialog();
            if (dialogResult == DialogResult.OK)
                textBoxVideoOutput.Text = sfd.FileName;
        }

        private void buttonConvert_Click(object sender, EventArgs e) {
            if(textBoxVideoInput.Text == "" || !File.Exists(textBoxVideoInput.Text)) {
                MessageBox.Show("Please choose an input file!", "No input selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(textBoxVideoInput.Text.EndsWith(".vid")) {
                MessageBox.Show("This tool can only write vid files, not read them.", ".vid import not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool dirValid = false;
            if(textBoxVideoOutput.Text == "") {
                MessageBox.Show("Please choose an output file!", "Output not specified!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            try {
                string dir = Directory.GetParent(textBoxVideoOutput.Text).FullName;
                dirValid = Directory.Exists(dir);
                if (!dirValid)
                    Directory.CreateDirectory(dir);
                File.Create(textBoxVideoOutput.Text).Close();
            } catch { }

            if(!dirValid) {
                if (textBoxVideoOutput.Text == "") {
                    MessageBox.Show("Failed to write specified output file!", "Failed to save file",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }


            FileStream outputStream = new FileStream(textBoxVideoOutput.Text, FileMode.Create);
            string tempDir = "vid_tmp";

            if (Directory.Exists(tempDir))
                Directory.Delete(tempDir, true);
            Directory.CreateDirectory(tempDir);

            //Extract all the frames from the input video, storing temporarily in the 'ImgStream_tmp' folder
            ProcessStartInfo info = new ProcessStartInfo();
            string escapedInputName = string.Format(" \"{0}\" ", textBoxVideoInput.Text);
            float quality = 100-qualitySlider.Value;
            quality /= 100.0f;
            string extension = "";
            switch(vidEncoder) {
                case VidEncoder.mjpeg:
                    quality *= 21.0f;
                    info.Arguments = "-i" + escapedInputName + " -q:v " + ((int)quality).ToString() + " " + tempDir + "\\%d.jpg";
                    audioEncoder = AudioEncoder.none;
                    extension = ".jpg";
                    break;
                case VidEncoder.mpeg1:
                    quality *= 21.0f;
                    info.Arguments = "-i" + escapedInputName + " -c:v mpeg1video -q:v " + ((int)quality).ToString() + " -c:a mp2 -format mpeg " + tempDir + "\\1.mpg";
                    audioEncoder = AudioEncoder.mp2;
                    extension = ".mpg";
                    break;
            }
            
            info.UseShellExecute = true;
            info.FileName = "ffmpeg.exe";
            Process proc = new Process();
            proc.StartInfo = info;
            proc.Start();
            while (!proc.HasExited)
                ;

            var allFrames = Directory.GetFiles(tempDir);
            int frameCount = allFrames.Length;
            float frameRate = (float)numericUpDownFrameRate.Value;

            BinaryWriter outputWriter = new BinaryWriter(outputStream);
            outputWriter.Write("IMGS".ToArray(),0,4);     //Magic header (IMaGe Stream)
            outputWriter.Write((Int32)0);   //versionInfo

            //Audio data
            outputWriter.Write((Int32)audioEncoder);   //Audio encoding
            outputWriter.Write((Int32)0);   //Audio offset
            outputWriter.Write((Int32)0);   //Audio length (bytes)
            outputWriter.Write((Int32)0);   //Reserved

            //Image data            
            outputWriter.Write(frameCount); //Frame count
            outputWriter.Write(frameRate);  //Frame rate
            outputWriter.Write((Int32)vidEncoder);   //video encoding

            //Write placeholder data for all frame metadata (offsets and lengths)
            long offsetStart = outputWriter.BaseStream.Position;
           
            //Are these both really required? We can calculate length by subtracting offsets.
            for (int i =0; i < frameCount; i++) {
                outputWriter.Write((Int64)0);   //offset
                outputWriter.Write((Int64)0);   //length
            }

            //Write the frame data after all the frame metadata, updating the metadata as its being written
            for(int i =0; i < frameCount; i++) {
                long dataOffset = outputWriter.BaseStream.Position;
                outputWriter.BaseStream.Seek(offsetStart + i * sizeof(Int64)*2, SeekOrigin.Begin);
                outputWriter.Write((Int64)dataOffset);
                byte[] frameBytes = File.ReadAllBytes(tempDir + "\\" + (i+1).ToString() + extension);
                outputWriter.Write((Int64)frameBytes.Length);
                outputWriter.BaseStream.Seek(dataOffset, SeekOrigin.Begin);
                outputWriter.Write(frameBytes);
            }

            outputWriter.Close();
            outputStream.Close();

            MessageBox.Show("Conversion complete!", "Conversion complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void encoderSelection_SelectedIndexChanged(object sender, EventArgs e) {
            vidEncoder = (VidEncoder)encoderSelection.SelectedIndex;
            numericUpDownFrameRate.Enabled = true;
            if (vidEncoder == VidEncoder.mpeg1)
                numericUpDownFrameRate.Enabled = false;
        }

        private void qualitySlider_ValueChanged(object sender, EventArgs e) {
            toolTip1.Show(qualitySlider.Value.ToString(), this, PointToClient(Cursor.Position).X, qualitySlider.Location.Y , 500);
        }
    }
}
