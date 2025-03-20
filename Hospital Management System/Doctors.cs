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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }
    }
}
