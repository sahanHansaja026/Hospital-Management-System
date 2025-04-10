using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class searchreport : Form
    {
        Function Con;

        public searchreport()
        {
            InitializeComponent();
            Con = new Function();
            SearchReport();
        }

        private void SearchReport()
        {
            try
            {
                string Query = @"
                    SELECT 
                        A.ReportId,
                        A.Patient_Id,
                        A.Doctor_ID,
                        A.date_of_issu,
                        A.Diagnosis,
                        A.Prescription,
                        (E.First_Name + ' ' + E.Last_Name) AS PatientFullName,
                        E.Blood AS PBlood,
                        (D.First_Name + ' ' + D.Last_Name) AS DoctorFullName
                    FROM 
                        ReportsTbl A
                    INNER JOIN 
                        DoctorTbl D ON A.Doctor_ID = D.Doctor_ID
                    LEFT JOIN
                        PatientsTbl E ON A.Patient_Id = E.Patient_Id";

                DataTable dt = Con.GetData(Query);
                ReportSearchCb.DataSource = dt;
                ReportSearchCb.DisplayMember = "PatientFullName"; // or use DoctorFullName
                ReportSearchCb.ValueMember = "ReportId";

                ReportSearchCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ReportSearchCb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDoctorName(string Doctor_ID)
        {
            string Query = $"SELECT First_Name, Last_Name FROM DoctorTbl WHERE Doctor_ID = '{Doctor_ID}'";
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
            }
            else
            {
                return "Doctor not found";
            }
        }

        private string GetPatientName(string Patient_Id)
        {
            string Query = $"SELECT First_Name, Last_Name FROM PatientsTbl WHERE Patient_Id = '{Patient_Id}'";
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
            }
            else
            {
                return "Patient not found";
            }
        }

        private string GetPatientTitle(string gender)
        {
            if (string.IsNullOrEmpty(gender)) return "";
            return gender.ToLower() == "male" ? "Mr." : "Ms.";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string ReportId = ReportSearchCb.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(ReportId))
            {
                MessageBox.Show("Please select a valid report.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Query = $"SELECT * FROM ReportsTbl WHERE ReportId = '{ReportId}'";
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string Diagnosis = row["Diagnosis"].ToString();
                string Prescription = row["Prescription"].ToString();
                string Doctor_ID = row["Doctor_ID"].ToString();
                string Patient_Id = row["Patient_Id"].ToString();
                string date_of_issu = row["date_of_issu"].ToString();

                // Fetch more details about the patient
                string PatientQuery = $"SELECT * FROM PatientsTbl WHERE Patient_Id = '{Patient_Id}'";
                DataTable pdt = Con.GetData(PatientQuery);
                string gender = "", contact = "", blood = "", dob = "", patientName = "";

                if (pdt.Rows.Count > 0)
                {
                    DataRow prow = pdt.Rows[0];
                    gender = prow["Gender"].ToString();
                    contact = prow["Contact_Number"].ToString();
                    blood = prow["Blood"].ToString();
                    dob = prow["DOB"].ToString();
                    patientName = prow["First_Name"] + " " + prow["Last_Name"];
                }

                string doctorName = GetDoctorName(Doctor_ID);
                string patientTitle = GetPatientTitle(gender);

                // Set values to the UI elements
                Bloodcb.Text = blood;
                datecb.Text = date_of_issu;
                Gendercb.Text = gender;
                DNamecb.Text = doctorName;
                Prescriptioncb.Text = Prescription;
                diagnosiscb.Text = Diagnosis;
                Contactcb.Text = contact;
                DOBcb.Text = dob;
                Pnamecbcb.Text = $"{patientTitle} {patientName}";
            }
            else
            {
                MessageBox.Show("No report found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pnamecbcb.Text = "No report found!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Report obj = new Report();
            obj.Show();
            this.Hide();
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ReportId = ReportSearchCb.SelectedValue.ToString();
                string Query = $"Delete from ReportsTbl WHERE ReportId = '{ReportId}'";
                DataTable dt = Con.GetData(Query);
                MessageBox.Show("Doctor delete sucess");
                // Set values to the UI elements
                Bloodcb.Text = "";
                datecb.Text = "";
                Gendercb.Text = "";
                DNamecb.Text = "";
                Prescriptioncb.Text = "";
                diagnosiscb.Text = "";
                Contactcb.Text = "";
                DOBcb.Text = "";
                Pnamecbcb.Text = " ";

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
