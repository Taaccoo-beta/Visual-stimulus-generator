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
            this.gbGeneralSetting.Location = new System.Drawing.Point(12, 12);
            this.gbGeneralSetting.Name = "gbGeneralSetting";
            this.gbGeneralSetting.Size = new System.Drawing.Size(307, 427);
            this.gbGeneralSetting.TabIndex = 8;
            this.gbGeneralSetting.TabStop = false;
            this.gbGeneralSetting.Text = "General-Setting";
            // 
            // lblSet
            // 
            this.lblSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSet.Location = new System.Drawing.Point(105, 349);
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
            this.tbWidthValue.Text = "1000";
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
            this.tbHeightValue.Text = "300";
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
            this.lblTime.Location = new System.Drawing.Point(51, 123);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 15);
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
            this.gbBasicSetting.Location = new System.Drawing.Point(355, 12);
            this.gbBasicSetting.Name = "gbBasicSetting";
            this.gbBasicSetting.Size = new System.Drawing.Size(335, 294);
            this.gbBasicSetting.TabIndex = 13;
            this.gbBasicSetting.TabStop = false;
            this.gbBasicSetting.Text = "Basic-Setting";
            // 
            // btnSpeedSwitch
            // 
            this.btnSpeedSwitch.Location = new System.Drawing.Point(247, 87);
            this.btnSpeedSwitch.Name = "btnSpeedSwitch";
            this.btnSpeedSwitch.Size = new System.Drawing.Size(69, 23);
            this.btnSpeedSwitch.TabIndex = 27;
            this.btnSpeedSwitch.Text = "Degree";
            this.btnSpeedSwitch.UseVisualStyleBackColor = true;
            this.btnSpeedSwitch.Click += new System.EventHandler(this.btnSpeedSwitch_Click);
            // 
            // btnBarSizeSwitch
            // 
            this.btnBarSizeSwitch.Location = new System.Drawing.Point(247, 40);
            this.btnBarSizeSwitch.Name = "btnBarSizeSwitch";
            this.btnBarSizeSwitch.Size = new System.Drawing.Size(69, 23);
            this.btnBarSizeSwitch.TabIndex = 26;
            this.btnBarSizeSwitch.Text = "Degree";
            this.btnBarSizeSwitch.UseVisualStyleBackColor = true;
            this.btnBarSizeSwitch.Click += new System.EventHandler(this.btnBarSizeSwitch_Click);
            // 
            // lblCircleTime
            // 
            this.lblCircleTime.AutoSize = true;
            this.lblCircleTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCircleTime.Location = new System.Drawing.Point(107, 148);
            this.lblCircleTime.Name = "lblCircleTime";
            this.lblCircleTime.Size = new System.Drawing.Size(39, 15);
            this.lblCircleTime.TabIndex = 25;
            this.lblCircleTime.Text = "NULL";
            // 
            // lblCircleTimeLabel
            // 
            this.lblCircleTimeLabel.AutoSize = true;
            this.lblCircleTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCircleTimeLabel.Location = new System.Drawing.Point(6, 148);
            this.lblCircleTimeLabel.Name = "lblCircleTimeLabel";
            this.lblCircleTimeLabel.Size = new System.Drawing.Size(95, 15);
            this.lblCircleTimeLabel.TabIndex = 24;
            this.lblCircleTimeLabel.Text = "CircleTime:";
            // 
            // rbLeftToRight
            // 
            this.rbLeftToRight.AutoSize = true;
            this.rbLeftToRight.Location = new System.Drawing.Point(169, 208);
            this.rbLeftToRight.Name = "rbLeftToRight";
            this.rbLeftToRight.Size = new System.Drawing.Size(116, 19);
            this.rbLeftToRight.TabIndex = 23;
            this.rbLeftToRight.Text = "LeftToRight";
            this.rbLeftToRight.UseVisualStyleBackColor = true;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(114, 85);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(127, 25);
            this.tbSpeed.TabIndex = 19;
            this.tbSpeed.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(46, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Speed:";
            // 
            // tbBarSize
            // 
            this.tbBarSize.Location = new System.Drawing.Point(114, 40);
            this.tbBarSize.Name = "tbBarSize";
            this.tbBarSize.Size = new System.Drawing.Size(127, 25);
            this.tbBarSize.TabIndex = 16;
            this.tbBarSize.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "BarSize:";
            // 
            // rbRightToLeft
            // 
            this.rbRightToLeft.AutoSize = true;
            this.rbRightToLeft.Checked = true;
            this.rbRightToLeft.Location = new System.Drawing.Point(33, 208);
            this.rbRightToLeft.Name = "rbRightToLeft";
            this.rbRightToLeft.Size = new System.Drawing.Size(116, 19);
            this.rbRightToLeft.TabIndex = 11;
            this.rbRightToLeft.TabStop = true;
            this.rbRightToLeft.Text = "RightToLeft";
            this.rbRightToLeft.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(555, 361);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 54);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnStartDisplay
            // 
            this.btnStartDisplay.Enabled = false;
            this.btnStartDisplay.Location = new System.Drawing.Point(355, 361);
            this.btnStartDisplay.Name = "btnStartDisplay";
            this.btnStartDisplay.Size = new System.Drawing.Size(135, 54);
            this.btnStartDisplay.TabIndex = 11;
            this.btnStartDisplay.Text = "Preview";
            this.btnStartDisplay.UseVisualStyleBackColor = true;
            this.btnStartDisplay.Click += new System.EventHandler(this.btnStartDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 493);
            this.Controls.Add(this.gbBasicSetting);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnStartDisplay);
            this.Controls.Add(this.gbGeneralSetting);
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
    }
}