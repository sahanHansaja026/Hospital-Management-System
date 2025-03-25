using System;
using System.Data;
using System.Windows.Forms;

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

                if (dt != null && dt.Columns.Contains("Department_Name") && dt.Columns.Contains("Department_Id"))
                {
                    Departmentcb.DisplayMember = "Department_Name";
                    Departmentcb.ValueMember = "Department_Id";
                    Departmentcb.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No departments found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                // Get values from form, defaulting to "None" if empty
                string First_Name = string.IsNullOrWhiteSpace(Firstnamecb.Text) ? "None" : Firstnamecb.Text;
                string Last_Name = string.IsNullOrWhiteSpace(Lastnamecb.Text) ? "None" : Lastnamecb.Text;
                string DOB = DOBcb.Value.Date.ToString("yyyy-MM-dd");
                string Gender = Gendercb.SelectedItem?.ToString() ?? "None";
                int Department = Departmentcb.SelectedValue != null ? Convert.ToInt32(Departmentcb.SelectedValue) : 0;
                string Records = string.IsNullOrWhiteSpace(recordscb.Text) ? "None" : recordscb.Text;
                string Contact_Number = string.IsNullOrWhiteSpace(Contactcb.Text) ? "None" : Contactcb.Text;
                string Specialization = string.IsNullOrWhiteSpace(Specialzationcb.Text) ? "None" : Specialzationcb.Text;
                string Email = string.IsNullOrWhiteSpace(Emailcb.Text) ? "None" : Emailcb.Text;

                // SQL Insert Query with proper formatting
                string Query = string.Format("INSERT INTO DoctorTbl (First_Name, Last_Name, DOB, Gender, Department, Recodes, Contact_Number, Specialization, Email) " +
                                             "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}')",
                                             First_Name, Last_Name, DOB, Gender, Department, Records, Contact_Number, Specialization, Email);

                // Execute the query
                Con.SetData(Query);

                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
