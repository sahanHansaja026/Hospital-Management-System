using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class searchappoiments : Form
    {
        Function Con;

        public searchappoiments()
        {
            InitializeComponent();
            Con = new Function();
            SearchAppoiment();
        }

        private void SearchAppoiment()
        {
            try
            {
                string Query = @"
                    SELECT 
                        A.Appoiment_ID,
                        A.Member_Of_Counter,
                        A.Doctor_ID,
                        A.First_Name, A.Last_Name,
                        (A.First_Name + ' ' + A.Last_Name) AS PatientFullName,
                        (D.First_Name + ' ' + D.Last_Name) AS DoctorFullName,
                        (E.First_Name + ' ' + E.Last_Name) AS StaffMemberFullName
                    FROM 
                        AppoimentTbl A
                    INNER JOIN 
                        DoctorTbl D ON A.Doctor_ID = D.Doctor_ID
                    LEFT JOIN
                        StaffTbl E ON A.Member_Of_Counter = E.Staff_ID";

                DataTable dt = Con.GetData(Query);
                ReportSearchCb.DataSource = dt;
                ReportSearchCb.DisplayMember = "PatientFullName"; // You can change this to "DoctorFullName" if you want
                ReportSearchCb.ValueMember = "Appoiment_ID";

                ReportSearchCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ReportSearchCb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            aview obj = new aview();
            obj.Show();
            this.Hide();
        }

        // Helper method to get the full name of the doctor
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

        // Helper method to get the full name of the staff member
        private string GetMemberName(string Staff_ID)
        {
            string Query = $"SELECT First_Name, Last_Name FROM StaffTbl WHERE Staff_ID = '{Staff_ID}'";
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
            }
            else
            {
                return "Agent not found";
            }
        }

        // Helper method to get the appropriate title for the patient
        private string GetPatientTitle(string gender)
        {
            string title = string.Empty;

            if (gender.ToLower() == "male")
            {
                title = "Mr.";
            }
            else if (gender.ToLower() == "female")
            {
                title = "Ms."; // You can change this to "Miss" or "Mrs." based on preference
            }

            return title;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string Appoiment_ID = ReportSearchCb.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(Appoiment_ID))
            {
                MessageBox.Show("Please select a valid appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Query = $"SELECT * FROM AppoimentTbl WHERE Appoiment_ID = '{Appoiment_ID}'";
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string patientName = row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
                string status = row["Status"].ToString();
                string gender = row["Gender"].ToString();
                string doctorId = row["Doctor_ID"].ToString();
                string date = row["Date"].ToString();
                string agent = row["Member_Of_Counter"].ToString();
                string contact = row["Contact_Number"].ToString();


                // Get the doctor's full name using the helper method
                string doctorName = GetDoctorName(doctorId);
                string agentName = GetMemberName(agent);

                // Get the patient's title based on gender
                string patientTitle = GetPatientTitle(gender);

                // Set values to the UI elements
                Anumbercb.Text = Appoiment_ID;
                agentcb.Text = agentName;
                Gendercb.Text = gender;
                DNamecb.Text = doctorName;
                Datecb.Text = date;
                statuscb.Text = status;
                Contactcb.Text = contact;

                // Set the full name with title (prefix) based on gender
                FullNamecb.Text = $"{patientTitle} {patientName}";
            }
            else
            {
                MessageBox.Show("No appointment found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FullNamecb.Text = "No appointment found!";
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Appoiment_ID = ReportSearchCb.SelectedValue.ToString();
                string Query = $"Delete from AppoimentTbl WHERE Appoiment_ID = '{Appoiment_ID}'";
                DataTable dt = Con.GetData(Query);
                MessageBox.Show("Doctor delete sucess");
                // Set values to the UI elements
                Anumbercb.Text = "";
                agentcb.Text = "";
                Gendercb.Text = "";
                DNamecb.Text = "";
                Datecb.Text = "";
                statuscb.Text = "";
                Contactcb.Text = "";

                // Set the full name with title (prefix) based on gender
                FullNamecb.Text = $"";

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
