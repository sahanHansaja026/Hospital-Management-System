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

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        Function Con;
        public Login()
        {
            InitializeComponent();
            Con = new Function();

        }


        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailbox.Text == "" || Passwordbox.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string username = emailbox.Text;
                    string password = Passwordbox.Text;

                    string Query = "SELECT COUNT(*) FROM UserTbl WHERE username = @username AND password = @password";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                     new SqlParameter("@username",username),
                     new SqlParameter("password",password)
                    };
                    int count = (int)Con.Executescalar(Query, parameters);
                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        control_panel Obj = new control_panel();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("invalid username and password");
                        emailbox.Text = "";
                        Passwordbox.Text = "";
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                emailbox.Text = "";
                Passwordbox.Text = "";
            }


            /*
            if (Emailcb.Text == "" || Passwordbox.Text == "")
            {
                MessageBox.Show("Missing Data !!");
            }
            else if (emailbox.Text == "Admin" && Passwordbox.Text == "123")
            {
                control_panel Obj = new control_panel();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email and Password");
                Passwordbox.Text = " ";
                emailbox.Text = "";
            }*/
        }

        private void userinputpage_Click(object sender, EventArgs e)
        {
            userinput obj = new userinput();
            obj.Show();
            this.Hide();
        }
    }
}
