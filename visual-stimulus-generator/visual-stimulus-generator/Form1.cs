using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.FFMPEG;
using System.Reflection;

namespace visual_stimulus_generator
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int stimulusNumber = 0;
            if (lbVisualStimulusType.SelectedItem != null)
            {
                stimulusNumber = lbVisualStimulusType.SelectedIndex;


                switch (stimulusNumber)
                {
                    case 0:
                        
                        FormIndex0 f0 = new FormIndex0();
                        f0.Show();
                        f0.Location = new System.Drawing.Point(this.Location.X + this.Width , this.Location.Y);
                        break;
                    case 1:
                        
                        FormIndex1 f1 = new FormIndex1();
                        f1.Show();
                        f1.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 2:
                        
                        FormIndex2 f2 = new FormIndex2();
                        f2.Show();
                        f2.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 3:
                       
                        FormIndex3 f3 = new FormIndex3();
                        f3.Show();
                        f3.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 4:
                       
                        FormIndex4 f4 = new FormIndex4();
                        f4.Show();
                        f4.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 5:
                        
                        FormIndex5 f5 = new FormIndex5();
                        f5.Show();
                        f5.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 6:
                        FormIndex6 f6 = new FormIndex6();
                        f6.Show();
                        f6.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 7:
                        FormIndex7 f7 = new FormIndex7();
                        f7.Show();
                        f7.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 8:
                        FormIndex8 f8 = new FormIndex8();
                        f8.Show();
                        f8.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 9:
                        FormIndex9 f9 = new FormIndex9();
                        f9.Show();
                        f9.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;
                    case 10:
                        FormIndex10 f10 = new FormIndex10();
                        f10.Show();
                        f10.Location = new System.Drawing.Point(this.Location.X + this.Width, this.Location.Y);
                        break;

                    default:
                        break;

                }
            }
            else
            {
                MessageBox.Show("No item choosed!!");
            }

           
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private int selectIndex = 0;
        private void lbVisualStimulusType_SelectedIndexChanged(object sender, EventArgs e)
        {

            
         }


      
        

      





    }
}
