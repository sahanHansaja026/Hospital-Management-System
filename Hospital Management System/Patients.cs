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
    public partial class Patients : Form
    {
        Function Con;
        public Patients()
        {
            InitializeComponent();
            Con = new Function();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Firstnamecb.Text == "" || Lastnamecb.Text=="")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string First_Name = Firstnamecb.Text;
                    string Last_Name = Lastnamecb.Text;                    
                    string DOB = DOBCb.Value.Date.ToString();
                    string Gender = Gendercb.SelectedItem.ToString();
                    string Contact_Number = Contactcb.Text;
                    string Blood = bloodcb.SelectedItem.ToString();
                    string Address = Addresscb.Text;
                    string Insurance_id = Insurancecb.Text;

                    string Query = "insert into PatientsTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                    Query = string.Format(Query, First_Name, Last_Name, DOB, Gender, Contact_Number, Blood, Address, Insurance_id);
                    Con.SetData(Query);
                    MessageBox.Show("Patient was adding sucessfully !!");
                    Firstnamecb.Text = "";
                    Lastnamecb.Text = "";
                    Contactcb.Text="";
                    Addresscb.Text="";
                    Insurancecb.Text="";
                    Gendercb.SelectedItem = "";
                    bloodcb.SelectedItem = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
