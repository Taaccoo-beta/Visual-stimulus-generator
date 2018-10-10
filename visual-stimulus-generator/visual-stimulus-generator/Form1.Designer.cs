namespace visual_stimulus_generator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbVisualStimulusType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPreView = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.gbDescribe = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreView)).BeginInit();
            this.gbDescribe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVisualStimulusType
            // 
            this.lbVisualStimulusType.FormattingEnabled = true;
            this.lbVisualStimulusType.ItemHeight = 15;
            this.lbVisualStimulusType.Items.AddRange(new object[] {
            "Single Static Bar",
            "Single Swing Bar",
            "Single Cyclic Bar"});
            this.lbVisualStimulusType.Location = new System.Drawing.Point(27, 58);
            this.lbVisualStimulusType.Name = "lbVisualStimulusType";
            this.lbVisualStimulusType.Size = new System.Drawing.Size(177, 259);
            this.lbVisualStimulusType.TabIndex = 0;
            this.lbVisualStimulusType.SelectedIndexChanged += new System.EventHandler(this.lbVisualStimulusType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // pbPreView
            // 
            this.pbPreView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreView.Location = new System.Drawing.Point(27, 339);
            this.pbPreView.Name = "pbPreView";
            this.pbPreView.Size = new System.Drawing.Size(390, 136);
            this.pbPreView.TabIndex = 2;
            this.pbPreView.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(217, 259);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(200, 58);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Edit";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // gbDescribe
            // 
            this.gbDescribe.Controls.Add(this.lblDescription);
            this.gbDescribe.Location = new System.Drawing.Point(217, 48);
            this.gbDescribe.Name = "gbDescribe";
            this.gbDescribe.Size = new System.Drawing.Size(200, 205);
            this.gbDescribe.TabIndex = 4;
            this.gbDescribe.TabStop = false;
            this.gbDescribe.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(17, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(177, 161);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "NULL";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 527);
            this.Controls.Add(this.gbDescribe);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbPreView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVisualStimulusType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreView)).EndInit();
            this.gbDescribe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVisualStimulusType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPreView;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.GroupBox gbDescribe;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Timer timer1;
    }
}

