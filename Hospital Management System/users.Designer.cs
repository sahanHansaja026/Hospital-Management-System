namespace Hospital_Management_System
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            UserList = new Guna.UI2.WinForms.Guna2DataGridView();
            label4 = new Label();
            label3 = new Label();
            ContralPanel = new Label();
            panel2 = new Panel();
            button2 = new Button();
            submitbtn = new Button();
            updatebtn = new Button();
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            removebtn = new Button();
            Back = new Label();
            label1 = new Label();
            usernamecb = new TextBox();
            label5 = new Label();
            Passwordbox = new TextBox();
            Emailcb = new Label();
            emailbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserList).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // UserList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            UserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserList.ColumnHeadersHeight = 4;
            UserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserList.DefaultCellStyle = dataGridViewCellStyle3;
            UserList.GridColor = Color.Blue;
            UserList.Location = new Point(800, 181);
            UserList.Name = "UserList";
            UserList.RowHeadersVisible = false;
            UserList.RowHeadersWidth = 51;
            UserList.Size = new Size(996, 725);
            UserList.TabIndex = 160;
            UserList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UserList.ThemeStyle.AlternatingRowsStyle.Font = null;
            UserList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UserList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UserList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UserList.ThemeStyle.BackColor = Color.White;
            UserList.ThemeStyle.GridColor = Color.Blue;
            UserList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UserList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UserList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            UserList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UserList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UserList.ThemeStyle.HeaderStyle.Height = 4;
            UserList.ThemeStyle.ReadOnly = false;
            UserList.ThemeStyle.RowsStyle.BackColor = Color.White;
            UserList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            UserList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UserList.ThemeStyle.RowsStyle.Height = 29;
            UserList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UserList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UserList.CellContentClick += UserList_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(630, 67);
            label4.Name = "label4";
            label4.Size = new Size(849, 70);
            label4.TabIndex = 157;
            label4.Text = "User Enrolle For The System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(212, 25);
            label3.Name = "label3";
            label3.Size = new Size(64, 27);
            label3.TabIndex = 156;
            label3.Text = "User";
            // 
            // ContralPanel
            // 
            ContralPanel.AutoSize = true;
            ContralPanel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContralPanel.ForeColor = Color.Blue;
            ContralPanel.Location = new Point(-3, 25);
            ContralPanel.Name = "ContralPanel";
            ContralPanel.Size = new Size(178, 27);
            ContralPanel.TabIndex = 154;
            ContralPanel.Text = "Controal Panel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1016);
            panel2.Name = "panel2";
            panel2.Size = new Size(1796, 39);
            panel2.TabIndex = 153;
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
            submitbtn.Location = new Point(26, 576);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(241, 63);
            submitbtn.TabIndex = 150;
            submitbtn.Text = "S U B M I T";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.White;
            updatebtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = Color.Blue;
            updatebtn.Location = new Point(485, 576);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(241, 63);
            updatebtn.TabIndex = 151;
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
            panel1.TabIndex = 152;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.FromArgb(192, 0, 0);
            removebtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removebtn.ForeColor = Color.White;
            removebtn.Location = new Point(254, 678);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(241, 63);
            removebtn.TabIndex = 163;
            removebtn.Text = "R E M O V E";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(181, 25);
            Back.Name = "Back";
            Back.Size = new Size(25, 27);
            Back.TabIndex = 155;
            Back.Text = ">";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 331);
            label1.Name = "label1";
            label1.Size = new Size(181, 42);
            label1.TabIndex = 169;
            label1.Text = "username";
            // 
            // usernamecb
            // 
            usernamecb.BackColor = Color.Silver;
            usernamecb.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamecb.Location = new Point(26, 376);
            usernamecb.Name = "usernamecb";
            usernamecb.PlaceholderText = "Admin";
            usernamecb.Size = new Size(482, 50);
            usernamecb.TabIndex = 168;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 451);
            label5.Name = "label5";
            label5.Size = new Size(180, 42);
            label5.TabIndex = 167;
            label5.Text = "Password";
            // 
            // Passwordbox
            // 
            Passwordbox.BackColor = Color.Silver;
            Passwordbox.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordbox.Location = new Point(26, 504);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PlaceholderText = "123";
            Passwordbox.Size = new Size(482, 50);
            Passwordbox.TabIndex = 166;
            // 
            // Emailcb
            // 
            Emailcb.AutoSize = true;
            Emailcb.BackColor = Color.Transparent;
            Emailcb.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emailcb.Location = new Point(26, 204);
            Emailcb.Name = "Emailcb";
            Emailcb.Size = new Size(118, 42);
            Emailcb.TabIndex = 165;
            Emailcb.Text = "Email ";
            // 
            // emailbox
            // 
            emailbox.BackColor = Color.Silver;
            emailbox.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.Location = new Point(26, 257);
            emailbox.Name = "emailbox";
            emailbox.PlaceholderText = "Admin@mail.com";
            emailbox.Size = new Size(482, 50);
            emailbox.TabIndex = 164;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 1055);
            Controls.Add(label1);
            Controls.Add(usernamecb);
            Controls.Add(label5);
            Controls.Add(Passwordbox);
            Controls.Add(Emailcb);
            Controls.Add(emailbox);
            Controls.Add(UserList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ContralPanel);
            Controls.Add(panel2);
            Controls.Add(submitbtn);
            Controls.Add(updatebtn);
            Controls.Add(panel1);
            Controls.Add(removebtn);
            Controls.Add(Back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "users";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)UserList).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView UserList;
        private Label label4;
        private Label label3;
        private Label ContralPanel;
        private Panel panel2;
        private Button button2;
        private Button submitbtn;
        private Button updatebtn;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button removebtn;
        private Label Back;
        private Label label1;
        private TextBox usernamecb;
        private Label label5;
        private TextBox Passwordbox;
        private Label Emailcb;
        private TextBox emailbox;
    }
}