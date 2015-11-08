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
    public partial class Change_Password : Form
    {
        private SqlCeDataAdapter dataAdapter;
        private DataTable dt;
        public string tempPw = "";
        public string tempLogin = "";
        string loginTry = "";
        string passwordTry = "";
        public Change_Password()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Password_Load(object sender, EventArgs args)
        {
            try
            {
                string connectionString = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCeCommand command = new SqlCeCommand("SELECT * from Master", connection))
                    {
                        SqlCeDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            loginTry = Decrypt.DecryptStringAES(reader.GetString(1), "waltsentme");
                            passwordTry = Decrypt.DecryptStringAES(reader.GetString(2), "waltsentme");
                            cLoginTxtBx.Text = loginTry;
                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
                // put your error dialog here
                System.Windows.Forms.MessageBox.Show("Could not bind to database. Check the runtime install and database file.",
                    "Error Binding to Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                //say nobitch
                Application.Exit();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                       
            if (nLoginTxtBx.Text != "" & oPsswrdTxtBx.Text != "") 
            {
                if (nPsswrdTxtBx.Text != "" & cnPsswrdTxtBx.Text != ""){
                   
                    if (oPsswrdTxtBx.Text == passwordTry)
                    {
                        try
                        {
                            string connectionString = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                            {
                                connection.Open();
                                string newLogin = Encrypt.EncryptStringAES(nLoginTxtBx.Text, "waltsentme");
                                string newPassword = Encrypt.EncryptStringAES(cnPsswrdTxtBx.Text, "waltsentme");
                                using (SqlCeCommand command = new SqlCeCommand("UPDATE Master SET MasterUserName='" + newLogin + "', MasterPassword='"+newPassword+"'", connection))
                                {
                                    SqlCeDataReader reader = command.ExecuteReader();
                                }
                                connection.Close();
                                MessageBox.Show("Password and Login have been Changed!");
                                this.Close();
                            }
                        }
                        catch
                        {
                            // put your error dialog here
                            System.Windows.Forms.MessageBox.Show("Could not bind to database. Check the runtime install and database file.",
                                "Error Binding to Database",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);

                            //say nobitch
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect old password!");
                    }
                }
                else
                {
                   
                    if (oPsswrdTxtBx.Text == passwordTry)
                    {
                        try
                        {
                            string connectionString = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                            {
                                connection.Open();
                                string newLogin = Encrypt.EncryptStringAES(nLoginTxtBx.Text, "waltsentme");
                                using (SqlCeCommand command = new SqlCeCommand("UPDATE Master SET MasterUserName='"+newLogin+"'", connection))
                                {
                                    SqlCeDataReader reader = command.ExecuteReader();
                                }
                                connection.Close();
                                MessageBox.Show("Only Login has been changed!");
                                this.Close();
                            }
                        }
                        catch
                        {
                            // put your error dialog here
                            System.Windows.Forms.MessageBox.Show("Could not bind to database. Check the runtime install and database file.",
                                "Error Binding to Database",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);

                            //say nobitch
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect old password!");
                    }
                }
                
            } else if (nPsswrdTxtBx.Text != "" & cnPsswrdTxtBx.Text != ""){
               
                    
                    if (oPsswrdTxtBx.Text == passwordTry)
                    {
                        if (nPsswrdTxtBx.Text == cnPsswrdTxtBx.Text)
                        {
                            try
                            {
                                string connectionString = "Data Source=Accounts.sdf;Password=MySecretPassword;File Mode=Shared Read;Max Database Size=1024";
                                using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                                {
                                    connection.Open();
                                    string newPassword = Encrypt.EncryptStringAES(cnPsswrdTxtBx.Text, "waltsentme");
                                    using (SqlCeCommand command = new SqlCeCommand("UPDATE Master SET MasterPassword='" + newPassword + "'", connection))
                                    {
                                        SqlCeDataReader reader = command.ExecuteReader();
                                    }
                                    connection.Close();
                                    MessageBox.Show("Only Password has been Changed!");
                                    this.Close();
                                }
                            }
                            catch
                            {
                                // put your error dialog here
                                System.Windows.Forms.MessageBox.Show("Could not bind to database. Check the runtime install and database file.",
                                    "Error Binding to Database",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);

                                //say nobitch
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show("New password and password confirmation must match!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Incorrect old password!");
                    }
               
            }
        }
    }
}
