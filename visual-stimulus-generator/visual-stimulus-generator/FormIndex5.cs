using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_stimulus_generator
{
    public partial class FormIndex5 : Form
    {
        public FormIndex5()
        {
            InitializeComponent();
        }

        private int width;
        private int height;
        private float time;
        private int frameRate;
        private string name;
        private string path;
        private string savePath;

        Graphics g1;
        Bitmap image1;

        private Display display;


        private void btnChoicePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowDialog = new FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            string path = BrowDialog.SelectedPath;
            lblPathValue.Text = path;
        }

        private void lblSet_Click(object sender, EventArgs e)
        {
            width = int.Parse(this.tbWidthValue.Text);
            height = int.Parse(this.tbHeightValue.Text);
            time = int.Parse(this.tbTime.Text);
            frameRate = int.Parse(this.tbFrameRate.Text);
            path = this.lblPathValue.Text;
            name = this.tbVideoName.Text;

            NameDetection nd = new NameDetection(path, this.tbVideoName.Text);
            if (nd.NameSearch())
            {
                System.Windows.Forms.DialogResult dr = MessageBox.Show("实验名重复，是否重设？", "是", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    this.tbVideoName.Focus();
                }
                else
                {
                    name = this.tbVideoName.Text;

                }
            }

            savePath = path + "\\" + name + ".avi";

            this.btnStartDisplay.Enabled = true;
            this.btnGenerate.Enabled = true;
           
        }

        private void FormIndex5_Load(object sender, EventArgs e)
        {
            display = new Display();
            display.Show();
            display.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y + this.Height);
        }

        private int barSize;
        private float speed;
        private int step;
        private int center;
        Generator g;

        private RandomPointGenerator rg;
        private float pointSize;
        private int randomRate;
        private void btnStartDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                display.Width = width;
                display.Height = height;

                image1 = new Bitmap(width, height, PixelFormat.Format24bppRgb);
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
            speed = int.Parse(tbSpeed.Text);

            if (btnSpeedSwitch.Text == "Degree")
            {
                step = g.DegreeToWidth(speed);
            }
            else
            {
                step = (int)speed;
            }
            

            pointSize = float.Parse(tbPointSize.Text);
            
            if (btnPointSizeSwitch.Text == "Degree")
            {
                pointSize = g.DegreeToWidth(pointSize);
            }
            else
            {
                pointSize = (int)pointSize;
            }
            if (pointSize < 1)
            {
                MessageBox.Show("PointSize less than 1 !!!");
            }
            this.lblPointNumber.Text = (width / (float)pointSize).ToString();
            this.lblShowStepAverage.Text = (step / (float)pointSize).ToString();
            MessageBox.Show(((int)pointSize).ToString());
            rg = new RandomPointGenerator(width, height, (int)pointSize);

            randomRate = int.Parse(tbRandomRate.Text);

            rg.setRandomPoint(randomRate);
            

            timer1.Interval = 1000 / frameRate;
            timer1.Start();
        }

       


      
       
       

        private void btnPointSizeSwitch_Click(object sender, EventArgs e)
        {
            if (btnPointSizeSwitch.Text == "Degree")
            {
                btnPointSizeSwitch.Text = "Pixel";
            }
            else
            {
                btnPointSizeSwitch.Text = "Degree";
            }
        }

        private void btnSpeedSwitch_Click_1(object sender, EventArgs e)
        {
            if (btnSpeedSwitch.Text == "Degree")
            {
                btnSpeedSwitch.Text = "Pixel";
            }
            else
            {
                btnSpeedSwitch.Text = "Degree";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g1.Clear(Color.White);
            for (int i = 0; i != width; i++)
            {
                for (int j = 0; j != height; j++)
                {
                    if (rg.randomCanvasBackground[i][j] == 0)
                    {
                        image1.SetPixel(i, j, Color.Black);

                    }

                }
            }

            if (rbLeftToRight.Checked)
            {
                rg.MoveRightForSimpleCanvas(step);
            }
            else if (rbRightToLeft.Checked)
            {
                rg.MoveLeftForSimpleCanvas(step);
            }
            else
            {
                ;
            }

            display.CreateGraphics().DrawImage(image1, 0, 0);
        }

        private void FormIndex5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.display.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            rg = new RandomPointGenerator(width, height, (int)pointSize);

            
            rg.setRandomPoint(randomRate);


            progressBar1.Maximum = (int)(frameRate * time);
            progressBar1.Value = progressBar1.Minimum = 0;//设置范围最小值


            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(savePath, width, height, frameRate, VideoCodec.MPEG4);

            for (int ii = 0; ii != (int)(frameRate * time); ii++)
            {

                Application.DoEvents();
                g1.Clear(Color.White);
                for (int i = 0; i != width; i++)
                {
                    for (int j = 0; j != height; j++)
                    {
                        if (rg.randomCanvasBackground[i][j] == 0)
                        {
                            image1.SetPixel(i, j, Color.Black);

                        }

                    }
                }


                if (rbLeftToRight.Checked)
                {
                    rg.MoveRightForSimpleCanvas(step);
                }
                else if (rbRightToLeft.Checked)
                {
                    rg.MoveLeftForSimpleCanvas(step);
                }
                else
                {
                    ;
                }

                writer.WriteVideoFrame(image1);


                this.progressBar1.Value = ii;

            }

            writer.Close();
            this.progressBar1.Value = (int)(frameRate * time);
            MessageBox.Show("Saved!!");
        }
    }
}
