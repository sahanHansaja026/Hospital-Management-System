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
    public partial class Pview : Form
    {
        public Pview()
        {
            InitializeComponent();
        }

        private void Adddoctor_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void searchDoctor_Click(object sender, EventArgs e)
        {
            searchpatients obj = new searchpatients();
            obj.Show();
            this.Hide();
        }
    }
}
