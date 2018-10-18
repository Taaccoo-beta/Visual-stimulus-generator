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
            this.pbPreView = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.gbDescribe = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreView)).BeginInit();
            this.gbDescribe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVisualStimulusType
            // 
            this.lbVisualStimulusType.FormattingEnabled = true;
            resources.ApplyResources(this.lbVisualStimulusType, "lbVisualStimulusType");
            this.lbVisualStimulusType.Items.AddRange(new object[] {
            resources.GetString("lbVisualStimulusType.Items"),
            resources.GetString("lbVisualStimulusType.Items1"),
            resources.GetString("lbVisualStimulusType.Items2"),
            resources.GetString("lbVisualStimulusType.Items3")});
            this.lbVisualStimulusType.Name = "lbVisualStimulusType";
            this.lbVisualStimulusType.SelectedIndexChanged += new System.EventHandler(this.lbVisualStimulusType_SelectedIndexChanged);
            // 
            // pbPreView
            // 
            this.pbPreView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pbPreView, "pbPreView");
            this.pbPreView.Name = "pbPreView";
            this.pbPreView.TabStop = false;
            // 
            // btnChoose
            // 
            resources.ApplyResources(this.btnChoose, "btnChoose");
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // gbDescribe
            // 
            this.gbDescribe.Controls.Add(this.lblDescription);
            resources.ApplyResources(this.gbDescribe, "gbDescribe");
            this.gbDescribe.Name = "gbDescribe";
            this.gbDescribe.TabStop = false;
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.gbDescribe);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbPreView);
            this.Controls.Add(this.lbVisualStimulusType);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreView)).EndInit();
            this.gbDescribe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVisualStimulusType;
        private System.Windows.Forms.PictureBox pbPreView;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.GroupBox gbDescribe;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblType;
    }
}

