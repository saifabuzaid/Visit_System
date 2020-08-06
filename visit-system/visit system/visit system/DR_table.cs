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
    public partial class DR_table : Form
    {
        public DR_table()
        {
            InitializeComponent();
        }
        vistDataContext DR = new vistDataContext();
        private void DR_table_Load(object sender, EventArgs e)


        {
            dataGridView1.DataSource = from x in DR.Doctors select new { x.DoctorName, x.DoctorNo, x.phone, x.salary };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Doctor p = new Doctor();
                p.DoctorName = textBox1.Text;
                p.DoctorNo = int.Parse(textBox2.Text);
                p.phone = int.Parse(textBox3.Text);
                p.salary = float.Parse(textBox4.Text);
                DR.Doctors.InsertOnSubmit(p);
                DR.SubmitChanges();
                this.DR_table_Load(null, null);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("There is an empty field, or repeat Primary key");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
