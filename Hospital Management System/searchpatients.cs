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
    public partial class searchpatients : Form
    {
        Function Con;
        public searchpatients()
        {
            InitializeComponent();
            Con = new Function();
            SearchPatients();
        }
        private void SearchPatients()
        {
            try
            {
                string Query = "SELECT Patient_Id, (First_Name + ' ' + Last_Name) AS FullName FROM PatientsTbl";
                DataTable dt = Con.GetData(Query);
                PatientsearchCb.DataSource = dt;
                PatientsearchCb.DisplayMember = "FullName";
                PatientsearchCb.ValueMember = Con.GetData(Query).Columns["Patient_Id"].ToString();
                PatientsearchCb.DataSource = Con.GetData(Query);

                // Enable AutoComplete
                PatientsearchCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                PatientsearchCb.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string Patient_Id = PatientsearchCb.SelectedValue.ToString();
            string Query = $"SELECT * FROM PatientsTbl WHERE Patient_Id = '{Patient_Id}'";
            DataTable dt = Con.GetData(Query);


            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Get first doctor

                string patientsname = row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
                string Gender = row["Gender"].ToString();
                string Blood = row["Blood"].ToString();
                string DOB = row["DOB"].ToString();
                string Insurance = row["Insurance_id"].ToString();
                string Contact = row["Contact_Number"].ToString();
                string Address = row["Address"].ToString();

                Gendercb.Text = $"{Gender}";
                Bloodcb.Text = $"{Blood}";
                DOBcb.Text = $"{DOB}";
                addresscb.Text = $"{Address}";
                Contactcb.Text = $"{Contact}";
                PnameCb.Text = $"{patientsname}";
                Insurance_idcb.Text = $"{Insurance}"; // Show in label
            }
            else
            {
                PnameCb.Text = "No Patient found!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Patient_Id = PatientsearchCb.SelectedValue.ToString();
                string Query = $"Delete from PatientsTbl WHERE Patient_Id = '{Patient_Id}'";
                DataTable dt = Con.GetData(Query);
                MessageBox.Show("Patient delete sucess");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
