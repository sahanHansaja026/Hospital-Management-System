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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }


        private void loginbtn_Click(object sender, EventArgs e)
        {
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
            }
        }
    }
}
