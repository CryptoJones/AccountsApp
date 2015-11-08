using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;

namespace AccountsApp
{
    public partial class Search : Form
    {
        //make dataadapter and datatable members so they can also
        //be used by the submit button method
        private SqlCeDataAdapter dataAdapter;
        private DataTable dt;

        public Search(string searchString, string searchType)
        {

            InitializeComponent();

            try
            {
                if (searchString != null)
                {
                    string strCon = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                    string strSQL = "SELECT UserName, Password, URL, HostName, ServiceName, SvcTypeName from Account WHERE " + searchType + " LIKE '%" + searchString + "%'";
                   
                    dataAdapter = new SqlCeDataAdapter(strSQL, strCon);
                    SqlCeCommandBuilder commandbuilder = new SqlCeCommandBuilder(dataAdapter);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                     string tempPw = "";
                     foreach (DataRow row in dt.Rows)
                     {
                         tempPw = row["Password"].ToString();
                         if (tempPw.Length > 16)
                         {
                             row["Password"] = Decrypt.DecryptStringAES(tempPw, "waltsentme");
                         }
                     }
                    dbGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    dbGridView.DataSource = dt;



                    textBox1.Text = searchString;
                    textBox2.Text = searchType;



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {

            //dbGridView.Update(); <------ this simply redraws the datagridview. 
            //Has nothing to do with data.

            //code required for the update (for the submit to work)

            //make sure the datagriview has ended editing
            dbGridView.EndEdit();

            //call update on the datatable bound to your datagrdiview
            dataAdapter.Update(dt);
        }

        private void dbGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
