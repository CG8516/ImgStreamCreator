using System;
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
            FileStream outputStream = new FileStream(textBoxVideoOutput.Text, FileMode.Create);
            string tempDir = "vid_tmp";

            if (Directory.Exists(tempDir))
                Directory.Delete(tempDir, true);
            Directory.CreateDirectory(tempDir);

            //Extract all the frames from the input video, storing temporarily in the 'ImgStream_tmp' folder
            ProcessStartInfo info = new ProcessStartInfo();
            string escapedInputName = string.Format(" \"{0}\" ", textBoxVideoInput.Text);
            info.Arguments = "-i" + escapedInputName + " -q:v " + numericUpDownCompressionLevel.Value.ToString() + " " + tempDir + "\\%d.jpg";
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
            outputWriter.Write((Int32)0);   //Audio Type
            outputWriter.Write((Int32)0);   //Audio offset
            outputWriter.Write((Int32)0);   //Audio length (bytes)
            outputWriter.Write((Int32)0);   //Reserved

            //Image data            
            outputWriter.Write(frameCount); //Frame count
            outputWriter.Write(frameRate);  //Frame rate
            outputWriter.Write((Int32)0);   //Reserved

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
                byte[] jpegBytes = File.ReadAllBytes(tempDir + "\\" + (i + 1).ToString() + ".jpg");
                outputWriter.Write((Int64)jpegBytes.Length);
                outputWriter.BaseStream.Seek(dataOffset, SeekOrigin.Begin);
                
                outputWriter.Write(jpegBytes);
            }

            outputWriter.Close();
            outputStream.Close();
        }
    }
}
