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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            string employerCode = textBox1.Text;

            if (employerCode == "EC@768143OE")
            {
                this.Hide();
                Form frm = new Form13();
                frm.ShowDialog();
                MainMenu obj = new MainMenu();

            }
            else
            {
                MessageBox.Show("Invalid Code.....");
            }
        }
    }
}
