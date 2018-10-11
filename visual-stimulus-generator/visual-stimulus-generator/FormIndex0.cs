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
            display = new Display(400, 400);
            display.Show();
        }

        
        private int width;
        private int height;
        private int barSize;
        private int time;
        private int frameRate;
        private int position;
        private Display display;
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
                //display.Height = height;

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

            


            Generator g = new Generator(width, height);
            barSize = g.DegreeToPosition(barSize);
            int center = g.DegreeToPosition(0);
            for (int i = 0; i != width; i++)
            {
                if(i>=center-barSize/2 & i<=center+barSize/2)
                {
                    for (int j = 0; j != height; j++)
                    {
                        g.canvas[i][j] = 1;
                    }
                }
            }


            g.GotoPosition(position);
            
            g1.Clear(Color.White);
            for (int i = 0; i != width; i++)
            {
                if (g.canvas[i][0] == 1)
                {
                    g1.DrawLine(Pens.Black, i, 0, i, height);
                }
            }


            display.pbCanvas.CreateGraphics().DrawImage(image1, 0, 0);
           
        }

        private void rbMotion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
