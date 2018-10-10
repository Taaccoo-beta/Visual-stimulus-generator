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
    public partial class FormIndex0 : Form
    {
        
        public FormIndex0()
        {
            InitializeComponent();
        }

        private void FormIndex0_Load(object sender, EventArgs e)
        {

        }

        private int width;
        private int height;
        private int barSize;
        private int time;
        private int frameRate;
        private int position;
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

            }
            catch
            {
                MessageBox.Show("Wrong with input!!");
            }

            Display d = new Display(width,height);
            d.Show();


            Generator g = new Generator(width, height);
            int barSize_int = g.DegreeToPosition(barSize);

            for (int i = 0; i != width; i++)
            {
                for (int j = 0; j != height; j++)
                {
                    
                }
            }

            d.pbDisplay.CreateGraphics().DrawImage(new Bitmap(), 0, 0);


            
        }

        private void rbMotion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
