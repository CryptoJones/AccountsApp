using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace AccountsApp
{
    public partial class ViewAll : Form
    {

        private SqlCeDataAdapter dataAdapter;
        private DataTable dt;
        public ViewAll()
        {
            InitializeComponent();
            int plainTextPasswordsFound = 0;
            try
            {

                    string strCon = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                    string strSQL = "SELECT * from Account";
                    dataAdapter = new SqlCeDataAdapter(strSQL, strCon);
                    SqlCeCommandBuilder commandbuilder = new SqlCeCommandBuilder(dataAdapter);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                string tempPw = "";
                    foreach(DataRow row in dt.Rows){
                        tempPw = row["Password"].ToString();
                        if (tempPw.Length > 16) {
                            row["Password"] = Decrypt.DecryptStringAES(tempPw, "waltsentme");
                            
                        }
                        else
                        {
                            plainTextPasswordsFound = 1;
                        }
                    }
                    dbGridView2.DataSource = dt;
                    if (plainTextPasswordsFound == 1)
                    {
                        warnLbl.Visible = true;
                    }

                    dbGridView2.Columns[0].Visible = false;
                    dbGridView2.Columns[3].Width = 188;
                    dbGridView2.Update();
                    
                    
                
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            warnLbl.Visible = false;

            dbGridView2.EndEdit();
            string mytempPw;
            foreach (DataRow row in dt.Rows)
            {
                mytempPw = row["Password"].ToString();
                row["Password"] = Encrypt.EncryptStringAES(mytempPw, "waltsentme");
            }
            dataAdapter.Update(dt);
            button1.Enabled = false;
        }

        private void dbGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            warnLbl.Visible = true;
            foreach (DataGridViewRow item in this.dbGridView2.SelectedRows)
            {
                dbGridView2.Rows.RemoveAt(item.Index);
                dataAdapter.Update(dt);
            }
        }

        
    }
}


