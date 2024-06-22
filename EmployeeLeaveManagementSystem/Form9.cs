using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeLeaveManagementSystem
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form4();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form8();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddtoList(listView1, "Select Date,Reason from Company_Holidays");
        }
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
            catch (Exception ex)
            {
                // db.ErrorLog(ex.Message, "ClsCommon,AddtoList");

            }
        }



    }
}
