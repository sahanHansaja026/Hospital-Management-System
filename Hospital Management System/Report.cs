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
    public partial class Report : Form
    {
        Function Con;
        public Report()
        {
            InitializeComponent();
            Con = new Function();
            GetPatients();
            GetDoctors();
        }

        private void GetPatients()
        {
            string Query = "SELECT Patient_Id, (First_Name + ' ' + Last_Name) AS FullName FROM PatientsTbl";
            DataTable dt = Con.GetData(Query); // Fetch data from DB
            PatientNamecb.DataSource = dt;
            PatientNamecb.DisplayMember = "FullName";
            PatientNamecb.ValueMember = Con.GetData(Query).Columns["Patient_Id"].ToString();
            PatientNamecb.DataSource = Con.GetData(Query);

            // Enable AutoComplete
            PatientNamecb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PatientNamecb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GetDoctors()
        {
            string Query = "SELECT Doctor_ID, (First_Name + ' ' + Last_Name) AS FullName FROM DoctorTbl";
            DataTable dt = Con.GetData(Query); // Fetch data from DB
            DoctorNamecb.DataSource = dt;
            DoctorNamecb.DisplayMember = "FullName";
            DoctorNamecb.ValueMember = Con.GetData(Query).Columns["Doctor_ID"].ToString();
            DoctorNamecb.DataSource = Con.GetData(Query);

            // Enable AutoComplete
            DoctorNamecb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DoctorNamecb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (PatientNamecb.Text == "" || DoctorNamecb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Patient_Id = PatientNamecb.SelectedValue.ToString();
                    string Doctor_Id = DoctorNamecb.SelectedValue.ToString();
                    string date_of_issu = datecb.Value.Date.ToString();
                    string Diagnosis = Diagnosiscb.Text;
                    string Prescription = Prescriptioncb.Text;     

                    string Query = "insert into ReportsTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Patient_Id, Doctor_Id, date_of_issu, Diagnosis, Prescription);
                    Con.SetData(Query);
                    MessageBox.Show("Report was adding sucessfully !!");
                    PatientNamecb.Text = "";
                    DoctorNamecb.Text = "";
                    Diagnosiscb.Text = "";
                    Prescriptioncb.Text = "";       

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }
    }
}
