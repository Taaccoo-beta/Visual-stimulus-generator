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

        public Display(int width,int height)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;

            this.width = width;
            this.height = height;
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Display_Load(object sender, EventArgs e)
        {
           
        }
    }
}
