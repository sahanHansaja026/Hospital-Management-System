using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class userinput : Form
    {
        Function Con;
        public userinput()
        {
            InitializeComponent();
            Con = new Function();
        }

        private void userinputpage_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernamecb.Text == "" || Passwordbox.Text == "" || emailbox.Text=="")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string username = usernamecb.Text;
                    string password = Passwordbox.Text;
                    string Email = emailbox.Text;

                    string Query = "INSERT INTO UserTbl VALUES('{0}','{1}','{2}')";
                    Query = string.Format(Query, username, password,Email);
                    Con.SetData(Query);
                    MessageBox.Show("User add sucssful");
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                usernamecb.Text = "";
                Passwordbox.Text = "";
                emailbox.Text = "";
            }
        }
    }
}
