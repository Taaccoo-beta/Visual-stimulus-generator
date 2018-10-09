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

        private void btnStartDisplay_Click(object sender, EventArgs e)
        {
            Display d = new Display(1000,1000);
            d.Show();
            
        }

        private void rbMotion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
