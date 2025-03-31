using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Management_System
{
    public partial class Doctors : Form
    {
        Function Con;

        public Doctors()
        {
            InitializeComponent();
            Con = new Function();
            GetDepartments();
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
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
                    string Records = recordscb.Text;
                    string Contact_Number = Contactcb.Text;
                    string Specialization = Specialzationcb.Text;
                    string Email = Emailcb.Text;

                    string Query = "insert into DoctorTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                    Query = string.Format(Query, First_Name, Last_Name, DOB, Gender, Department, Records, Contact_Number, Specialization, Email);
                    Con.SetData(Query);
                    MessageBox.Show("Doctor enrolle sucessfully !!");
                    Firstnamecb.Text = "";
                    Lastnamecb.Text = "";
                    DOBcb.Text = "";
                    recordscb.Text = "";
                    Contactcb.Text = "";
                    Specialzationcb.Text = "";
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
            DView obj = new DView();
            obj.Show();
            this.Hide();
        }
    }
}
