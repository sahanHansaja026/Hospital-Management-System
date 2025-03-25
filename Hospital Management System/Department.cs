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
    public partial class Department : Form
    {
        Function Con;
        public Department()
        {
            InitializeComponent();
            Con = new Function();
            ShowDepartments();
        }

        private void ContralPanel_Click(object sender, EventArgs e)
        {
            control_panel obj = new control_panel();
            obj.Show();
            this.Hide();
        }
        private void ShowDepartments()
        {
            string Query = "select * from DepartmentTbl";
            departmentList.DataSource = Con.GetData(Query);
        }
        int key = 0;
        private void departmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameCb.Text = departmentList.SelectedRows[0].Cells[1].Value.ToString();
            Dheadcb.Text = departmentList.SelectedRows[0].Cells[2].Value.ToString();

            if (DNameCb.Text == "" || Dheadcb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(departmentList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DNameCb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Department_Name = DNameCb.Text;
                    string Department_Head = Dheadcb.Text;
                    string Query = "insert into DepartmentTbl values('{0}','{1}')";
                    Query = string.Format(Query, DNameCb.Text, Dheadcb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department was adding sucessfully !!");
                    DNameCb.Text = "";
                    Dheadcb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DNameCb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Department_Name = DNameCb.Text;
                    string Department_Head = Dheadcb.Text;
                    string Query = "update DepartmentTbl set Department_Name='{0}',Department_Head='{1}' where Department_Id = {2}";
                    Query = string.Format(Query, DNameCb.Text, Dheadcb.Text, key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department was Update sucessfully !!");
                    DNameCb.Text = "";
                    Dheadcb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Query = "Delete from DepartmentTbl where Department_Id = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department was Delete sucessfully !!");
                    DNameCb.Text = "";
                    Dheadcb.Text = "";
                }
            }
            catch  (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
