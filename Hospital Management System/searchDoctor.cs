using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public partial class searchDoctor : Form
    {
        Function Con;
        public searchDoctor()
        {
            InitializeComponent();
            Con = new Function();
            SearchDoctorName();
        }
        private void SearchDoctorName()
        {
            try
            {
                string Query = "SELECT Doctor_ID, (First_Name + ' ' + Last_Name) AS FullName FROM DoctorTbl";
                DataTable dt = Con.GetData(Query);
                DoctorsearchCb.DataSource = dt;
                DoctorsearchCb.DisplayMember = "FullName";
                DoctorsearchCb.ValueMember = Con.GetData(Query).Columns["Doctor_ID"].ToString();
                DoctorsearchCb.DataSource = Con.GetData(Query);

                // Enable AutoComplete
                DoctorsearchCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                DoctorsearchCb.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            string Doctor_ID = DoctorsearchCb.SelectedValue.ToString();
            string Query = $"SELECT * FROM DoctorTbl WHERE Doctor_ID = '{Doctor_ID}'";
            DataTable dt = Con.GetData(Query);


            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Get first doctor

                string doctorName = row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
                string Specialization = row["Specialization"].ToString();
                string Recodes = row["Recodes"].ToString();
                string Gender = row["Gender"].ToString();
                string Department = row["Department"].ToString();
                string DOB = row["DOB"].ToString();
                string Email = row["Email"].ToString();
                string Contact = row["Contact_Number"].ToString();

                specialcb.Text = $"{Specialization}";
                recodecb.Text = $"{Recodes}";
                Gendercb.Text = $"{Gender}";
                Departmentcb.Text = $"{Department}";
                DOBcb.Text = $"{DOB}";
                Emailcb.Text = $"{Email}";
                Contactcb.Text = $"{Contact}";
                Dnamecb.Text = $"Dr. {doctorName}"; // Show in label
            }
            else
            {
                Dnamecb.Text = "No doctor found!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DView obj = new DView();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Doctor_ID = DoctorsearchCb.SelectedValue.ToString();
                string Query = $"Delete from DoctorTbl WHERE Doctor_ID = '{Doctor_ID}'";
                DataTable dt = Con.GetData(Query);
                MessageBox.Show("Doctor delete sucess");
                specialcb.Text = "";
                recodecb.Text = "";
                Gendercb.Text = "";
                Departmentcb.Text = "";
                DOBcb.Text = "";
                Emailcb.Text = "";
                Contactcb.Text = "";
                Dnamecb.Text = $"Dr."; // Show in label

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
