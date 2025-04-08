using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class SearchStaff : Form
    {
        Function Con;
        public SearchStaff()
        {
            InitializeComponent();
            Con = new Function();
            SearchMemberName();
        }
        private void SearchMemberName()
        {
            try
            {
                string Query = "SELECT Staff_ID, (First_Name + ' ' + Last_Name) AS FullName FROM StaffTbl";
                DataTable dt = Con.GetData(Query);
                Staffsearchcb.DataSource = dt;
                Staffsearchcb.DisplayMember = "FullName";
                Staffsearchcb.ValueMember = Con.GetData(Query).Columns["Staff_ID"].ToString();
                Staffsearchcb.DataSource = Con.GetData(Query);

                // Enable AutoComplete
                Staffsearchcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Staffsearchcb.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string Staff_ID = Staffsearchcb.SelectedValue.ToString();
            string Query = $"SELECT * FROM StaffTbl WHERE Staff_ID = '{Staff_ID}'";
            DataTable dt = Con.GetData(Query);


            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Get first doctor

                string doctorName = row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
                string Address = row["Address"].ToString();
                string Role = row["Role"].ToString();
                string Gender = row["Gender"].ToString();
                string Department = row["Department"].ToString();
                string DOB = row["DOB"].ToString();
                string Email = row["Email"].ToString();
                string Contact = row["Contact_Number"].ToString();

                Addresscb.Text = $"{Address}";
                rolecb.Text = $"{Role}";
                Gendercb.Text = $"{Gender}";
                Departmentcb.Text = $"{Department}";
                DOBcb.Text = $"{DOB}";
                Emailcb.Text = $"{Email}";
                Contactcb.Text = $"{Contact}";
                Snamecb.Text = $"Dr. {doctorName}"; // Show in label
            }
            else
            {
                Snamecb.Text = "No Memeber found!";
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {

                string Staff_ID = Staffsearchcb.SelectedValue.ToString();
                string Query = $"Delete from StaffTbl WHERE Staff_ID = '{Staff_ID}'";
                DataTable dt = Con.GetData(Query);
                MessageBox.Show("Member delete sucess");
                Addresscb.Text = "";
                rolecb.Text = "";
                Gendercb.Text = "";
                Departmentcb.Text = "";
                DOBcb.Text = "";
                Emailcb.Text = "";
                Contactcb.Text = "";
                Snamecb.Text = ""; // Show in label

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void stafflbl_Click(object sender, EventArgs e)
        {
            Sview obj = new Sview();
            obj.Show();
            this.Hide();
        }

        private void searchstafflbl_Click(object sender, EventArgs e)
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
