using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace visit_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DR_table DR_T = new DR_table();
            DR_T.Show();
        }

        private void dRQuaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q_DR DR_Quary = new Q_DR();
            DR_Quary.Show();
        }

        private void aboutDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_DB DB_ABOUT = new About_DB();
            DB_ABOUT.Show();
        }

        

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void patientQuaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pa_Q Pa_Quary = new Pa_Q();
            Pa_Quary.Show();
        }

       
    }
}
