using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeLeaveManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OfficeExplorer;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from employee where OFFICE_MAIL_ADDRESS = '"+ textBox1.Text.Trim() +"' and PASS_WORD= '"+ textBox2.Text.Trim() + "'  ", con);

                //SqlCommand cmd = new SqlCommand("Select* from employee where OFFICE_MAIL_ADDRESS = 'abc' and PASS_WORD = '123'  ", con);
                
              //  cmd.Parameters.AddWithValue("@OfficeMailAddress", textBox1.Text);
              //  cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logged in Successfully.....");
                    this.Hide();
                    Form frm = new Form4();
                    frm.ShowDialog();
                    MainMenu obj = new MainMenu();
                    
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect....");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }
    }
}
