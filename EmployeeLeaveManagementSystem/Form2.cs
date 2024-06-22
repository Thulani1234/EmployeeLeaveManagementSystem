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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public static string setvalueforText1 = "";
        public static string setvalueforText2 = "";
        public static string setvalueforText3 = "";
        public static string setvalueforText4 = "";
        public static string setvalueforText5 = "";
        public static string setvalueforText6 = "";
        public static string setvalueforText7 = "";
        public static string setvalueforText9 = "";
        public static string setvalueforText11 = "";
        public static string setvalueforradiobutton1 = "";
        public static string setvalueforradiobutton2 = "";
        public static string setvalueforcombobox1 = "";
        public static string setvalueforcombobox2 = "";
        public static string setvaluefordatetimepicker1 = "";


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form3();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OfficeExplorer;Integrated Security=True");
            try
            {



                string fullName = textBox1.Text ;
                string address = textBox2.Text;
                string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd"); 
                string gender;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string nationality = comboBox1.Text;
                string religion = comboBox2.Text;
                string empId = textBox5.Text;
                string passWord = textBox11.Text;
                string phoneNumber = textBox3.Text;
                string emailAddress = textBox4.Text;
                string designation = textBox9.Text;
                string officeMailAddress = textBox7.Text;
                setvalueforText1 = textBox1.Text;
                setvalueforText2 = textBox2.Text;
                setvalueforText3 = textBox3.Text;
                setvalueforText4 = textBox4.Text;
                setvalueforText5 = textBox5.Text;
                setvalueforText6 = textBox6.Text;
                setvalueforText7 = textBox7.Text;
                setvalueforText9 = textBox9.Text;
                setvalueforText11 = textBox11.Text;
                setvalueforradiobutton1 = radioButton1.Text;
                setvalueforradiobutton2 = radioButton2.Text;
                setvalueforcombobox1 = comboBox1.Text;
                setvalueforcombobox2 = comboBox2.Text;
                setvaluefordatetimepicker1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                DateTime a = Convert.ToDateTime(dateTimePicker1.Value);

                //  Form10 frm10 = new Form10();
                //  frm10.Show();

                string query_insert = "INSERT INTO EMPLOYEE VALUES('"+fullName+"','"+address+"','"+birthday+"','"+gender+"','"+nationality+"','"+religion+"','"+empId+"','"+passWord+"',"+phoneNumber+",'"+emailAddress+"','"+designation+"','"+officeMailAddress+"')";
                SqlCommand cmd = new SqlCommand(query_insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfuly Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
