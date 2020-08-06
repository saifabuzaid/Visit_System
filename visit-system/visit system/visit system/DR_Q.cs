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
    public partial class Q_DR : Form
    {
        public Q_DR()
        {
            InitializeComponent();
        }
        vistDataContext DR_Q = new vistDataContext();

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

                case 0: dataGridView1.DataSource = from x in DR_Q.Doctors select x; break;
                case 1: dataGridView1.DataSource = from x in DR_Q.Doctors where x.DoctorNo > 3 select x; break;
                case 2: dataGridView1.DataSource = from x in DR_Q.Doctors where x.DoctorName.ToString().ToUpper().StartsWith("A") select x; break;
                case 3: dataGridView1.DataSource = from x in DR_Q.Doctors
                                                   from Y in DR_Q.patients
                                                   from z in DR_Q.visites
                                                   where x.DoctorNo == z.DoctorNo &&
                                                   Y.PatientNo == z.patientno
                                                   orderby x.DoctorNo
                                                   select new { x.DoctorName, x.DoctorNo,Y.PatientNo,Y.patientName}; break;


            }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

