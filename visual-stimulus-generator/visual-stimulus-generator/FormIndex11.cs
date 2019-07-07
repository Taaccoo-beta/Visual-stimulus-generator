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
    public partial class FormIndex11 : Form
    {
        public FormIndex11()
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

            //savePath = path + "\\" + name + ".avi";

            this.btnStartDisplay.Enabled = true;
            this.btnGenerate.Enabled = true;
        }

        private void FormIndex11_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.display.Close();
        }


        private Color firstColor = Color.White;
        private Color secondColor = Color.White;
        private Color stopColor = Color.White;
        private Color lastColor = Color.White;
        private Color headColor = Color.Wheat;
        private void btnChooseFColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbShowFColor.BackColor = colorDialog1.Color;

                firstColor = colorDialog1.Color;

                this.pbShowFColor.Invalidate();

            }
        }

        private void FormIndex11_Load(object sender, EventArgs e)
        {
            display = new Display();
            display.Show();
            display.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y + this.Height);
        }

        private void btnChooseSColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbShowSColor.BackColor = colorDialog1.Color;

                secondColor = colorDialog1.Color;

                this.pbShowSColor.Invalidate();

            }
        }
        bool ifmsFirst = true;
        bool ifmsSecond = true;
        bool ifmsStop = true;
        bool ifmsLast = true;
        bool ifmshead = true;
        private void btnFirstTimeSwitch_Click(object sender, EventArgs e)
        {
            if(ifmsFirst)
            {
                ifmsFirst = false;
                this.btnFirstTimeSwitch.Text = "s";
            }
            else
            {
                ifmsFirst = true;
                this.btnFirstTimeSwitch.Text = "ms";
            }

            try
            {
                if (tbFirstTime.Text != "")
                {
                    if (ifmsFirst)
                    {
                        firstTime = int.Parse(tbFirstTime.Text);
                    }
                    else
                    {
                        firstTime = int.Parse(tbFirstTime.Text) * 1000;
                    }

                }




                firstFrame = (int)Math.Ceiling(firstTime / (1000f / frameRate));

                lblShowFFrame.Text = firstFrame.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong number");
            }

            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }

        }

        private void btnSecondTimeSwitch_Click(object sender, EventArgs e)
        {
            if (ifmsSecond)
            {
                ifmsSecond = false;
                this.btnSecondTimeSwitch.Text = "s";
            }
            else
            {
                ifmsSecond = true;
                this.btnSecondTimeSwitch.Text = "ms";
            }

            try
            {
                if (tbSecondTime.Text != "")
                {
                    if (ifmsSecond)
                    {
                        secondeTime = int.Parse(tbSecondTime.Text);
                    }
                    else
                    {
                        secondeTime = int.Parse(tbSecondTime.Text) * 1000;
                    }
                }



                secondFrame = (int)Math.Ceiling(secondeTime / (1000f / frameRate));

                lblShowSFrame.Text = secondFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }
            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }
        }


        int firstTime;
        int firstFrame;

        int secondeTime;
        int secondFrame;

        int stopTime;
        int stopFrame;

        int lastTime;
        int lastFrame;

        int headTime;
        int headFrame;

        int circle;

        private void btnStartDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                display.Width = width;
                display.Height = height;

                image1 = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                g1 = Graphics.FromImage(image1);
                ////使绘图质量最高，即消除锯齿  
                //g1.SmoothingMode = SmoothingMode.AntiAlias;
                //g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //g1.CompositingQuality = CompositingQuality.HighQuality;
                //g1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            }
            catch
            {
                MessageBox.Show("Wrong with input!!");

            }

           
            if(tbFirstTime.Text != "")
            {
                if(ifmsFirst)
                {
                    firstTime = int.Parse(tbFirstTime.Text);
                }
                else
                {
                    firstTime = int.Parse(tbFirstTime.Text)*1000;
                }
                
            }
            else
            {
                MessageBox.Show("First time is Null!");
            }

            if (tbSecondTime.Text != "")
            {
                if (ifmsSecond)
                {
                    secondeTime = int.Parse(tbSecondTime.Text);
                }
                else
                {
                    secondeTime = int.Parse(tbSecondTime.Text)*1000;
                }
            }
            else
            {
                MessageBox.Show("Second time is Null!");
            }

            if (tbStopTime.Text != "")
            {
                if (ifmsStop)
                {
                    stopTime = int.Parse(tbStopTime.Text);
                }
                else
                {
                    stopTime = int.Parse(tbStopTime.Text) * 1000;
                }
            }
            else
            {
                MessageBox.Show("Stop time is Null!");
            }



            try
            {
                if (tbHeadTime.Text != "")
                {
                    if (ifmshead)
                    {
                        headTime = int.Parse(tbHeadTime.Text);
                    }
                    else
                    {
                        headTime = int.Parse(tbHeadTime.Text) * 1000;
                    }
                }



                headFrame = (int)Math.Ceiling(headTime / (1000f / frameRate));

                lblShowHeadFrame.Text = headFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

            try
            {
                if (tbSetLastTime.Text != "")
                {
                    if (ifmsLast)
                    {
                        lastTime = int.Parse(tbSetLastTime.Text);
                    }
                    else
                    {
                        lastTime = int.Parse(tbSetLastTime.Text) * 1000;
                    }
                }



                lastFrame = (int)Math.Ceiling(lastTime / (1000f / frameRate));

                lblShowLastFrame.Text = lastFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

            firstFrame = (int)Math.Ceiling(firstTime / (1000f / frameRate));
            secondFrame= (int)Math.Ceiling(secondeTime / (1000f / frameRate));
            stopFrame = (int)Math.Ceiling(stopTime / (1000f / frameRate));
            lblShowFFrame.Text = firstFrame.ToString();
            lblShowSFrame.Text = secondFrame.ToString();
            lblShowStopFrame.Text = stopFrame.ToString();
            count = 0;

            if(tbcircleTime.Text != "")
            {
                circle = int.Parse(tbcircleTime.Text);

            }
            else
            {
                MessageBox.Show("circle is Null!");
            }


            timer1.Interval = 1000 / frameRate;
            timer1.Start();
        }

        int count = 0;
        bool ifStartSecond = false;
        bool ifStartFirst = true;
        bool ifStartStop = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //g1.Clear(Color.White);


            if (ifStartFirst)
            {
                if (count < firstFrame)
                {
                    g1.FillRectangle(new SolidBrush(firstColor), 0, 0, width, height);
                    count++;
                }
                else
                {
                    
                    ifStartSecond = true;
                    ifStartStop = false;
                    ifStartFirst = false;
                    count = 0;
                }
                

            }
           
            if(ifStartSecond)
            {
                
                if (count<secondFrame)
                {
                    g1.FillRectangle(new SolidBrush(secondColor), 0, 0, width, height);
                    count++;

                }
                else
                {
                    count = 0;
                    ifStartSecond = false ;
                    ifStartFirst = false;
                    ifStartStop = true;
                }
            }

            if (ifStartStop)
            {

                if (count < stopFrame)
                {
                    g1.FillRectangle(new SolidBrush(stopColor), 0, 0, width, height);
                    count++;

                }
                else
                {
                    count = 0;
                    ifStartSecond = false;
                    ifStartFirst = true;
                    ifStartStop = false;
                }
            }








            display.CreateGraphics().DrawImage(image1, 0, 0);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            

           

            progressBar1.Maximum = circle+1;
            progressBar1.Value = progressBar1.Minimum = 0;//设置范围最小值

            VideoFileWriter writer = new VideoFileWriter();
            savePath = path + "\\" + name + ".avi";
           
            writer.Open(savePath, width, height, frameRate, VideoCodec.MSMPEG4v2);
            
            count = 0;
            int countCircle = 0;
            ifStartSecond = false;
            ifStartFirst = true;
            bool ifFinished = false;
            bool ifWrite = true;



            g1.FillRectangle(new SolidBrush(headColor), 0, 0, width, height);
            for (int i = 0; i != headFrame; i++)
            {
                writer.WriteVideoFrame(image1);

            }


            while (!ifFinished)
            {
                Application.DoEvents();

                g1.Clear(Color.White);

                if (ifStartFirst)
                {
                    ifWrite = true;
                    if (count < firstFrame)
                    {
                        g1.FillRectangle(new SolidBrush(firstColor), 0, 0, width, height);

                        count++;
                    }
                    else
                    {

                        ifStartSecond = true;
                        ifStartFirst = false;
                        ifStartStop = false;
                        count = 0;
                    }


                }

                if (ifStartSecond)
                {

                    if (count < secondFrame)
                    {
                        g1.FillRectangle(new SolidBrush(secondColor), 0, 0, width, height);
                       
                        count++;

                    }
                    else
                    {
                        count = 0;
                        ifStartSecond = false;
                        ifStartFirst = false;
                        ifStartStop = true;
                        
                    }
                }



                if (ifStartStop)
                {

                    if (count < stopFrame)
                    {
                        g1.FillRectangle(new SolidBrush(stopColor), 0, 0, width, height);
                        count++;

                    }
                    else
                    {
                        count = 0;
                        ifStartSecond = false;
                        ifStartFirst = true;
                        ifStartStop = false;
                        countCircle++;
                        if (countCircle == circle)
                        {
                            ifFinished = true;
                        }
                        ifWrite = false;
                    }
                }



                if (ifWrite)
                {
                    this.progressBar1.Value = countCircle;
                    writer.WriteVideoFrame(image1);
                }
                
            }

            g1.FillRectangle(new SolidBrush(lastColor), 0, 0, width, height);
            for (int i = 0;i!=lastFrame;i++)
            {
                writer.WriteVideoFrame(image1);

            }

           




            writer.Close();
            this.progressBar1.Value = countCircle+1;
            MessageBox.Show("Saved!!");
        }

        private void tbFirstTime_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (tbFirstTime.Text != "")
                {
                    if (ifmsFirst)
                    {
                        firstTime = int.Parse(tbFirstTime.Text);
                    }
                    else
                    {
                        firstTime = int.Parse(tbFirstTime.Text) * 1000;
                    }

                }




                firstFrame = (int)Math.Ceiling(firstTime / (1000f / frameRate));

                lblShowFFrame.Text = firstFrame.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong number");
            }

            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }

        }

        private void lblShowSFrame_TextChanged(object sender, EventArgs e)
        {



        }

        private void tbSecondTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbSecondTime.Text != "")
                {
                    if (ifmsSecond)
                    {
                        secondeTime = int.Parse(tbSecondTime.Text);
                    }
                    else
                    {
                        secondeTime = int.Parse(tbSecondTime.Text) * 1000;
                    }
                }



                secondFrame =(int) Math.Ceiling(secondeTime / (1000f / frameRate));
              
                lblShowSFrame.Text = secondFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }

        }

        private void btnChooseStopColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbStopShowColor.BackColor = colorDialog1.Color;

                stopColor= colorDialog1.Color;

                this.pbStopShowColor.Invalidate();

            }
        }

        private void btnSwitchStopTime_Click(object sender, EventArgs e)
        {
            if (ifmsStop)
            {
                ifmsStop = false;
                this.btnSwitchStopTime.Text = "s";
            }
            else
            {
                ifmsStop = true;
                this.btnSwitchStopTime.Text = "ms";
            }

            try
            {
                if (tbStopTime.Text != "")
                {
                    if (ifmsStop)
                    {
                        stopTime = int.Parse(tbStopTime.Text);
                    }
                    else
                    {
                        stopTime = int.Parse(tbStopTime.Text) * 1000;
                    }
                }



                stopTime = (int)Math.Ceiling(stopTime / (1000f / frameRate));

                lblShowStopFrame.Text = stopTime.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }

        }

        private void tbcircleTime_TextChanged(object sender, EventArgs e)
        {
            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }
        }

        private void tbStopTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbStopTime.Text != "")
                {
                    if (ifmsStop)
                    {
                        stopTime = int.Parse(tbStopTime.Text);
                    }
                    else
                    {
                        stopTime = int.Parse(tbStopTime.Text) * 1000;
                    }
                }



                stopTime = (int)Math.Ceiling(stopTime / (1000f / frameRate));

                lblShowStopFrame.Text = stopTime.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

            if (tbcircleTime.Text != "")
            {
                float totalTime = (float.Parse(this.tbcircleTime.Text) * (this.firstTime + this.secondeTime + this.stopTime) / 1000f);
                lblShowTotalTime.Text = totalTime.ToString(".0000") + "S";
            }
        }


      
        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbLastColor.BackColor = colorDialog1.Color;

                lastColor = colorDialog1.Color;

                this.pbLastColor.Invalidate();

            }
        }

        private void btnSwitchLastTime_Click(object sender, EventArgs e)
        {
            if (ifmsLast)
            {
                ifmsLast = false;
                this.btnSwitchLastTime.Text = "s";
            }
            else
            {
                ifmsLast = true;
                this.btnSwitchLastTime.Text = "ms";
            }

            try
            {
                if (tbSetLastTime.Text != "")
                {
                    if (ifmsLast)
                    {
                        lastTime = int.Parse(tbSetLastTime.Text);
                    }
                    else
                    {
                        lastTime = int.Parse(tbSetLastTime.Text) * 1000;
                    }
                }



                lastFrame = (int)Math.Ceiling(lastTime / (1000f / frameRate));

                lblShowLastFrame.Text = lastFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

            
        }

        private void tbSetLastTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbSetLastTime.Text != "")
                {
                    if (ifmsLast)
                    {
                        lastTime = int.Parse(tbSetLastTime.Text);
                    }
                    else
                    {
                        lastTime = int.Parse(tbSetLastTime.Text) * 1000;
                    }
                }



                lastFrame = (int)Math.Ceiling(lastTime / (1000f / frameRate));

                lblShowLastFrame.Text = lastFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pbShowHeadColor.BackColor = colorDialog1.Color;

                headColor = colorDialog1.Color;

                this.pbShowHeadColor.Invalidate();

            }
        }

        private void btnSwitchHead_Click(object sender, EventArgs e)
        {
            if (ifmshead)
            {
                ifmshead = false;
                this.btnSwitchHead.Text = "s";
            }
            else
            {
                ifmshead = true;
                this.btnSwitchHead.Text = "ms";
            }

            try
            {
                if (tbHeadTime.Text != "")
                {
                    if (ifmshead)
                    {
                        headTime = int.Parse(tbHeadTime.Text);
                    }
                    else
                    {
                        headTime = int.Parse(tbHeadTime.Text) * 1000;
                    }
                }



                headFrame = (int)Math.Ceiling(headTime / (1000f / frameRate));

                lblShowHeadFrame.Text = headFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }
        }

        private void tbHeadTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbHeadTime.Text != "")
                {
                    if (ifmshead)
                    {
                        headTime = int.Parse(tbHeadTime.Text);
                    }
                    else
                    {
                        headTime = int.Parse(tbHeadTime.Text) * 1000;
                    }
                }



                headFrame = (int)Math.Ceiling(headTime / (1000f / frameRate));

                lblShowHeadFrame.Text = headFrame.ToString();
            }
            catch
            {
                MessageBox.Show("wrong number");
            }
        }
    }
}

