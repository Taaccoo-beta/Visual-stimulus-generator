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
    public partial class FormIndex8 : Form
    {
        public FormIndex8()
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

        private void FormIndex8_Load(object sender, EventArgs e)
        {
            display = new Display();
            display.Show();
            display.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y + this.Height);
        }

        private void FormIndex8_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.display.Close();
        }

        private void btnSpeedSwitch_Click(object sender, EventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnBarSizeSwitch.Text == "Degree")
            {
                btnBarSizeSwitch.Text = "Pixel";
            }
            else
            {
                btnBarSizeSwitch.Text = "Degree";
            }
        }
        private int barSize;
        private float speed;
        private int step;
        private int center;
        private float degree;
        private int widthUp, widthDown;
        Generator g;

        private RandomPointMoving rg;
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

            step = (int)speed;

            pointSize = float.Parse(tbPointSize.Text);

            if (btnPointSizeSwitch.Text == "Degree")
            {
                pointSize = g.DegreeToWidth(pointSize);
            }
            else
            {
                pointSize = (int)pointSize;
            }

            barSize = int.Parse(tbBarSize.Text);
            if (btnBarSizeSwitch.Text == "Degree")
            {
                barSize = g.DegreeToWidth(barSize);
            }

            degree = float.Parse(tbDegree.Text);
            


            this.lblPointNumber.Text = (width / (float)pointSize).ToString();
            this.lblShowStepAverage.Text = (step / (float)pointSize).ToString();
            
            randomRate = int.Parse(tbRandomRate.Text);
            rg = new RandomPointMoving(width, height, (int)pointSize, barSize, randomRate);

            this.lblShowDegreeRange.Text = "<" + (-PositionToDegree(barSize / 2)).ToString();
            if (rbRightToLeft.Checked)
            {
                positiondegree = degree;
                orientation = -1;
               
            }
            else if (rbLeftToRight.Checked)
            {
                positiondegree = -degree;
                orientation = +1;
                
            }
            else if (rbCenterToLeft.Checked)
            {
                positiondegree = 0;
                orientation = -1;
               
            }
            else if (rbCenterToRight.Checked)
            {
                positiondegree = 0;
                orientation = +1;
               

            }

            widthUp = int.Parse(tbWUp.Text);
            widthDown = int.Parse(tbWDown.Text);
            realRightpPosition = DegreeToWidth(degree);
            realLeftPosition = DegreeToWidth(-degree);
            timer1.Interval = 1000 / frameRate;
            timer1.Start();
        }

        private int DegreeToWidth(float degree)
        {
            return (int)(degree / 360f * width);
        }

        private int getPositionOfBar(float degree)
        {
            return (int)(degree / 360f * width + width / 2f);
        }

        private int PositionToDegree(int position)
        {
            return position * 360 / width - 180;
        }
        float positiondegree = 0;
        int orientation = 1;
        int realRightpPosition;
        int realLeftPosition;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int startDegree = getPositionOfBar(positiondegree) - barSize/2;
            g1.Clear(Color.White);
            for (int i = 0; i != width; i++)
            {

                if (i >= startDegree & i < startDegree + barSize)
                {
                    for (int j = 0; j != height; j++)
                    {
                        if (j >= widthUp & j <= widthDown)
                        {
                            if (rg.bar.randomCanvasBackground[i - startDegree][j] == 0)
                            {
                                image1.SetPixel(i, j, Color.Black);

                            }
                        }
                        else
                        {
                            if (rg.background.randomCanvasBackground[i][j] == 0)
                            {
                                image1.SetPixel(i, j, Color.Black);

                            }
                        }

                    }
                }
                else
                {
                    for (int j = 0; j != height; j++)
                    {
                        if (rg.background.randomCanvasBackground[i][j] == 0)
                        {
                            image1.SetPixel(i, j, Color.Black);

                        }

                    }
                }
            }

            if (orientation == 1)
            {
                positiondegree += step;
                if (positiondegree > degree)
                {
                    orientation = -1;
                }
                
            }

            if (orientation == -1)
            {
                positiondegree -= step;
                if (positiondegree < -degree)
                {
                    orientation = 1;
                }
            }

            display.CreateGraphics().DrawImage(image1, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            if (rbRightToLeft.Checked)
            {
                positiondegree = degree;
                orientation = -1;

            }
            else if (rbLeftToRight.Checked)
            {
                positiondegree = -degree;
                orientation = +1;

            }
            else if (rbCenterToLeft.Checked)
            {
                positiondegree = 0;
                orientation = -1;

            }
            else if (rbCenterToRight.Checked)
            {
                positiondegree = 0;
                orientation = +1;


            }

            progressBar1.Maximum = (int)(frameRate * time);
            progressBar1.Value = progressBar1.Minimum = 0;//设置范围最小值

            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(savePath, width, height, frameRate, VideoCodec.MPEG4);


            for (int ii = 0; ii != (int)(frameRate * time); ii++)
            {
                Application.DoEvents();



                int startDegree = getPositionOfBar(positiondegree) - barSize / 2;
                g1.Clear(Color.White);
                for (int i = 0; i != width; i++)
                {

                    if (i >= startDegree & i < startDegree + barSize)
                    {
                        for (int j = 0; j != height; j++)
                        {
                            if (j >= widthUp & j <= widthDown)
                            {
                                if (rg.bar.randomCanvasBackground[i - startDegree][j] == 0)
                                {
                                    image1.SetPixel(i, j, Color.Black);

                                }
                            }
                            else
                            {
                                if (rg.background.randomCanvasBackground[i][j] == 0)
                                {
                                    image1.SetPixel(i, j, Color.Black);

                                }
                            }

                        }
                    }
                    else
                    {
                        for (int j = 0; j != height; j++)
                        {
                            if (rg.background.randomCanvasBackground[i][j] == 0)
                            {
                                image1.SetPixel(i, j, Color.Black);

                            }

                        }
                    }
                }

                if (orientation == 1)
                {
                    positiondegree += step;
                    if (positiondegree > degree)
                    {
                        orientation = -1;
                    }

                }

                if (orientation == -1)
                {
                    positiondegree -= step;
                    if (positiondegree < -degree)
                    {
                        orientation = 1;
                    }
                }




                this.progressBar1.Value = ii;
                writer.WriteVideoFrame(image1);
            }
            writer.Close();
            this.progressBar1.Value = (int)(frameRate * time);
            MessageBox.Show("Saved!!");


        }
    }
}
