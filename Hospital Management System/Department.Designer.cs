namespace Hospital_Management_System
{
    partial class Department
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            departmentList = new Guna.UI2.WinForms.Guna2DataGridView();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ContralPanel = new Label();
            panel2 = new Panel();
            button2 = new Button();
            submitbtn = new Button();
            updatebtn = new Button();
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Back = new Label();
            DNameCb = new TextBox();
            Dheadcb = new TextBox();
            removebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)departmentList).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // departmentList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            departmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            departmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            departmentList.ColumnHeadersHeight = 4;
            departmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            departmentList.DefaultCellStyle = dataGridViewCellStyle3;
            departmentList.GridColor = Color.Blue;
            departmentList.Location = new Point(803, 175);
            departmentList.Name = "departmentList";
            departmentList.RowHeadersVisible = false;
            departmentList.RowHeadersWidth = 51;
            departmentList.Size = new Size(996, 725);
            departmentList.TabIndex = 140;
            departmentList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            departmentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            departmentList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            departmentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            departmentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            departmentList.ThemeStyle.BackColor = Color.White;
            departmentList.ThemeStyle.GridColor = Color.Blue;
            departmentList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            departmentList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            departmentList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            departmentList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            departmentList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            departmentList.ThemeStyle.HeaderStyle.Height = 4;
            departmentList.ThemeStyle.ReadOnly = false;
            departmentList.ThemeStyle.RowsStyle.BackColor = Color.White;
            departmentList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            departmentList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            departmentList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            departmentList.ThemeStyle.RowsStyle.Height = 29;
            departmentList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            departmentList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            departmentList.CellContentClick += departmentList_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(9, 324);
            label10.Name = "label10";
            label10.Size = new Size(479, 44);
            label10.TabIndex = 139;
            label10.Text = "Head Of The Department :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(9, 175);
            label5.Name = "label5";
            label5.Size = new Size(361, 44);
            label5.TabIndex = 137;
            label5.Text = "Department Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(630, 67);
            label4.Name = "label4";
            label4.Size = new Size(800, 70);
            label4.TabIndex = 136;
            label4.Text = "Hospital Department Setup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(212, 25);
            label3.Name = "label3";
            label3.Size = new Size(141, 27);
            label3.TabIndex = 135;
            label3.Text = "Department";
            // 
            // ContralPanel
            // 
            ContralPanel.AutoSize = true;
            ContralPanel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContralPanel.ForeColor = Color.Blue;
            ContralPanel.Location = new Point(-3, 25);
            ContralPanel.Name = "ContralPanel";
            ContralPanel.Size = new Size(178, 27);
            ContralPanel.TabIndex = 133;
            ContralPanel.Text = "Controal Panel";
            ContralPanel.Click += ContralPanel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1016);
            panel2.Name = "panel2";
            panel2.Size = new Size(1796, 39);
            panel2.TabIndex = 132;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(261, 59);
            button2.Name = "button2";
            button2.Size = new Size(241, 63);
            button2.TabIndex = 124;
            button2.Text = "D E L E T E";
            button2.UseVisualStyleBackColor = false;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Blue;
            submitbtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(19, 547);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(241, 63);
            submitbtn.TabIndex = 122;
            submitbtn.Text = "S U B M I T";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.White;
            updatebtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = Color.Blue;
            updatebtn.Location = new Point(478, 547);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(241, 63);
            updatebtn.TabIndex = 123;
            updatebtn.Text = "U P D A T E";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1796, 13);
            panel1.TabIndex = 131;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(181, 25);
            Back.Name = "Back";
            Back.Size = new Size(25, 27);
            Back.TabIndex = 134;
            Back.Text = ">";
            // 
            // DNameCb
            // 
            DNameCb.BackColor = Color.Silver;
            DNameCb.BorderStyle = BorderStyle.FixedSingle;
            DNameCb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DNameCb.Location = new Point(19, 222);
            DNameCb.Name = "DNameCb";
            DNameCb.PlaceholderText = "Department Name";
            DNameCb.Size = new Size(721, 50);
            DNameCb.TabIndex = 146;
            // 
            // Dheadcb
            // 
            Dheadcb.BackColor = Color.Silver;
            Dheadcb.BorderStyle = BorderStyle.FixedSingle;
            Dheadcb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dheadcb.Location = new Point(19, 387);
            Dheadcb.Name = "Dheadcb";
            Dheadcb.PlaceholderText = "Department head Name";
            Dheadcb.Size = new Size(721, 50);
            Dheadcb.TabIndex = 147;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.FromArgb(192, 0, 0);
            removebtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removebtn.ForeColor = Color.White;
            removebtn.Location = new Point(247, 649);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(241, 63);
            removebtn.TabIndex = 149;
            removebtn.Text = "R E M O V E";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 1055);
            Controls.Add(removebtn);
            Controls.Add(Dheadcb);
            Controls.Add(DNameCb);
            Controls.Add(submitbtn);
            Controls.Add(updatebtn);
            Controls.Add(departmentList);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ContralPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Department";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)departmentList).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView departmentList;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label ContralPanel;
        private Panel panel2;
        private Button button2;
        private Button submitbtn;
        private Button updatebtn;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label Back;
        private TextBox DNameCb;
        private TextBox Dheadcb;
        private Button removebtn;
    }
}