namespace visual_stimulus_generator
{
    partial class FormIndex2
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
            this.gbBasicSetting = new System.Windows.Forms.GroupBox();
            this.btnSpeedSwitch = new System.Windows.Forms.Button();
            this.btnBarSizeSwitch = new System.Windows.Forms.Button();
            this.lblCircleTime = new System.Windows.Forms.Label();
            this.lblCircleTimeLabel = new System.Windows.Forms.Label();
            this.rbLeftToRight = new System.Windows.Forms.RadioButton();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBarSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRightToLeft = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnStartDisplay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbGeneralSetting.SuspendLayout();
            this.gbBasicSetting.SuspendLayout();
            this.SuspendLayout();
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
            this.gbGeneralSetting.Location = new System.Drawing.Point(9, 10);
            this.gbGeneralSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbGeneralSetting.Name = "gbGeneralSetting";
            this.gbGeneralSetting.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbGeneralSetting.Size = new System.Drawing.Size(230, 370);
            this.gbGeneralSetting.TabIndex = 8;
            this.gbGeneralSetting.TabStop = false;
            this.gbGeneralSetting.Text = "General-Setting";
            // 
            // lblSet
            // 
            this.lblSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSet.Location = new System.Drawing.Point(79, 302);
            this.lblSet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(96, 29);
            this.lblSet.TabIndex = 19;
            this.lblSet.Text = "Set";
            this.lblSet.UseVisualStyleBackColor = true;
            this.lblSet.Click += new System.EventHandler(this.lblSet_Click);
            // 
            // btnChoicePath
            // 
            this.btnChoicePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChoicePath.Location = new System.Drawing.Point(79, 258);
            this.btnChoicePath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChoicePath.Name = "btnChoicePath";
            this.btnChoicePath.Size = new System.Drawing.Size(47, 30);
            this.btnChoicePath.TabIndex = 5;
            this.btnChoicePath.Text = "Open";
            this.btnChoicePath.UseVisualStyleBackColor = true;
            this.btnChoicePath.Click += new System.EventHandler(this.btnChoicePath_Click);
            // 
            // lblPathValue
            // 
            this.lblPathValue.AutoSize = true;
            this.lblPathValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPathValue.Location = new System.Drawing.Point(76, 231);
            this.lblPathValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathValue.Name = "lblPathValue";
            this.lblPathValue.Size = new System.Drawing.Size(50, 13);
            this.lblPathValue.TabIndex = 18;
            this.lblPathValue.Text = "D:/Video";
            // 
            // lblPathLabel
            // 
            this.lblPathLabel.AutoSize = true;
            this.lblPathLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPathLabel.Location = new System.Drawing.Point(32, 231);
            this.lblPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathLabel.Name = "lblPathLabel";
            this.lblPathLabel.Size = new System.Drawing.Size(32, 13);
            this.lblPathLabel.TabIndex = 17;
            this.lblPathLabel.Text = "Path:";
            // 
            // lblVideoName
            // 
            this.lblVideoName.AutoSize = true;
            this.lblVideoName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVideoName.Location = new System.Drawing.Point(8, 192);
            this.lblVideoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVideoName.Name = "lblVideoName";
            this.lblVideoName.Size = new System.Drawing.Size(65, 13);
            this.lblVideoName.TabIndex = 15;
            this.lblVideoName.Text = "VideoName:";
            // 
            // tbVideoName
            // 
            this.tbVideoName.Location = new System.Drawing.Point(79, 190);
            this.tbVideoName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbVideoName.Name = "tbVideoName";
            this.tbVideoName.Size = new System.Drawing.Size(96, 20);
            this.tbVideoName.TabIndex = 16;
            this.tbVideoName.Text = "NULL";
            // 
            // tbWidthValue
            // 
            this.tbWidthValue.Location = new System.Drawing.Point(79, 31);
            this.tbWidthValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbWidthValue.Name = "tbWidthValue";
            this.tbWidthValue.Size = new System.Drawing.Size(96, 20);
            this.tbWidthValue.TabIndex = 2;
            this.tbWidthValue.Text = "1000";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWidth.Location = new System.Drawing.Point(32, 34);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width:";
            // 
            // tbHeightValue
            // 
            this.tbHeightValue.Location = new System.Drawing.Point(79, 72);
            this.tbHeightValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbHeightValue.Name = "tbHeightValue";
            this.tbHeightValue.Size = new System.Drawing.Size(96, 20);
            this.tbHeightValue.TabIndex = 4;
            this.tbHeightValue.Text = "300";
            // 
            // lblPixelSymHeight
            // 
            this.lblPixelSymHeight.AutoSize = true;
            this.lblPixelSymHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPixelSymHeight.Location = new System.Drawing.Point(178, 75);
            this.lblPixelSymHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPixelSymHeight.Name = "lblPixelSymHeight";
            this.lblPixelSymHeight.Size = new System.Drawing.Size(29, 13);
            this.lblPixelSymHeight.TabIndex = 14;
            this.lblPixelSymHeight.Text = "Pixel";
            // 
            // lbltimeSym
            // 
            this.lbltimeSym.AutoSize = true;
            this.lbltimeSym.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltimeSym.Location = new System.Drawing.Point(178, 107);
            this.lbltimeSym.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltimeSym.Name = "lbltimeSym";
            this.lbltimeSym.Size = new System.Drawing.Size(14, 13);
            this.lbltimeSym.TabIndex = 11;
            this.lbltimeSym.Text = "S";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeight.Location = new System.Drawing.Point(26, 75);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFrameRate.Location = new System.Drawing.Point(8, 147);
            this.lblFrameRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(62, 13);
            this.lblFrameRate.TabIndex = 9;
            this.lblFrameRate.Text = "FrameRate:";
            // 
            // lblPixelSymWidth
            // 
            this.lblPixelSymWidth.AutoSize = true;
            this.lblPixelSymWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPixelSymWidth.Location = new System.Drawing.Point(178, 34);
            this.lblPixelSymWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPixelSymWidth.Name = "lblPixelSymWidth";
            this.lblPixelSymWidth.Size = new System.Drawing.Size(29, 13);
            this.lblPixelSymWidth.TabIndex = 13;
            this.lblPixelSymWidth.Text = "Pixel";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Location = new System.Drawing.Point(79, 145);
            this.tbFrameRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(96, 20);
            this.tbFrameRate.TabIndex = 10;
            this.tbFrameRate.Text = "25";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(79, 105);
            this.tbTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(96, 20);
            this.tbTime.TabIndex = 6;
            this.tbTime.Text = "10";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(38, 107);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            // 
            // gbBasicSetting
            // 
            this.gbBasicSetting.Controls.Add(this.btnSpeedSwitch);
            this.gbBasicSetting.Controls.Add(this.btnBarSizeSwitch);
            this.gbBasicSetting.Controls.Add(this.lblCircleTime);
            this.gbBasicSetting.Controls.Add(this.lblCircleTimeLabel);
            this.gbBasicSetting.Controls.Add(this.rbLeftToRight);
            this.gbBasicSetting.Controls.Add(this.tbSpeed);
            this.gbBasicSetting.Controls.Add(this.label4);
            this.gbBasicSetting.Controls.Add(this.tbBarSize);
            this.gbBasicSetting.Controls.Add(this.label2);
            this.gbBasicSetting.Controls.Add(this.rbRightToLeft);
            this.gbBasicSetting.Location = new System.Drawing.Point(266, 10);
            this.gbBasicSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbBasicSetting.Name = "gbBasicSetting";
            this.gbBasicSetting.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbBasicSetting.Size = new System.Drawing.Size(251, 255);
            this.gbBasicSetting.TabIndex = 13;
            this.gbBasicSetting.TabStop = false;
            this.gbBasicSetting.Text = "Basic-Setting";
            // 
            // btnSpeedSwitch
            // 
            this.btnSpeedSwitch.Location = new System.Drawing.Point(185, 75);
            this.btnSpeedSwitch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpeedSwitch.Name = "btnSpeedSwitch";
            this.btnSpeedSwitch.Size = new System.Drawing.Size(52, 20);
            this.btnSpeedSwitch.TabIndex = 27;
            this.btnSpeedSwitch.Text = "Degree";
            this.btnSpeedSwitch.UseVisualStyleBackColor = true;
            this.btnSpeedSwitch.Click += new System.EventHandler(this.btnSpeedSwitch_Click);
            // 
            // btnBarSizeSwitch
            // 
            this.btnBarSizeSwitch.Location = new System.Drawing.Point(185, 35);
            this.btnBarSizeSwitch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBarSizeSwitch.Name = "btnBarSizeSwitch";
            this.btnBarSizeSwitch.Size = new System.Drawing.Size(52, 20);
            this.btnBarSizeSwitch.TabIndex = 26;
            this.btnBarSizeSwitch.Text = "Degree";
            this.btnBarSizeSwitch.UseVisualStyleBackColor = true;
            this.btnBarSizeSwitch.Click += new System.EventHandler(this.btnBarSizeSwitch_Click);
            // 
            // lblCircleTime
            // 
            this.lblCircleTime.AutoSize = true;
            this.lblCircleTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCircleTime.Location = new System.Drawing.Point(80, 128);
            this.lblCircleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircleTime.Name = "lblCircleTime";
            this.lblCircleTime.Size = new System.Drawing.Size(35, 13);
            this.lblCircleTime.TabIndex = 25;
            this.lblCircleTime.Text = "NULL";
            // 
            // lblCircleTimeLabel
            // 
            this.lblCircleTimeLabel.AutoSize = true;
            this.lblCircleTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCircleTimeLabel.Location = new System.Drawing.Point(4, 128);
            this.lblCircleTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircleTimeLabel.Name = "lblCircleTimeLabel";
            this.lblCircleTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.lblCircleTimeLabel.TabIndex = 24;
            this.lblCircleTimeLabel.Text = "CircleTime:";
            // 
            // rbLeftToRight
            // 
            this.rbLeftToRight.AutoSize = true;
            this.rbLeftToRight.Location = new System.Drawing.Point(127, 180);
            this.rbLeftToRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbLeftToRight.Name = "rbLeftToRight";
            this.rbLeftToRight.Size = new System.Drawing.Size(81, 17);
            this.rbLeftToRight.TabIndex = 23;
            this.rbLeftToRight.Text = "LeftToRight";
            this.rbLeftToRight.UseVisualStyleBackColor = true;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(86, 74);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(96, 20);
            this.tbSpeed.TabIndex = 19;
            this.tbSpeed.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(34, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Speed:";
            // 
            // tbBarSize
            // 
            this.tbBarSize.Location = new System.Drawing.Point(86, 35);
            this.tbBarSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBarSize.Name = "tbBarSize";
            this.tbBarSize.Size = new System.Drawing.Size(96, 20);
            this.tbBarSize.TabIndex = 16;
            this.tbBarSize.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "BarSize:";
            // 
            // rbRightToLeft
            // 
            this.rbRightToLeft.AutoSize = true;
            this.rbRightToLeft.Checked = true;
            this.rbRightToLeft.Location = new System.Drawing.Point(25, 180);
            this.rbRightToLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbRightToLeft.Name = "rbRightToLeft";
            this.rbRightToLeft.Size = new System.Drawing.Size(81, 17);
            this.rbRightToLeft.TabIndex = 11;
            this.rbRightToLeft.TabStop = true;
            this.rbRightToLeft.Text = "RightToLeft";
            this.rbRightToLeft.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(416, 313);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 47);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnStartDisplay
            // 
            this.btnStartDisplay.Enabled = false;
            this.btnStartDisplay.Location = new System.Drawing.Point(266, 313);
            this.btnStartDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStartDisplay.Name = "btnStartDisplay";
            this.btnStartDisplay.Size = new System.Drawing.Size(101, 47);
            this.btnStartDisplay.TabIndex = 11;
            this.btnStartDisplay.Text = "Preview";
            this.btnStartDisplay.UseVisualStyleBackColor = true;
            this.btnStartDisplay.Click += new System.EventHandler(this.btnStartDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar1.Location = new System.Drawing.Point(266, 275);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // FormIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 427);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbBasicSetting);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnStartDisplay);
            this.Controls.Add(this.gbGeneralSetting);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormIndex2";
            this.Text = "FormIndex2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndex2_FormClosed);
            this.Load += new System.EventHandler(this.FormIndex2_Load);
            this.gbGeneralSetting.ResumeLayout(false);
            this.gbGeneralSetting.PerformLayout();
            this.gbBasicSetting.ResumeLayout(false);
            this.gbBasicSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.GroupBox gbBasicSetting;
        private System.Windows.Forms.Button btnSpeedSwitch;
        private System.Windows.Forms.Button btnBarSizeSwitch;
        private System.Windows.Forms.Label lblCircleTime;
        private System.Windows.Forms.Label lblCircleTimeLabel;
        private System.Windows.Forms.RadioButton rbLeftToRight;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBarSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRightToLeft;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnStartDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}