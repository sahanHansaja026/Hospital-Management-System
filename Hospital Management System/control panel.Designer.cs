namespace Hospital_Management_System
{
    partial class control_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control_panel));
            panel1 = new Panel();
            patients = new Button();
            Patientslbl = new Label();
            Doctorslbl = new Label();
            doctors = new Button();
            department = new Button();
            Departmentlbl = new Label();
            reportslbl = new Label();
            report = new Button();
            stafflbl = new Label();
            staff = new Button();
            accountlbl = new Label();
            account = new Button();
            userlbl = new Label();
            users = new Button();
            appointments = new Button();
            appointmentslbl = new Label();
            panel2 = new Panel();
            LogOut = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1786, 13);
            panel1.TabIndex = 0;
            // 
            // patients
            // 
            patients.BackgroundImage = (Image)resources.GetObject("patients.BackgroundImage");
            patients.BackgroundImageLayout = ImageLayout.Zoom;
            patients.FlatAppearance.BorderColor = Color.Black;
            patients.FlatAppearance.BorderSize = 2;
            patients.FlatAppearance.MouseDownBackColor = Color.Black;
            patients.FlatAppearance.MouseOverBackColor = Color.Black;
            patients.Location = new Point(93, 100);
            patients.Name = "patients";
            patients.Size = new Size(347, 191);
            patients.TabIndex = 2;
            patients.UseVisualStyleBackColor = true;
            patients.Click += patients_Click;
            // 
            // Patientslbl
            // 
            Patientslbl.AutoSize = true;
            Patientslbl.BackColor = Color.Transparent;
            Patientslbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Patientslbl.Location = new Point(184, 294);
            Patientslbl.Name = "Patientslbl";
            Patientslbl.Size = new Size(137, 39);
            Patientslbl.TabIndex = 6;
            Patientslbl.Text = "Patients";
            Patientslbl.Click += label1_Click;
            // 
            // Doctorslbl
            // 
            Doctorslbl.AutoSize = true;
            Doctorslbl.BackColor = Color.Transparent;
            Doctorslbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Doctorslbl.Location = new Point(661, 294);
            Doctorslbl.Name = "Doctorslbl";
            Doctorslbl.Size = new Size(132, 39);
            Doctorslbl.TabIndex = 7;
            Doctorslbl.Text = "Doctors";
            Doctorslbl.Click += Doctorslbl_Click;
            // 
            // doctors
            // 
            doctors.BackgroundImage = (Image)resources.GetObject("doctors.BackgroundImage");
            doctors.BackgroundImageLayout = ImageLayout.Zoom;
            doctors.FlatAppearance.BorderColor = Color.Black;
            doctors.FlatAppearance.BorderSize = 2;
            doctors.Location = new Point(557, 100);
            doctors.Name = "doctors";
            doctors.Size = new Size(347, 191);
            doctors.TabIndex = 8;
            doctors.UseVisualStyleBackColor = true;
            doctors.Click += doctors_Click;
            // 
            // department
            // 
            department.BackgroundImage = (Image)resources.GetObject("department.BackgroundImage");
            department.BackgroundImageLayout = ImageLayout.Zoom;
            department.FlatAppearance.BorderColor = Color.Black;
            department.FlatAppearance.BorderSize = 2;
            department.Location = new Point(1011, 100);
            department.Name = "department";
            department.Size = new Size(347, 191);
            department.TabIndex = 9;
            department.UseVisualStyleBackColor = true;
            department.Click += department_Click;
            // 
            // Departmentlbl
            // 
            Departmentlbl.AutoSize = true;
            Departmentlbl.BackColor = Color.Transparent;
            Departmentlbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Departmentlbl.Location = new Point(1085, 294);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(206, 39);
            Departmentlbl.TabIndex = 10;
            Departmentlbl.Text = "Departments";
            Departmentlbl.Click += Departmentlbl_Click;
            // 
            // reportslbl
            // 
            reportslbl.AutoSize = true;
            reportslbl.BackColor = Color.Transparent;
            reportslbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportslbl.Location = new Point(1583, 294);
            reportslbl.Name = "reportslbl";
            reportslbl.Size = new Size(133, 39);
            reportslbl.TabIndex = 12;
            reportslbl.Text = "Reports";
            reportslbl.Click += reportslbl_Click;
            // 
            // report
            // 
            report.BackgroundImage = (Image)resources.GetObject("report.BackgroundImage");
            report.BackgroundImageLayout = ImageLayout.Zoom;
            report.FlatAppearance.BorderColor = Color.Black;
            report.FlatAppearance.BorderSize = 2;
            report.Location = new Point(1458, 100);
            report.Name = "report";
            report.Size = new Size(347, 191);
            report.TabIndex = 11;
            report.UseVisualStyleBackColor = true;
            report.Click += report_Click;
            // 
            // stafflbl
            // 
            stafflbl.AutoSize = true;
            stafflbl.BackColor = Color.Transparent;
            stafflbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stafflbl.Location = new Point(216, 693);
            stafflbl.Name = "stafflbl";
            stafflbl.Size = new Size(86, 39);
            stafflbl.TabIndex = 14;
            stafflbl.Text = "Staff";
            stafflbl.Click += stafflbl_Click;
            // 
            // staff
            // 
            staff.BackgroundImage = (Image)resources.GetObject("staff.BackgroundImage");
            staff.BackgroundImageLayout = ImageLayout.Zoom;
            staff.FlatAppearance.BorderColor = Color.Black;
            staff.FlatAppearance.BorderSize = 2;
            staff.FlatAppearance.MouseDownBackColor = Color.Black;
            staff.FlatAppearance.MouseOverBackColor = Color.Black;
            staff.Location = new Point(93, 499);
            staff.Name = "staff";
            staff.Size = new Size(347, 191);
            staff.TabIndex = 13;
            staff.UseVisualStyleBackColor = true;
            staff.Click += staff_Click;
            // 
            // accountlbl
            // 
            accountlbl.AutoSize = true;
            accountlbl.BackColor = Color.Transparent;
            accountlbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountlbl.Location = new Point(1583, 693);
            accountlbl.Name = "accountlbl";
            accountlbl.Size = new Size(139, 39);
            accountlbl.TabIndex = 20;
            accountlbl.Text = "Account";
            // 
            // account
            // 
            account.BackgroundImage = (Image)resources.GetObject("account.BackgroundImage");
            account.BackgroundImageLayout = ImageLayout.Zoom;
            account.FlatAppearance.BorderColor = Color.Black;
            account.FlatAppearance.BorderSize = 2;
            account.Location = new Point(1458, 499);
            account.Name = "account";
            account.Size = new Size(347, 191);
            account.TabIndex = 19;
            account.UseVisualStyleBackColor = true;
            // 
            // userlbl
            // 
            userlbl.AutoSize = true;
            userlbl.BackColor = Color.Transparent;
            userlbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userlbl.Location = new Point(1133, 693);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(105, 39);
            userlbl.TabIndex = 18;
            userlbl.Text = "Users";
            // 
            // users
            // 
            users.BackgroundImage = (Image)resources.GetObject("users.BackgroundImage");
            users.BackgroundImageLayout = ImageLayout.Zoom;
            users.FlatAppearance.BorderColor = Color.Black;
            users.FlatAppearance.BorderSize = 2;
            users.Location = new Point(1011, 499);
            users.Name = "users";
            users.Size = new Size(347, 191);
            users.TabIndex = 17;
            users.UseVisualStyleBackColor = true;
            // 
            // appointments
            // 
            appointments.BackgroundImage = (Image)resources.GetObject("appointments.BackgroundImage");
            appointments.BackgroundImageLayout = ImageLayout.Zoom;
            appointments.FlatAppearance.BorderColor = Color.Black;
            appointments.FlatAppearance.BorderSize = 2;
            appointments.Location = new Point(557, 499);
            appointments.Name = "appointments";
            appointments.Size = new Size(347, 191);
            appointments.TabIndex = 16;
            appointments.UseVisualStyleBackColor = true;
            appointments.Click += appointments_Click;
            // 
            // appointmentslbl
            // 
            appointmentslbl.AutoSize = true;
            appointmentslbl.BackColor = Color.Transparent;
            appointmentslbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentslbl.Location = new Point(613, 693);
            appointmentslbl.Name = "appointmentslbl";
            appointmentslbl.Size = new Size(219, 39);
            appointmentslbl.TabIndex = 15;
            appointmentslbl.Text = "Appointments";
            appointmentslbl.Click += appointmentslbl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 750);
            panel2.Name = "panel2";
            panel2.Size = new Size(1786, 39);
            panel2.TabIndex = 21;
            // 
            // LogOut
            // 
            LogOut.AutoSize = true;
            LogOut.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Red;
            LogOut.Location = new Point(1601, 35);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(185, 40);
            LogOut.TabIndex = 22;
            LogOut.Text = "L O G  O U T";
            LogOut.Click += LogOut_Click;
            // 
            // control_panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1786, 789);
            Controls.Add(LogOut);
            Controls.Add(panel2);
            Controls.Add(accountlbl);
            Controls.Add(account);
            Controls.Add(userlbl);
            Controls.Add(users);
            Controls.Add(appointments);
            Controls.Add(appointmentslbl);
            Controls.Add(stafflbl);
            Controls.Add(staff);
            Controls.Add(reportslbl);
            Controls.Add(report);
            Controls.Add(Departmentlbl);
            Controls.Add(department);
            Controls.Add(doctors);
            Controls.Add(Doctorslbl);
            Controls.Add(Patientslbl);
            Controls.Add(patients);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "control_panel";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button patients;
        private Label Patientslbl;
        private Label Doctorslbl;
        private Button doctors;
        private Button department;
        private Label Departmentlbl;
        private Label reportslbl;
        private Button report;
        private Label stafflbl;
        private Button staff;
        private Label accountlbl;
        private Button account;
        private Label userlbl;
        private Button users;
        private Button appointments;
        private Label appointmentslbl;
        private Panel panel2;
        private Label LogOut;
    }
}