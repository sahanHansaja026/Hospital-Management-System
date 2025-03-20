namespace Hospital_Management_System
{
    partial class Patients
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            panel2 = new Panel();
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ContralPanel = new Label();
            Back = new Label();
            label3 = new Label();
            label4 = new Label();
            Firstnamecb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Lastnamecb = new TextBox();
            label7 = new Label();
            DOBcb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label8 = new Label();
            Contactcb = new TextBox();
            Gendercb = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            bloodcb = new ComboBox();
            label11 = new Label();
            Addresscb = new TextBox();
            label12 = new Label();
            Insurancecb = new TextBox();
            submitbtn = new Button();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 935);
            panel2.Name = "panel2";
            panel2.Size = new Size(1720, 39);
            panel2.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1720, 13);
            panel1.TabIndex = 22;
            // 
            // ContralPanel
            // 
            ContralPanel.AutoSize = true;
            ContralPanel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContralPanel.ForeColor = Color.Blue;
            ContralPanel.Location = new Point(12, 25);
            ContralPanel.Name = "ContralPanel";
            ContralPanel.Size = new Size(178, 27);
            ContralPanel.TabIndex = 40;
            ContralPanel.Text = "Controal Panel";
            ContralPanel.Click += label1_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(196, 25);
            Back.Name = "Back";
            Back.Size = new Size(25, 27);
            Back.TabIndex = 41;
            Back.Text = ">";
            Back.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(227, 25);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 42;
            label3.Text = "Patients";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(585, 67);
            label4.Name = "label4";
            label4.Size = new Size(739, 70);
            label4.TabIndex = 43;
            label4.Text = "New Patient Registration";
            label4.Click += label4_Click;
            // 
            // Firstnamecb
            // 
            Firstnamecb.BackColor = Color.Silver;
            Firstnamecb.BorderStyle = BorderStyle.FixedSingle;
            Firstnamecb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Firstnamecb.Location = new Point(34, 222);
            Firstnamecb.Name = "Firstnamecb";
            Firstnamecb.PlaceholderText = "First Name";
            Firstnamecb.Size = new Size(721, 50);
            Firstnamecb.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 175);
            label5.Name = "label5";
            label5.Size = new Size(234, 44);
            label5.TabIndex = 45;
            label5.Text = "First Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(988, 175);
            label6.Name = "label6";
            label6.Size = new Size(231, 44);
            label6.TabIndex = 47;
            label6.Text = "Last Name :";
            // 
            // Lastnamecb
            // 
            Lastnamecb.BackColor = Color.Silver;
            Lastnamecb.BorderStyle = BorderStyle.FixedSingle;
            Lastnamecb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lastnamecb.Location = new Point(999, 222);
            Lastnamecb.Name = "Lastnamecb";
            Lastnamecb.PlaceholderText = "Last Name";
            Lastnamecb.Size = new Size(721, 50);
            Lastnamecb.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(24, 302);
            label7.Name = "label7";
            label7.Size = new Size(270, 44);
            label7.TabIndex = 49;
            label7.Text = "Date Of Birth :";
            // 
            // DOBcb
            // 
            DOBcb.Checked = true;
            DOBcb.CustomizableEdges = customizableEdges1;
            DOBcb.FillColor = Color.Silver;
            DOBcb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBcb.Format = DateTimePickerFormat.Long;
            DOBcb.Location = new Point(34, 349);
            DOBcb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DOBcb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DOBcb.Name = "DOBcb";
            DOBcb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DOBcb.Size = new Size(362, 50);
            DOBcb.TabIndex = 50;
            DOBcb.Value = new DateTime(2025, 3, 20, 21, 50, 42, 577);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(24, 440);
            label8.Name = "label8";
            label8.Size = new Size(332, 44);
            label8.TabIndex = 52;
            label8.Text = "Contact Number :";
            // 
            // Contactcb
            // 
            Contactcb.BackColor = Color.Silver;
            Contactcb.BorderStyle = BorderStyle.FixedSingle;
            Contactcb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contactcb.Location = new Point(34, 487);
            Contactcb.Name = "Contactcb";
            Contactcb.PlaceholderText = "Contact Number";
            Contactcb.Size = new Size(721, 50);
            Contactcb.TabIndex = 51;
            // 
            // Gendercb
            // 
            Gendercb.BackColor = Color.Silver;
            Gendercb.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gendercb.FormattingEnabled = true;
            Gendercb.Items.AddRange(new object[] { "Male ", "Female", "Transgender Male", "Transgender Female", "Prefer Not to Say", "Other (Specify in Notes)" });
            Gendercb.Location = new Point(999, 351);
            Gendercb.Name = "Gendercb";
            Gendercb.Size = new Size(236, 48);
            Gendercb.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(988, 304);
            label9.Name = "label9";
            label9.Size = new Size(173, 44);
            label9.TabIndex = 54;
            label9.Text = "Gender :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(988, 442);
            label10.Name = "label10";
            label10.Size = new Size(270, 44);
            label10.TabIndex = 56;
            label10.Text = "Blood Group :";
            // 
            // bloodcb
            // 
            bloodcb.BackColor = Color.Silver;
            bloodcb.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bloodcb.FormattingEnabled = true;
            bloodcb.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            bloodcb.Location = new Point(999, 489);
            bloodcb.Name = "bloodcb";
            bloodcb.Size = new Size(236, 48);
            bloodcb.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(24, 568);
            label11.Name = "label11";
            label11.Size = new Size(192, 44);
            label11.TabIndex = 58;
            label11.Text = "Address :";
            // 
            // Addresscb
            // 
            Addresscb.BackColor = Color.Silver;
            Addresscb.BorderStyle = BorderStyle.FixedSingle;
            Addresscb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addresscb.Location = new Point(34, 615);
            Addresscb.Multiline = true;
            Addresscb.Name = "Addresscb";
            Addresscb.PlaceholderText = "Address";
            Addresscb.Size = new Size(721, 123);
            Addresscb.TabIndex = 57;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(989, 568);
            label12.Name = "label12";
            label12.Size = new Size(260, 44);
            label12.TabIndex = 60;
            label12.Text = "Insurance Id :";
            // 
            // Insurancecb
            // 
            Insurancecb.BackColor = Color.Silver;
            Insurancecb.BorderStyle = BorderStyle.FixedSingle;
            Insurancecb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Insurancecb.Location = new Point(999, 615);
            Insurancecb.Name = "Insurancecb";
            Insurancecb.PlaceholderText = "Insurance Id";
            Insurancecb.Size = new Size(721, 50);
            Insurancecb.TabIndex = 59;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Blue;
            submitbtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(34, 831);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(721, 63);
            submitbtn.TabIndex = 62;
            submitbtn.Text = "S U B M I T";
            submitbtn.UseVisualStyleBackColor = false;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1704, 995);
            Controls.Add(submitbtn);
            Controls.Add(label12);
            Controls.Add(Insurancecb);
            Controls.Add(label11);
            Controls.Add(Addresscb);
            Controls.Add(label10);
            Controls.Add(bloodcb);
            Controls.Add(label9);
            Controls.Add(Gendercb);
            Controls.Add(label8);
            Controls.Add(Contactcb);
            Controls.Add(DOBcb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Lastnamecb);
            Controls.Add(label5);
            Controls.Add(Firstnamecb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Back);
            Controls.Add(ContralPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Patients";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label ContralPanel;
        private Label Back;
        private Label label3;
        private Label label4;
        private TextBox Firstnamecb;
        private Label label5;
        private Label label6;
        private TextBox Lastnamecb;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBcb;
        private Label label8;
        private TextBox Contactcb;
        private ComboBox Gendercb;
        private Label label9;
        private Label label10;
        private ComboBox bloodcb;
        private Label label11;
        private TextBox Addresscb;
        private Label label12;
        private TextBox Insurancecb;
        private Button submitbtn;
    }
}