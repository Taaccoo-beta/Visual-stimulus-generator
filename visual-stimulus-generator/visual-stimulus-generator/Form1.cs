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
    public partial class Form1 : Form
    {

        private StimulusPreview sp;
        private VisualStimulusDescribe vsd;

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
                        this.timer1.Stop();
                        FormIndex0 f0 = new FormIndex0();
                        f0.Show();
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
            vsd = new VisualStimulusDescribe();
            sp = new StimulusPreview(this.pbPreView.Width, this.pbPreView.Height, Color.White);
            timer1.Interval = 50;
            timer1.Start();

        }

        private int selectIndex = 0;
        private void lbVisualStimulusType_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectIndex = lbVisualStimulusType.SelectedIndex;
            this.lblDescription.Text = vsd.getDescribtion(selectIndex);
            ifSelectIndex = true;
            
            degreeForSingleSwingBar = -45;

            degreeForCyclicBar = -180;

            timer1.Start();

    }


        private float degreeForSingleSwingBar = -45;
        private float orientation = 1;

        private float degreeForCyclicBar = -180;
        private bool ifSelectIndex = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ifSelectIndex)
            {
                switch (selectIndex)
                {
                    case 0:
                        this.pbPreView.CreateGraphics().DrawImage(sp.singleBar(), 0, 0);
                        break;
                    case 1:
                        degreeForSingleSwingBar += 3*orientation;
                        if (degreeForSingleSwingBar > 45)
                        {
                            orientation = -1;

                        }
                        if (degreeForSingleSwingBar < -45)
                        {
                            orientation = 1;
                        }
                        this.pbPreView.CreateGraphics().DrawImage(sp.singleSwingBar(degreeForSingleSwingBar), 0, 0);
                        break;
                    case 2:
                        degreeForCyclicBar += 3;
                        if (degreeForCyclicBar > 180)
                        {
                            degreeForCyclicBar = -180;
                        }
                        this.pbPreView.CreateGraphics().DrawImage(sp.singleCyclicBar(degreeForCyclicBar), 0, 0);
                        break;
                }
            }
            else
            {
                ;
            }
        }
    }
}
