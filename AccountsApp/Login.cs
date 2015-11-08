using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class Login : Form

    {
        private int loginSuccess = 0;
        private string loginTry;
        private string passwordTry;
        public Login()
        {
            
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userString = textBox1.Text;
            string passString = textBox2.Text;
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
                            if (userString == loginTry && passString == passwordTry)
                            {
                                textBox1.Text = "";
                                textBox2.Text = "";
                                Accounts f = new Accounts();
                                f.Show();
                                loginSuccess = 1;
                                this.Hide();
                            }
                            else
                            {
                            //    Do Nothing!
                            }
                        }
                        if (loginSuccess == 0)
                        {
                            textBox1.Text = "";
                            textBox2.Text = "";
                            MessageBox.Show("Error (1): Invalid user name " + userString + " or password " + passString);
                        }
                        }
                    connection.Close();
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password();
            cp.Show();
        }
    }
}
