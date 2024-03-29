﻿namespace ImgStreamCreator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOpenVideo = new System.Windows.Forms.Button();
            this.textBoxVideoInput = new System.Windows.Forms.TextBox();
            this.textBoxVideoOutput = new System.Windows.Forms.TextBox();
            this.buttonOutputFolder = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownFrameRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.encoderSelection = new System.Windows.Forms.ComboBox();
            this.qualitySlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualitySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenVideo
            // 
            this.buttonOpenVideo.Location = new System.Drawing.Point(557, 16);
            this.buttonOpenVideo.Name = "buttonOpenVideo";
            this.buttonOpenVideo.Size = new System.Drawing.Size(75, 20);
            this.buttonOpenVideo.TabIndex = 0;
            this.buttonOpenVideo.Text = "Input Video";
            this.buttonOpenVideo.UseVisualStyleBackColor = true;
            this.buttonOpenVideo.Click += new System.EventHandler(this.buttonOpenVideo_Click);
            // 
            // textBoxVideoInput
            // 
            this.textBoxVideoInput.Location = new System.Drawing.Point(13, 16);
            this.textBoxVideoInput.Name = "textBoxVideoInput";
            this.textBoxVideoInput.Size = new System.Drawing.Size(536, 20);
            this.textBoxVideoInput.TabIndex = 1;
            // 
            // textBoxVideoOutput
            // 
            this.textBoxVideoOutput.Location = new System.Drawing.Point(13, 42);
            this.textBoxVideoOutput.Name = "textBoxVideoOutput";
            this.textBoxVideoOutput.Size = new System.Drawing.Size(536, 20);
            this.textBoxVideoOutput.TabIndex = 3;
            // 
            // buttonOutputFolder
            // 
            this.buttonOutputFolder.Location = new System.Drawing.Point(557, 42);
            this.buttonOutputFolder.Name = "buttonOutputFolder";
            this.buttonOutputFolder.Size = new System.Drawing.Size(75, 20);
            this.buttonOutputFolder.TabIndex = 2;
            this.buttonOutputFolder.Text = "Output File";
            this.buttonOutputFolder.UseVisualStyleBackColor = true;
            this.buttonOutputFolder.Click += new System.EventHandler(this.buttonOutputFolder_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(13, 114);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(620, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert!";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frame Rate:";
            // 
            // numericUpDownFrameRate
            // 
            this.numericUpDownFrameRate.Enabled = false;
            this.numericUpDownFrameRate.Location = new System.Drawing.Point(279, 80);
            this.numericUpDownFrameRate.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numericUpDownFrameRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrameRate.Name = "numericUpDownFrameRate";
            this.numericUpDownFrameRate.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownFrameRate.TabIndex = 7;
            this.numericUpDownFrameRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Format";
            // 
            // encoderSelection
            // 
            this.encoderSelection.FormattingEnabled = true;
            this.encoderSelection.Items.AddRange(new object[] {
            "mjpeg",
            "mpeg1 (new)"});
            this.encoderSelection.Location = new System.Drawing.Point(57, 78);
            this.encoderSelection.Name = "encoderSelection";
            this.encoderSelection.Size = new System.Drawing.Size(121, 21);
            this.encoderSelection.TabIndex = 11;
            this.encoderSelection.Text = "mpeg1 (new)";
            this.encoderSelection.SelectedIndexChanged += new System.EventHandler(this.encoderSelection_SelectedIndexChanged);
            // 
            // qualitySlider
            // 
            this.qualitySlider.LargeChange = 10;
            this.qualitySlider.Location = new System.Drawing.Point(405, 68);
            this.qualitySlider.Maximum = 100;
            this.qualitySlider.MaximumSize = new System.Drawing.Size(200, 20);
            this.qualitySlider.MinimumSize = new System.Drawing.Size(200, 20);
            this.qualitySlider.Name = "qualitySlider";
            this.qualitySlider.Size = new System.Drawing.Size(200, 45);
            this.qualitySlider.SmallChange = 5;
            this.qualitySlider.TabIndex = 12;
            this.qualitySlider.Value = 85;
            this.qualitySlider.ValueChanged += new System.EventHandler(this.qualitySlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 146);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qualitySlider);
            this.Controls.Add(this.encoderSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownFrameRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxVideoOutput);
            this.Controls.Add(this.buttonOutputFolder);
            this.Controls.Add(this.textBoxVideoInput);
            this.Controls.Add(this.buttonOpenVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EFPSE Video Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualitySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenVideo;
        private System.Windows.Forms.TextBox textBoxVideoInput;
        private System.Windows.Forms.TextBox textBoxVideoOutput;
        private System.Windows.Forms.Button buttonOutputFolder;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFrameRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox encoderSelection;
        private System.Windows.Forms.TrackBar qualitySlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

