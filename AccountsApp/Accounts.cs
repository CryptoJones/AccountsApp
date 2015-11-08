using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class Accounts : Form
    {
        string userNameString;
        string passwordString;
        string hostString;
        string serviceString;
        string urlString;
        string svcTypeNameString;
        public Accounts()
        {
            InitializeComponent();
            this.ActiveControl = hostBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           
            userNameString = usernameBox.Text;
            passwordString = passwordBox.Text;
            hostString = hostBox.Text;
            serviceString = serviceBox.Text;
            urlString = urlBox.Text;
            svcTypeNameString = svcTypeBox.Text;

            if (usernameBox.Text != ""
                  || urlBox.Text != ""
                  || passwordBox.Text != ""
                  || hostBox.Text != ""
                  || serviceBox.Text != ""
                  || svcTypeBox.Text != "")
            {
            
            while (usernameBox.Text != ""){
                if (passwordBox.Text !="") { tooManySearchParams(); }
                else if (hostBox.Text != "") { tooManySearchParams(); }
                else if (serviceBox.Text != "") { tooManySearchParams(); }
                else if (urlBox.Text != "") { tooManySearchParams(); }
                else if (svcTypeBox.Text != "") { tooManySearchParams(); }
                else {
                    usernameSearch(userNameString);
                     } //end final else 
            } //ends username while

            while (passwordBox.Text != "")
            {
                if (usernameBox.Text != "") { tooManySearchParams(); }
                else if (hostBox.Text != "") { tooManySearchParams(); }
                else if (serviceBox.Text != "") { tooManySearchParams(); }
                else if (urlBox.Text != "") { tooManySearchParams(); }
                else if (svcTypeBox.Text != "") { tooManySearchParams(); }
                else
                {
                    passwordSearch(passwordString);
                } //end final else 
            } //ends passwordbox while


            while (hostBox.Text != "")
            {
                if (usernameBox.Text != "") { tooManySearchParams(); }
                else if (passwordBox.Text != "") { tooManySearchParams(); }
                else if (serviceBox.Text != "") { tooManySearchParams(); }
                else if (urlBox.Text != "") { tooManySearchParams(); }
                else if (svcTypeBox.Text != "") { tooManySearchParams(); }
                else
                {
                    hostSearch(hostString);
                } //end final else 
            } //ends username while

            while (serviceBox.Text != "")
            {
                if (usernameBox.Text != "") { tooManySearchParams(); }
                else if (passwordBox.Text != "") { tooManySearchParams(); }
                else if (hostBox.Text != "") { tooManySearchParams(); }
                else if (urlBox.Text != "") { tooManySearchParams(); }
                else if (svcTypeBox.Text != "") { tooManySearchParams(); }
                else
                {
                    serviceSearch(serviceString);
                } //end final else 
            } //ends servicebox while


            while (urlBox.Text != "")
            {
                if (usernameBox.Text != "") { tooManySearchParams(); }
                else if (passwordBox.Text != "") { tooManySearchParams(); }
                else if (hostBox.Text != "") { tooManySearchParams(); }
                else if (serviceBox.Text != "") { tooManySearchParams(); }
                else if (svcTypeBox.Text != "") { tooManySearchParams(); }
                else
                {
                    urlSearch(urlString);
                } //end final else 
            } //ends urlBox while

            while (svcTypeBox.Text != "")
            {
                if (usernameBox.Text != "") { tooManySearchParams(); }
                else if (passwordBox.Text != "") { tooManySearchParams(); }
                else if (hostBox.Text != "") { tooManySearchParams(); }
                else if (serviceBox.Text != "") { tooManySearchParams(); }
                else if (urlBox.Text != "") { tooManySearchParams(); }
                else
                {
                    svcTypeNameSearch(svcTypeNameString);
                } //end final else 
            } //ends svcTypeBox while

        } 
        // NOW WE CATCH CONDITION WHERE NO SEARCH CRITERIA IS ENTERED
        else if (usernameBox.Text == ""
                && urlBox.Text == ""
                && passwordBox.Text == ""
                && hostBox.Text == ""
                && serviceBox.Text == ""
                && svcTypeBox.Text == "")
            {
                missingParameters();
            }

        // At this point all conditions have been evaulted
        } // ends searchButton_Click

        private void button1_Click_1(object sender, EventArgs e)
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
            hostBox.Text = "";
            serviceBox.Text = "";
            urlBox.Text = "";
            svcTypeBox.Text = "";


        }

        public void tooManySearchParams()
        {
            MessageBox.Show("Error (2): Only one search parameter is allowed!");
            usernameBox.Text = "";
            passwordBox.Text = "";
            hostBox.Text = "";
            serviceBox.Text = "";
            urlBox.Text = "";
            svcTypeBox.Text = "";
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Add_New_Item g = new Add_New_Item();
            g.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            NotImplemented();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            NotImplemented();
        }

        private void NotImplemented()
        {
            MessageBox.Show("Not yet implemented!");
        }

        public void usernameSearch(string userNameString)
        {
            string searchType = "UserName"; 
            string searchString = userNameString;
            Search g = new Search(searchString, searchType);
            g.Show();
            usernameBox.Text = "";
        }

        public void passwordSearch(string passwordString)
        {
            string searchType = "Password";
            string searchString = passwordString;
            Search g = new Search(searchString, searchType);
            g.Show();
            passwordBox.Text = "";
        }

        public void hostSearch(string hostString)
        {
            string searchType = "HostName";
            string searchString = hostString;
            Search g = new Search(searchString, searchType);
            g.Show();
            hostBox.Text = "";
        }

        public void serviceSearch(string serviceString)
        {
            string searchType = "ServiceName";
            string searchString = serviceString;
            Search g = new Search(searchString, searchType);
            g.Show();
            serviceBox.Text = "";
        }

        public void urlSearch(string urlString)
        {
            string searchType = "URL";
            string searchString = urlString;
            Search g = new Search(searchString, searchType);
            g.Show();
            urlBox.Text = "";
        }
        public void svcTypeNameSearch(string svcTypeString)
        {
            string searchType = "SvcTypeName";
            string searchString = svcTypeNameString;
            Search g = new Search(searchString, searchType);
            g.Show();
            svcTypeBox.Text = "";
        }
        public void missingParameters()
        {
            MessageBox.Show("Error (3): Must have at least one search parameter!");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ViewAll v = new ViewAll();
            v.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void svcTypeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
