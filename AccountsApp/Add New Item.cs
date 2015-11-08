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
    
    public partial class Add_New_Item : Form
    {
        private SqlCeDataAdapter dataAdapter;
        private DataTable dt;
        public Add_New_Item()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           string userNameString = UserNameBox.Text;
           string passwordString = Encrypt.EncryptStringAES(PasswordBox.Text, "waltsentme");
           string urlString = URLBox.Text;
           string hostString = HostNameBox.Text;
           string serviceString = ServiceBox.Text;
           string serviceTypeString = ServiceTypeBox.Text;

           if (UserNameBox.Text == "")
           {
            MessageBox.Show("Missing Parameter $UserName!");
           } else if (PasswordBox.Text == ""){
               MessageBox.Show("Missing Parameters $Password!");
           } else if (HostNameBox.Text == ""){
               MessageBox.Show("Missing Parameters $HostName!");
           } else if (ServiceBox.Text == ""){
            MessageBox.Show("Missing Parameters $ServiceName!");
          
           
           }
           else {
               try
               {

                   string strCon = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                   string strSQL = "INSERT INTO Account (UserName, PASSWORD, URL, HostName, ServiceName, SvcTypeName) VALUES ('" + userNameString + "', '" + passwordString + "', '" + urlString + "', '" + hostString + "', '" + serviceString + "', '" + serviceTypeString + "')";
                   dataAdapter = new SqlCeDataAdapter(strSQL, strCon);
                   SqlCeCommandBuilder commandbuilder = new SqlCeCommandBuilder(dataAdapter);
                   dt = new DataTable();
                   dataAdapter.Fill(dt);
                   this.Close();
               }
               catch (SqlCeException ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }
        }
    }
}
