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
    public partial class users : Form
    {
        Function Con;
        public users()
        {
            InitializeComponent();
            Con = new Function();
            ShowAllUsers();
        }
        private void ShowAllUsers()
        {
            string Query = "select * from UserTbl";
            UserList.DataSource = Con.GetData(Query);
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernamecb.Text == "" || Passwordbox.Text == "" || emailbox.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string username = usernamecb.Text;
                    string password = Passwordbox.Text;
                    string Email = emailbox.Text;

                    string Query = "INSERT INTO UserTbl VALUES('{0}','{1}','{2}')";
                    Query = string.Format(Query, username, password, Email);
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

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void UserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usernamecb.Text = UserList.SelectedRows[0].Cells[1].Value.ToString();
            Emailcb.Text = UserList.SelectedRows[0].Cells[2].Value.ToString();
            Passwordbox.Text = UserList.SelectedRows[0].Cells[3].Value.ToString();

            if (usernamecb.Text == "" || Emailcb.Text == "" || Passwordbox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Query = "Delete from UserTbl where user_id = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowAllUsers();
                    MessageBox.Show("User is Delete sucessfully !!");
                    usernamecb.Text = "";
                    Passwordbox.Text = "";
                    emailbox.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
