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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form12();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form14();
            frm.ShowDialog();
        }

      

       
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form10();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form15();
            frm.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not logged in.....");
        }
    }
}
