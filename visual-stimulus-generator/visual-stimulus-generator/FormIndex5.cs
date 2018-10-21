﻿using System;
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

            speed = float.Parse(this.tbSpeed.Text);

            g = new Generator(width, height);
            g.SetSimpleCanvas();

            if (btnBarSizeSwitch.Text == "Degree")
            {
                barSize = g.DegreeToWidth(barSize);
            }




            bool ifWhite = true;

            for (int i = 0; i != width; i++)
            {
                if (i % barSize == 0)
                {
                    ifWhite = !ifWhite;
                }
                if (ifWhite)
                {
                    g.simpleCanvas[i] = 1;
                }
                else
                {
                    g.simpleCanvas[i] = 0;
                }

            }




            if (btnSpeedSwitch.Text == "Degree")
            {
                step = g.DegreeToWidth(speed);
            }
            else
            {
                step = (int)speed;
            }


            this.lblCircleTime.Text = (width / (float)barSize).ToString();
            
            timer1.Interval = 1000 / frameRate;
            timer1.Start();
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

        private void button1_Click(object sender, EventArgs e)
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RandomPointGenerator rpg = new RandomPointGenerator(100, 100);
            rpg.GeneratePoint(10, 60);
        }
    }
}
