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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbVisualStimulusType = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
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
            resources.GetString("lbVisualStimulusType.Items3"),
            resources.GetString("lbVisualStimulusType.Items4"),
            resources.GetString("lbVisualStimulusType.Items5"),
            resources.GetString("lbVisualStimulusType.Items6"),
            resources.GetString("lbVisualStimulusType.Items7"),
            resources.GetString("lbVisualStimulusType.Items8"),
            resources.GetString("lbVisualStimulusType.Items9"),
            resources.GetString("lbVisualStimulusType.Items10")});
            this.lbVisualStimulusType.Name = "lbVisualStimulusType";
            this.lbVisualStimulusType.SelectedIndexChanged += new System.EventHandler(this.lbVisualStimulusType_SelectedIndexChanged);
            // 
            // btnChoose
            // 
            resources.ApplyResources(this.btnChoose, "btnChoose");
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
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
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lbVisualStimulusType);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVisualStimulusType;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblType;
    }
}

