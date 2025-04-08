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
    public partial class Staff : Form
    {
        Function Con;
        public Staff()
        {
            InitializeComponent();
            Con = new Function();
            GetDepartments();
        }
        private void GetDepartments()
        {
            try
            {
                string Query = "SELECT * FROM DepartmentTbl";
                DataTable dt = Con.GetData(Query);
                Departmentcb.DataSource = dt;
                Departmentcb.DisplayMember = Con.GetData(Query).Columns["Department_Name"].ToString();
                Departmentcb.ValueMember = Con.GetData(Query).Columns["Department_Id"].ToString();
                Departmentcb.DataSource = Con.GetData(Query);

                // Enable AutoComplete
                Departmentcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Departmentcb.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Firstnamecb.Text == "" || Lastnamecb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string First_Name = Firstnamecb.Text;
                    string Last_Name = Lastnamecb.Text;
                    string DOB = DOBcb.Value.Date.ToString();
                    string Gender = Gendercb.SelectedItem?.ToString();
                    string Department = Departmentcb.SelectedValue.ToString();
                    string Role = Rolecb.Text;
                    string Contact_Number = Contactcb.Text;
                    string Address = addresscb.Text;
                    string Email = Emailcb.Text;

                    string Query = "insert into StaffTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                    Query = string.Format(Query, First_Name, Last_Name, DOB, Gender, Department, Role, Contact_Number, Address, Email);
                    Con.SetData(Query);
                    MessageBox.Show("Staff enrolle sucessfully !!");
                    Firstnamecb.Text = "";
                    Lastnamecb.Text = "";
                    DOBcb.Text = "";
                    Rolecb.Text = "";
                    Contactcb.Text = "";
                    addresscb.Text = "";
                    Emailcb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Sview obj = new Sview();
            obj.Show();
            this.Hide();
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }
    }
}
