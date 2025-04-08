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
    public partial class Sview : Form
    {
        public Sview()
        {
            InitializeComponent();
        }

        private void Adddoctor_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            obj.Show();
            this.Hide();
        }

        private void searchDoctor_Click(object sender, EventArgs e)
        {
            SearchStaff obj = new SearchStaff();
            obj.Show();
            this.Hide();
        }
    }
}
