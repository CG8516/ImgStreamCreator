namespace ImgStreamCreator {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOpenVideo = new System.Windows.Forms.Button();
            this.textBoxVideoInput = new System.Windows.Forms.TextBox();
            this.textBoxVideoOutput = new System.Windows.Forms.TextBox();
            this.buttonOutputFolder = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownFrameRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCompressionLevel = new System.Windows.Forms.NumericUpDown();
            this.labelCompression = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompressionLevel)).BeginInit();
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
            this.buttonConvert.Location = new System.Drawing.Point(13, 111);
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
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frame Rate:";
            // 
            // numericUpDownFrameRate
            // 
            this.numericUpDownFrameRate.Location = new System.Drawing.Point(83, 74);
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
            // numericUpDownCompressionLevel
            // 
            this.numericUpDownCompressionLevel.Location = new System.Drawing.Point(304, 74);
            this.numericUpDownCompressionLevel.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownCompressionLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCompressionLevel.Name = "numericUpDownCompressionLevel";
            this.numericUpDownCompressionLevel.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownCompressionLevel.TabIndex = 9;
            this.numericUpDownCompressionLevel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelCompression
            // 
            this.labelCompression.AutoSize = true;
            this.labelCompression.Location = new System.Drawing.Point(185, 76);
            this.labelCompression.Name = "labelCompression";
            this.labelCompression.Size = new System.Drawing.Size(113, 13);
            this.labelCompression.TabIndex = 8;
            this.labelCompression.Text = "Compression Strength:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 146);
            this.Controls.Add(this.numericUpDownCompressionLevel);
            this.Controls.Add(this.labelCompression);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompressionLevel)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownCompressionLevel;
        private System.Windows.Forms.Label labelCompression;
    }
}

