using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class appoiment : Form
    {
        Function Con;
        public appoiment()
        {
            InitializeComponent();
            Con = new Function();
            GetDoctors();
            GetStaffMember();
        }

        private void GetDoctors()
        {
           try
            {
                string Query = "SELECT * FROM DoctorTbl";
                DataTable dt = Con.GetData(Query);
                Doctorshowcb.DataSource = dt;
                Doctorshowcb.DisplayMember = Con.GetData(Query).Columns["First_Name"].ToString();
                Doctorshowcb.ValueMember = Con.GetData(Query).Columns["Doctor_ID"].ToString();
                Doctorshowcb.DataSource = Con.GetData(Query);

                // Enable AutoComplete
                Doctorshowcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Doctorshowcb.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching Doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetStaffMember()
        {
            try
            {
                string query = "SELECT * FROM StaffTbl";
                DataTable dt = Con.GetData(query);
                dt.Columns.Add("MemberFullName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["MemberFullName"] = row["First_Name"].ToString() + " " + row["Last_Name"].ToString();
                }

                Cmembershowcb.DataSource = dt;
                Cmembershowcb.DisplayMember = "MemberFullName";
                Cmembershowcb.ValueMember = "Staff_ID";


                // Enable AutoComplete
                Cmembershowcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Cmembershowcb.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching Member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string Date = datecb.Value.Date.ToString();
                    string Gender = Gendercb.SelectedItem?.ToString();
                    int Member_Of_Counter = Convert.ToInt32(Cmembershowcb.SelectedValue.ToString());
                    int Doctor_ID = Convert.ToInt32(Doctorshowcb.SelectedValue.ToString());
                    string Contact_Number = Contactcb.Text;
                    string Status = statuscb.Text;

                    string Query = "insert into AppoimentTbl values('{0}','{1}','{2}','{3}',{4},'{5}','{6}',{7})";
                    Query = string.Format(Query, First_Name, Last_Name, Date, Gender, Doctor_ID, Status, Contact_Number, Member_Of_Counter);
                    Con.SetData(Query);
                    MessageBox.Show("Appoiment create sucessfully !!");
                    Firstnamecb.Text = "";
                    Lastnamecb.Text = "";
                    datecb.Text = "";
                    statuscb.Text = "";
                    Contactcb.Text = "";
                    Doctorshowcb.SelectedValue = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }
    }
}
