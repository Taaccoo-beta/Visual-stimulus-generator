using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_stimulus_generator
{
    public partial class Display : Form
    {

        private int width, height;
        private Graphics g1;
        private Bitmap image1;


        public Display(int width,int height)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;

            this.width = width;
            this.height = height;

            image1 = new Bitmap(width, height);
            g1 = Graphics.FromImage(image1);
            g1.DrawRectangle(Pens.White, 0, 0, 100, 100);
            pbCanvas.CreateGraphics().DrawImage(image1, 0, 0);
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g1.FillRectangle(new SolidBrush(Color.Black), 0, 0, width, height);

            pbCanvas.CreateGraphics().DrawImage(image1, 0, 0);
        }

        private void Display_Load(object sender, EventArgs e)
        {
           
        }
    }
}
