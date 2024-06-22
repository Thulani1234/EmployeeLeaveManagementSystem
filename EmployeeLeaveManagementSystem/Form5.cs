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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string setvaluefordatetimepicker1="";
        public static string setvaluefordatetimepicker2 = "";
        public static string setvalueforcombobox1= "";
        public static string setvaluefortextbox1 = "";
        public static string setvalueforlabel8 = "";




        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form4();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach (string filename in openFileDialog1.FileNames)
            {
                MessageBox.Show(filename);
                label8.Text = filename.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OfficeExplorer;Integrated Security=True");
            try
            {
                string StartDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string EndDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string LeaveCategory = comboBox1.Text;
                string Reason = textBox1.Text;
                setvaluefordatetimepicker1= dateTimePicker1.Value.ToString("yyyy-MM-dd");
                DateTime a = Convert.ToDateTime(dateTimePicker1.Value);
                setvaluefordatetimepicker2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                DateTime b = Convert.ToDateTime(dateTimePicker2.Value);
                setvalueforcombobox1 = comboBox1.Text;
                setvaluefortextbox1 = textBox1.Text;
                setvalueforlabel8 = label8.Text;
                //Form6 frm6 = new Form6();
               // frm6.Show();
                //Form14 frm14 = new Form14();
                ////frm14.Show();
                string query_insert = "INSERT INTO leaves VALUES('"+StartDate+"','"+EndDate+"','"+LeaveCategory+"','"+Reason+"')";
                SqlCommand cmd = new SqlCommand(query_insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Successfully Applied.....");
               
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
