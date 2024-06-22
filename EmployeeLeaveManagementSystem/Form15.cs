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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form13();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form10();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OfficeExplorer;Integrated Security=True");
            try
            {
                string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string Reason = textBox1.Text;
                string query_insert = "INSERT INTO Company_Holidays VALUES('" + Date + "','" + Reason + "')";
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
                MessageBox.Show("Successfully Saved.....");
                
               



            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddtoList(listView1, "Select Date,Reason from Company_Holidays");
          
        }

        //public static void OpenSqlCon()
        //{
        //    try
        //    {

        //        if (sqlCon.State == ConnectionState.Open)
        //        {
        //            sqlCon.Close();
        //        }

        //        ConString = ConfigurationManager.ConnectionStrings["MinCon"].ConnectionString;
        //        sqlCon.ConnectionString = ConString;
        //        sqlCon.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //       // ErrorLog(ex.Message, "db,OpenConnection");

        //    }
        //}
        public static SqlDataReader getDataReader(string SqlStatement)
        {
            SqlDataReader reader = null;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OfficeExplorer;Integrated Security=True");
               
                SqlCommand cmd = new SqlCommand(SqlStatement, con);
                //CloseSqlCon();
                cmd = con.CreateCommand();
                cmd.CommandText = SqlStatement;
            //    cmd.CommandTimeout = Settings.Default.TimeOut;
              // OpenSqlCon();
                con.Open();
                reader = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
             //  ErrorLog(ex.Message, "db, getDataReader");

            }

            return reader;

        }
        private SqlDataReader _Dr;
        public void Reader(string SqlString)
        {
            try
            { 
                _Dr = getDataReader(SqlString);
            }
            catch (Exception ex)
            {

               // ErrorLog(ex.Message, "clsCommon,Reader");
            }

        }
        public void AddtoList(ListView Lstvw, string Query)
        {
            try
            {
                Lstvw.Items.Clear();
                Reader(Query);
                while (_Dr.Read())
                {
                    ListViewItem LstITem = new ListViewItem(_Dr[0].ToString());
                    for (int i = 1; i < _Dr.FieldCount; i++)
                    {
                        LstITem.SubItems.Add(_Dr[i].ToString());
                    }
                    Lstvw.Items.Add(LstITem);
                }

            }
            catch (Exception)
            {
               // db.ErrorLog(ex.Message, "ClsCommon,AddtoList");

            }
        }



    }
}
