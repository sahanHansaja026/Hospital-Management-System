namespace Hospital_Management_System
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            label12 = new Label();
            Specialzationcb = new TextBox();
            label11 = new Label();
            recordscb = new TextBox();
            label10 = new Label();
            Departmentcb = new ComboBox();
            label9 = new Label();
            Gendercb = new ComboBox();
            label8 = new Label();
            Contactcb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Firstnamecb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            Back = new Label();
            ContralPanel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Lastnamecb = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            submitbtn = new Button();
            label1 = new Label();
            Emailcb = new TextBox();
            DOBcb = new DateTimePicker();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(981, 568);
            label12.Name = "label12";
            label12.Size = new Size(290, 44);
            label12.TabIndex = 82;
            label12.Text = "Specialization :";
            // 
            // Specialzationcb
            // 
            Specialzationcb.BackColor = Color.Silver;
            Specialzationcb.BorderStyle = BorderStyle.FixedSingle;
            Specialzationcb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Specialzationcb.Location = new Point(991, 615);
            Specialzationcb.Name = "Specialzationcb";
            Specialzationcb.PlaceholderText = "Specialization";
            Specialzationcb.Size = new Size(721, 50);
            Specialzationcb.TabIndex = 81;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(16, 568);
            label11.Name = "label11";
            label11.Size = new Size(384, 44);
            label11.TabIndex = 80;
            label11.Text = "Additional Records :";
            // 
            // recordscb
            // 
            recordscb.BackColor = Color.Silver;
            recordscb.BorderStyle = BorderStyle.FixedSingle;
            recordscb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordscb.Location = new Point(26, 615);
            recordscb.Multiline = true;
            recordscb.Name = "recordscb";
            recordscb.PlaceholderText = "Additional Records";
            recordscb.Size = new Size(721, 179);
            recordscb.TabIndex = 79;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(980, 442);
            label10.Name = "label10";
            label10.Size = new Size(249, 44);
            label10.TabIndex = 78;
            label10.Text = "Department :";
            // 
            // Departmentcb
            // 
            Departmentcb.BackColor = Color.Silver;
            Departmentcb.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Departmentcb.FormattingEnabled = true;
            Departmentcb.Location = new Point(991, 489);
            Departmentcb.Name = "Departmentcb";
            Departmentcb.Size = new Size(280, 48);
            Departmentcb.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(980, 304);
            label9.Name = "label9";
            label9.Size = new Size(173, 44);
            label9.TabIndex = 76;
            label9.Text = "Gender :";
            // 
            // Gendercb
            // 
            Gendercb.BackColor = Color.Silver;
            Gendercb.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gendercb.FormattingEnabled = true;
            Gendercb.Items.AddRange(new object[] { "Male ", "Female", "Transgender Male", "Transgender Female", "Prefer Not to Say", "Other (Specify in Notes)" });
            Gendercb.Location = new Point(991, 351);
            Gendercb.Name = "Gendercb";
            Gendercb.Size = new Size(280, 48);
            Gendercb.TabIndex = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(16, 440);
            label8.Name = "label8";
            label8.Size = new Size(332, 44);
            label8.TabIndex = 74;
            label8.Text = "Contact Number :";
            // 
            // Contactcb
            // 
            Contactcb.BackColor = Color.Silver;
            Contactcb.BorderStyle = BorderStyle.FixedSingle;
            Contactcb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contactcb.Location = new Point(26, 487);
            Contactcb.Name = "Contactcb";
            Contactcb.PlaceholderText = "Contact Number";
            Contactcb.Size = new Size(721, 50);
            Contactcb.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 302);
            label7.Name = "label7";
            label7.Size = new Size(270, 44);
            label7.TabIndex = 71;
            label7.Text = "Date Of Birth :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(980, 175);
            label6.Name = "label6";
            label6.Size = new Size(231, 44);
            label6.TabIndex = 70;
            label6.Text = "Last Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 175);
            label5.Name = "label5";
            label5.Size = new Size(234, 44);
            label5.TabIndex = 68;
            label5.Text = "First Name :";
            // 
            // Firstnamecb
            // 
            Firstnamecb.BackColor = Color.Silver;
            Firstnamecb.BorderStyle = BorderStyle.FixedSingle;
            Firstnamecb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Firstnamecb.Location = new Point(26, 222);
            Firstnamecb.Name = "Firstnamecb";
            Firstnamecb.PlaceholderText = "First Name";
            Firstnamecb.Size = new Size(721, 50);
            Firstnamecb.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(577, 67);
            label4.Name = "label4";
            label4.Size = new Size(741, 70);
            label4.TabIndex = 66;
            label4.Text = "Doctor Enrollment Portal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(219, 25);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 65;
            label3.Text = "Doctors";
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(188, 25);
            Back.Name = "Back";
            Back.Size = new Size(25, 27);
            Back.TabIndex = 64;
            Back.Text = ">";
            // 
            // ContralPanel
            // 
            ContralPanel.AutoSize = true;
            ContralPanel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContralPanel.ForeColor = Color.Blue;
            ContralPanel.Location = new Point(4, 25);
            ContralPanel.Name = "ContralPanel";
            ContralPanel.Size = new Size(178, 27);
            ContralPanel.TabIndex = 63;
            ContralPanel.Text = "Controal Panel";
            ContralPanel.Click += ContralPanel_Click;
            // 
            // Lastnamecb
            // 
            Lastnamecb.BackColor = Color.Silver;
            Lastnamecb.BorderStyle = BorderStyle.FixedSingle;
            Lastnamecb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lastnamecb.Location = new Point(991, 222);
            Lastnamecb.Name = "Lastnamecb";
            Lastnamecb.PlaceholderText = "Last Name";
            Lastnamecb.Size = new Size(721, 50);
            Lastnamecb.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 995);
            panel2.Name = "panel2";
            panel2.Size = new Size(1712, 39);
            panel2.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1712, 13);
            panel1.TabIndex = 61;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Blue;
            submitbtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(26, 848);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(721, 63);
            submitbtn.TabIndex = 83;
            submitbtn.Text = "S U B M I T";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(981, 706);
            label1.Name = "label1";
            label1.Size = new Size(300, 44);
            label1.TabIndex = 85;
            label1.Text = "Email Address :";
            // 
            // Emailcb
            // 
            Emailcb.BackColor = Color.Silver;
            Emailcb.BorderStyle = BorderStyle.FixedSingle;
            Emailcb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emailcb.Location = new Point(991, 753);
            Emailcb.Name = "Emailcb";
            Emailcb.PlaceholderText = "Email Address";
            Emailcb.Size = new Size(721, 50);
            Emailcb.TabIndex = 84;
            // 
            // DOBcb
            // 
            DOBcb.Location = new Point(26, 382);
            DOBcb.Name = "DOBcb";
            DOBcb.Size = new Size(271, 27);
            DOBcb.TabIndex = 87;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1704, 1055);
            Controls.Add(DOBcb);
            Controls.Add(label1);
            Controls.Add(Emailcb);
            Controls.Add(submitbtn);
            Controls.Add(label12);
            Controls.Add(Specialzationcb);
            Controls.Add(label11);
            Controls.Add(recordscb);
            Controls.Add(label10);
            Controls.Add(Departmentcb);
            Controls.Add(label9);
            Controls.Add(Gendercb);
            Controls.Add(label8);
            Controls.Add(Contactcb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Firstnamecb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Back);
            Controls.Add(ContralPanel);
            Controls.Add(Lastnamecb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Doctors";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private TextBox Specialzationcb;
        private Label label11;
        private TextBox recordscb;
        private Label label10;
        private ComboBox Departmentcb;
        private Label label9;
        private ComboBox Gendercb;
        private Label label8;
        private TextBox Contactcb;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox Firstnamecb;
        private Label label4;
        private Label label3;
        private Label Back;
        private Label ContralPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox Lastnamecb;
        private Panel panel2;
        private Panel panel1;
        private Button submitbtn;
        private Label label1;
        private TextBox Emailcb;
        private DateTimePicker DOBcb;
    }
}