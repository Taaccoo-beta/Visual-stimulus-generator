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
    public partial class FormIndex1 : Form
    {
        public FormIndex1()
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
        private void Form2_Load(object sender, EventArgs e)
        {
            display = new Display();
            display.Show();
            display.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y + this.Height);
        }

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

        private void FormIndex1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.display.Close();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private int barSize;
        private int position;
        private float speed;
        private int step;
        private int center;
        Generator g;
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



            barSize = int.Parse(this.tbBarSize.Text);
            position = int.Parse(this.tbPosition.Text);
            speed = float.Parse(this.tbSpeed.Text);

            g = new Generator(width, height);
            g.SetSimpleCanvas();

            if (btnBarSizeSwitch.Text == "Degree")
            {
                barSize = g.DegreeToWidth(barSize);
            }
            
                
            
            center = g.DegreeToPosition(0);

            realRightPosition = g.DegreeToPosition(position);
            realLeftPosition = g.DegreeToPosition(-position);

            for (int i = 0; i != width; i++)
            {

                if (i >= center - barSize / 2 & i <= center + barSize / 2)
                {
                    g.simpleCanvas[i] = 1;
                }

            }

            if (rbRightToLeft.Checked)
            {
                g.SetSimpleCanvasPosition(position);
                orientation = -1;
                positionNow = realRightPosition ;
            }
            else if (rbLeftToRight.Checked)
            {
                g.SetSimpleCanvasPosition(-position);
                orientation = +1;
                positionNow = realLeftPosition;
            }
            else if (rbCenterToLeft.Checked)
            {
                g.SetSimpleCanvasPosition(0);
                orientation = -1;
                positionNow = center;
            }
            else if(rbCenterToRight.Checked)
            {
                g.SetSimpleCanvasPosition(0);
                orientation = +1;
                positionNow = center;

            }

            if (btnSpeedSwitch.Text == "Degree")
            {
                step = g.DegreeToWidth(speed);
            }
            else
            {
                step = (int)speed;
            }

            float recCircleTime = CircleCalc(speed, frameRate, position);
            this.lblCircleTime.Text = recCircleTime.ToString();

            timer1.Interval = 1000/frameRate;
            timer1.Start();

            
        }

        private int orientation;
        private int realRightPosition,realLeftPosition;
        private int positionNow;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (orientation == +1)
            {
                g.MoveRightForSimpleCanvas(step);
                positionNow += step;
                if (positionNow > realRightPosition)
                {
                    orientation = -1;
                }

            }
            if (orientation == -1)
            {
                g.MoveLeftForSimpleCanvas(step);
                positionNow -= step;
                if (positionNow < realLeftPosition)
                {
                    orientation = 1;
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
            display.CreateGraphics().DrawImage(image1, 0, 0);
        }
       
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            g.ClearListForSimpleCanvas();
            int center = g.DegreeToPosition(0);
            for (int i = 0; i != width; i++)
            {

                if (i >= center - barSize / 2 & i <= center + barSize / 2)
                {
                    g.simpleCanvas[i] = 1;
                }

            }

            if (rbRightToLeft.Checked)
            {
                g.SetSimpleCanvasPosition(position);
                orientation = -1;
                positionNow = realRightPosition;
            }
            else if (rbLeftToRight.Checked)
            {
                g.SetSimpleCanvasPosition(-position);
                orientation = +1;
                positionNow = realLeftPosition;
            }
            else if (rbCenterToLeft.Checked)
            {
                g.SetSimpleCanvasPosition(0);
                orientation = -1;
                positionNow = center;
            }
            else if (rbCenterToRight.Checked)
            {
                g.SetSimpleCanvasPosition(0);
                orientation = +1;
                positionNow = center;

            }

            progressBar1.Maximum = (int)(frameRate * time);
            progressBar1.Value = progressBar1.Minimum = 0;//设置范围最小值


            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(savePath, width, height, frameRate, VideoCodec.MPEG4);
            
            for (int i = 0; i != (int)(frameRate * time); i++)
            {
                Application.DoEvents();
                if (orientation == +1)
                {
                    g.MoveRightForSimpleCanvas(step);
                    positionNow += step;
                    if (positionNow > realRightPosition)
                    {
                        orientation = -1;
                    }

                }
                if (orientation == -1)
                {
                    g.MoveLeftForSimpleCanvas(step);
                    positionNow -= step;
                    if (positionNow < realLeftPosition)
                    {
                        orientation = 1;
                    }
                }




                g1.Clear(Color.White);
                for (int ii = 0; ii != width; ii++)
                {
                    if (g.simpleCanvas[ii] == 1)
                    {
                        g1.DrawLine(Pens.Black, ii, 0, ii, height);
                    }
                }


                this.progressBar1.Value = i;
                writer.WriteVideoFrame(image1);
            }

            writer.Close();
            this.progressBar1.Value = (int)(frameRate * time);
            MessageBox.Show("Saved!!");





        }

        private void btnBarSizeSwitch_Click(object sender, EventArgs e)
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

        private void btnSpeedSwitch_Click(object sender, EventArgs e)
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

        public float CircleCalc(float speed,int frameRate,int position)
        {
            
            int rightPosition = g.DegreeToPosition(position);
            int leftPosition = g.DegreeToPosition(-position);
            float count = (float)(rightPosition - leftPosition) / (float)(step);
            return count / (float)frameRate*2.0f;



        }
    }
}
