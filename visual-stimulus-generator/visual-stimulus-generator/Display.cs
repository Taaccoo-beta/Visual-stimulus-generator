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

        
      


        public Display()
        {
            InitializeComponent();
            this.Width = 200;
            this.Height = 80;
           
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

       

        private void Display_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 20;
            
        }

        private Point mouseOff;
        private bool leftFlag;
        private void Display_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
           
        }

        private void Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
            
        }

        private void Display_MouseUp(object sender, MouseEventArgs e)
        {
            leftFlag = false;
        }
    }
}
