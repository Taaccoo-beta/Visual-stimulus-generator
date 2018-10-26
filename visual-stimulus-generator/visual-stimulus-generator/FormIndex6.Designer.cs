namespace visual_stimulus_generator
{
    partial class FormIndex6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbBasicSetting = new System.Windows.Forms.GroupBox();
            this.pbStaticColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetStaticColor = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnStartDisplay = new System.Windows.Forms.Button();
            this.gbGeneralSetting = new System.Windows.Forms.GroupBox();
            this.lblSet = new System.Windows.Forms.Button();
            this.btnChoicePath = new System.Windows.Forms.Button();
            this.lblPathValue = new System.Windows.Forms.Label();
            this.lblPathLabel = new System.Windows.Forms.Label();
            this.lblVideoName = new System.Windows.Forms.Label();
            this.tbVideoName = new System.Windows.Forms.TextBox();
            this.tbWidthValue = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbHeightValue = new System.Windows.Forms.TextBox();
            this.lblPixelSymHeight = new System.Windows.Forms.Label();
            this.lbltimeSym = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblFrameRate = new System.Windows.Forms.Label();
            this.lblPixelSymWidth = new System.Windows.Forms.Label();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbBasicSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaticColor)).BeginInit();
            this.gbGeneralSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar1.Location = new System.Drawing.Point(403, 457);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(333, 27);
            this.progressBar1.TabIndex = 27;
            // 
            // gbBasicSetting
            // 
            this.gbBasicSetting.Controls.Add(this.pbStaticColor);
            this.gbBasicSetting.Controls.Add(this.label1);
            this.gbBasicSetting.Controls.Add(this.btnSetStaticColor);
            this.gbBasicSetting.Location = new System.Drawing.Point(402, 34);
            this.gbBasicSetting.Name = "gbBasicSetting";
            this.gbBasicSetting.Size = new System.Drawing.Size(335, 295);
            this.gbBasicSetting.TabIndex = 26;
            this.gbBasicSetting.TabStop = false;
            this.gbBasicSetting.Text = "Basic-Setting";
            // 
            // pbStaticColor
            // 
            this.pbStaticColor.Location = new System.Drawing.Point(139, 57);
            this.pbStaticColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbStaticColor.Name = "pbStaticColor";
            this.pbStaticColor.Size = new System.Drawing.Size(128, 22);
            this.pbStaticColor.TabIndex = 39;
            this.pbStaticColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "StaticColor:";
            // 
            // btnSetStaticColor
            // 
            this.btnSetStaticColor.Enabled = false;
            this.btnSetStaticColor.Location = new System.Drawing.Point(139, 111);
            this.btnSetStaticColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetStaticColor.Name = "btnSetStaticColor";
            this.btnSetStaticColor.Size = new System.Drawing.Size(128, 27);
            this.btnSetStaticColor.TabIndex = 37;
            this.btnSetStaticColor.Text = "Set";
            this.btnSetStaticColor.UseVisualStyleBackColor = true;
            this.btnSetStaticColor.Click += new System.EventHandler(this.btnSetStaticColor_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(602, 384);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 54);
            this.btnGenerate.TabIndex = 25;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnStartDisplay
            // 
            this.btnStartDisplay.Enabled = false;
            this.btnStartDisplay.Location = new System.Drawing.Point(402, 384);
            this.btnStartDisplay.Name = "btnStartDisplay";
            this.btnStartDisplay.Size = new System.Drawing.Size(135, 54);
            this.btnStartDisplay.TabIndex = 24;
            this.btnStartDisplay.Text = "Preview";
            this.btnStartDisplay.UseVisualStyleBackColor = true;
            this.btnStartDisplay.Click += new System.EventHandler(this.btnStartDisplay_Click);
            // 
            // gbGeneralSetting
            // 
            this.gbGeneralSetting.Controls.Add(this.lblSet);
            this.gbGeneralSetting.Controls.Add(this.btnChoicePath);
            this.gbGeneralSetting.Controls.Add(this.lblPathValue);
            this.gbGeneralSetting.Controls.Add(this.lblPathLabel);
            this.gbGeneralSetting.Controls.Add(this.lblVideoName);
            this.gbGeneralSetting.Controls.Add(this.tbVideoName);
            this.gbGeneralSetting.Controls.Add(this.tbWidthValue);
            this.gbGeneralSetting.Controls.Add(this.lblWidth);
            this.gbGeneralSetting.Controls.Add(this.tbHeightValue);
            this.gbGeneralSetting.Controls.Add(this.lblPixelSymHeight);
            this.gbGeneralSetting.Controls.Add(this.lbltimeSym);
            this.gbGeneralSetting.Controls.Add(this.lblHeight);
            this.gbGeneralSetting.Controls.Add(this.lblFrameRate);
            this.gbGeneralSetting.Controls.Add(this.lblPixelSymWidth);
            this.gbGeneralSetting.Controls.Add(this.tbFrameRate);
            this.gbGeneralSetting.Controls.Add(this.tbTime);
            this.gbGeneralSetting.Controls.Add(this.lblTime);
            this.gbGeneralSetting.Location = new System.Drawing.Point(59, 34);
            this.gbGeneralSetting.Name = "gbGeneralSetting";
            this.gbGeneralSetting.Size = new System.Drawing.Size(307, 427);
            this.gbGeneralSetting.TabIndex = 23;
            this.gbGeneralSetting.TabStop = false;
            this.gbGeneralSetting.Text = "General-Setting";
            // 
            // lblSet
            // 
            this.lblSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSet.Location = new System.Drawing.Point(105, 348);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(128, 33);
            this.lblSet.TabIndex = 19;
            this.lblSet.Text = "Set";
            this.lblSet.UseVisualStyleBackColor = true;
            this.lblSet.Click += new System.EventHandler(this.lblSet_Click);
            // 
            // btnChoicePath
            // 
            this.btnChoicePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChoicePath.Location = new System.Drawing.Point(105, 298);
            this.btnChoicePath.Name = "btnChoicePath";
            this.btnChoicePath.Size = new System.Drawing.Size(63, 35);
            this.btnChoicePath.TabIndex = 5;
            this.btnChoicePath.Text = "Open";
            this.btnChoicePath.UseVisualStyleBackColor = true;
            this.btnChoicePath.Click += new System.EventHandler(this.btnChoicePath_Click);
            // 
            // lblPathValue
            // 
            this.lblPathValue.AutoSize = true;
            this.lblPathValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPathValue.Location = new System.Drawing.Point(101, 267);
            this.lblPathValue.Name = "lblPathValue";
            this.lblPathValue.Size = new System.Drawing.Size(71, 15);
            this.lblPathValue.TabIndex = 18;
            this.lblPathValue.Text = "D:/Video";
            // 
            // lblPathLabel
            // 
            this.lblPathLabel.AutoSize = true;
            this.lblPathLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPathLabel.Location = new System.Drawing.Point(43, 267);
            this.lblPathLabel.Name = "lblPathLabel";
            this.lblPathLabel.Size = new System.Drawing.Size(47, 15);
            this.lblPathLabel.TabIndex = 17;
            this.lblPathLabel.Text = "Path:";
            // 
            // lblVideoName
            // 
            this.lblVideoName.AutoSize = true;
            this.lblVideoName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVideoName.Location = new System.Drawing.Point(11, 222);
            this.lblVideoName.Name = "lblVideoName";
            this.lblVideoName.Size = new System.Drawing.Size(87, 15);
            this.lblVideoName.TabIndex = 15;
            this.lblVideoName.Text = "VideoName:";
            // 
            // tbVideoName
            // 
            this.tbVideoName.Location = new System.Drawing.Point(105, 219);
            this.tbVideoName.Name = "tbVideoName";
            this.tbVideoName.Size = new System.Drawing.Size(127, 25);
            this.tbVideoName.TabIndex = 16;
            this.tbVideoName.Text = "NULL";
            // 
            // tbWidthValue
            // 
            this.tbWidthValue.Location = new System.Drawing.Point(105, 36);
            this.tbWidthValue.Name = "tbWidthValue";
            this.tbWidthValue.Size = new System.Drawing.Size(127, 25);
            this.tbWidthValue.TabIndex = 2;
            this.tbWidthValue.Text = "1024";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWidth.Location = new System.Drawing.Point(43, 39);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(55, 15);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width:";
            // 
            // tbHeightValue
            // 
            this.tbHeightValue.Location = new System.Drawing.Point(105, 83);
            this.tbHeightValue.Name = "tbHeightValue";
            this.tbHeightValue.Size = new System.Drawing.Size(127, 25);
            this.tbHeightValue.TabIndex = 4;
            this.tbHeightValue.Text = "330";
            // 
            // lblPixelSymHeight
            // 
            this.lblPixelSymHeight.AutoSize = true;
            this.lblPixelSymHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPixelSymHeight.Location = new System.Drawing.Point(237, 87);
            this.lblPixelSymHeight.Name = "lblPixelSymHeight";
            this.lblPixelSymHeight.Size = new System.Drawing.Size(47, 15);
            this.lblPixelSymHeight.TabIndex = 14;
            this.lblPixelSymHeight.Text = "Pixel";
            // 
            // lbltimeSym
            // 
            this.lbltimeSym.AutoSize = true;
            this.lbltimeSym.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltimeSym.Location = new System.Drawing.Point(237, 123);
            this.lbltimeSym.Name = "lbltimeSym";
            this.lbltimeSym.Size = new System.Drawing.Size(15, 15);
            this.lbltimeSym.TabIndex = 11;
            this.lbltimeSym.Text = "S";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeight.Location = new System.Drawing.Point(35, 87);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(63, 15);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFrameRate.Location = new System.Drawing.Point(11, 170);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(87, 15);
            this.lblFrameRate.TabIndex = 9;
            this.lblFrameRate.Text = "FrameRate:";
            // 
            // lblPixelSymWidth
            // 
            this.lblPixelSymWidth.AutoSize = true;
            this.lblPixelSymWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPixelSymWidth.Location = new System.Drawing.Point(237, 39);
            this.lblPixelSymWidth.Name = "lblPixelSymWidth";
            this.lblPixelSymWidth.Size = new System.Drawing.Size(47, 15);
            this.lblPixelSymWidth.TabIndex = 13;
            this.lblPixelSymWidth.Text = "Pixel";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Location = new System.Drawing.Point(105, 167);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(127, 25);
            this.tbFrameRate.TabIndex = 10;
            this.tbFrameRate.Text = "25";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(105, 121);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(127, 25);
            this.tbTime.TabIndex = 6;
            this.tbTime.Text = "10";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(19, 124);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 15);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Duration:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormIndex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 518);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbBasicSetting);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnStartDisplay);
            this.Controls.Add(this.gbGeneralSetting);
            this.Name = "FormIndex6";
            this.Text = "Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndex6_FormClosed);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.gbBasicSetting.ResumeLayout(false);
            this.gbBasicSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaticColor)).EndInit();
            this.gbGeneralSetting.ResumeLayout(false);
            this.gbGeneralSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbBasicSetting;
        private System.Windows.Forms.PictureBox pbStaticColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetStaticColor;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnStartDisplay;
        private System.Windows.Forms.GroupBox gbGeneralSetting;
        private System.Windows.Forms.Button lblSet;
        private System.Windows.Forms.Button btnChoicePath;
        private System.Windows.Forms.Label lblPathValue;
        private System.Windows.Forms.Label lblPathLabel;
        private System.Windows.Forms.Label lblVideoName;
        private System.Windows.Forms.TextBox tbVideoName;
        private System.Windows.Forms.TextBox tbWidthValue;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbHeightValue;
        private System.Windows.Forms.Label lblPixelSymHeight;
        private System.Windows.Forms.Label lbltimeSym;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblFrameRate;
        private System.Windows.Forms.Label lblPixelSymWidth;
        private System.Windows.Forms.TextBox tbFrameRate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}