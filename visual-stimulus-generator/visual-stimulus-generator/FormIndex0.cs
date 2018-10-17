using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_stimulus_generator
{
    public partial class FormIndex0 : Form
    {
        
        public FormIndex0()
        {
            InitializeComponent();
        }

        Graphics g1;
        Bitmap image1;
        private void FormIndex0_Load(object sender, EventArgs e)
        {
            display = new Display();
            display.Show();
            display.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y+this.Height);
        }

        
        private int width;
        private int height;
        private int barSize;
        private int time;
        private int frameRate;
        private int position;
        private Display display;
        private Generator g;
        private string path;
        private string name;
        private void btnStartDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                width = int.Parse(this.tbWidthValue.Text);
                height = int.Parse(this.tbHeightValue.Text);
                barSize = int.Parse(this.tbBarSize.Text);
                position = int.Parse(this.tbPosition.Text);
                time = int.Parse(this.tbTime.Text);
                frameRate = int.Parse(this.tbFrameRate.Text);

                display.Width = width;
                display.Height = height;
                
                image1 = new Bitmap(width, height);
                g1 = Graphics.FromImage(image1);
                //使绘图质量最高，即消除锯齿  
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g1.CompositingQuality = CompositingQuality.HighQuality;
                g1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            }
            catch
            {
                MessageBox.Show("Wrong with input!!");
            }




            g = new Generator(width, height);
            g.SetSimpleCanvas();

            barSize = g.DegreeToWidth(barSize);
            int center = g.DegreeToPosition(0);
            for (int i = 0; i != width; i++)
            {
                
                if (i >= center - barSize / 2 & i <= center + barSize / 2)
                {
                    g.simpleCanvas[i] = 1;
                }
                Console.Write(g.simpleCanvas[i]+" ");
            }

            
            g.SetSimpleCanvasPosition(position);
            //g.MoveLeftForSimpleCanvas(position);

            timer1.Interval = 50;
            timer1.Start();

            
            

        }

        private void rbMotion_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g1.Clear(Color.White);
            for (int i = 0; i != width; i++)
            {
                if (g.simpleCanvas[i] == 1)
                {
                    g1.DrawLine(Pens.Black, i, 0, i, height);
                }
            }
            display.CreateGraphics().DrawImage(image1, 0, 0);
           
        }

        private void FormIndex0_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.display.Close();
            this.timer1.Stop();
        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            NameDetection nd = new NameDetection(path, this.tbVideoName.Text);
            if (nd.NameSearch())
            {
                System.Windows.Forms.DialogResult dr = MessageBox.Show("实验名重复，是否重设？", "是", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    ;
                }
                else
                {
                    ;
                }
            }

            


            g1.Clear(Color.White);
            for (int i = 0; i != width; i++)
            {
                if (g.simpleCanvas[i] == 1)
                {
                    g1.DrawLine(Pens.Black, i, 0, i, height);
                }
            }

            //VedioGenerator vg  = new VedioGenerator()
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowDialog = new FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            path = BrowDialog.SelectedPath;
            lblPathValue.Text = path;
        }
    }
}
