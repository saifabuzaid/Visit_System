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
    public partial class Pa_Q : Form
    {
        public Pa_Q()
        {
            InitializeComponent();
        }

                vistDataContext Pa_Q = new vistDataContext();

        private void DR_Q_Load(object sender, EventArgs e)
        {

        }
        /*
         show all data
  id >3
 name start  in a
 dr with  pachent
         
         */
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {

                case 0: dataGridView1.DataSource = from x in Pa_Q.patients select x; break;
                case 1: dataGridView1.DataSource = from x in Pa_Q.patients where x.PatientNo > 3 select x; break;
                case 2: dataGridView1.DataSource = from x in Pa_Q.patients where x.patientName.ToString().ToUpper().StartsWith("A") select x; break;
                case 3: dataGridView1.DataSource = from x in Pa_Q.patients
                                                   from Y in Pa_Q.patients
                                                   from z in Pa_Q.patients
                                                   where x.patientName == z.patientName&&
                                                   Y.PatientNo == z.PatientNo
                                                   orderby x.PatientNo
                                                   select new { x.phone,Y.PatientNo,Y.patientName}; break;


            }
            }
        }
    }

