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
    public partial class control_panel : Form
    {
        public control_panel()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void patients_Click(object sender, EventArgs e)
        {
            Pview obj = new Pview();
            obj.Show();
            this.Hide();
        }

        private void doctors_Click(object sender, EventArgs e)
        {
            DView obj = new DView();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Pview obj = new Pview();
            obj.Show();
            this.Hide();
        }

        private void Doctorslbl_Click(object sender, EventArgs e)
        {
            DView obj = new DView();
            obj.Show();
            this.Hide();
        }

        private void department_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Hide();
        }

        private void Departmentlbl_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Hide();
        }

        private void report_Click(object sender, EventArgs e)
        {
            Rview obj = new Rview();
            obj.Show();
            this.Hide();
        }

        private void reportslbl_Click(object sender, EventArgs e)
        {
            Rview obj = new Rview();
            obj.Show();
            this.Hide();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            Sview obj = new Sview();
            obj.Show();
            this.Hide();
        }

        private void appointments_Click(object sender, EventArgs e)
        {
            aview obj = new aview();
            obj.Show();
            this.Hide();
        }

        private void appointmentslbl_Click(object sender, EventArgs e)
        {
            aview obj = new aview();
            obj.Show();
            this.Hide();
        }

        private void stafflbl_Click(object sender, EventArgs e)
        {
            Sview obj = new Sview();
            obj.Show();
            this.Hide();
        }
    }
}
