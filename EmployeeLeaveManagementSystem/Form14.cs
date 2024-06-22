using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeLeaveManagementSystem
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form13();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            label8.Text = Form2.setvalueforText5;
            label9.Text = Form2.setvalueforText1;
            label10.Text = Form5.setvaluefordatetimepicker1;
            label11.Text = Form5.setvaluefordatetimepicker2;
            label12.Text = Form5.setvalueforcombobox1;
            label13.Text = Form5.setvaluefortextbox1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string status;
            if (radioButton1.Checked)
            {
                status = "APPROVED";
                MessageBox.Show("Your Leave Has Been Approved.....");
            }
            else
            {
                status = "Rejected";
                MessageBox.Show("Your Leave Has Been Rejected.....");
            }
        }
    }
}
