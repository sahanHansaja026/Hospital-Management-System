namespace Hospital_Management_System
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            submitbtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            label10 = new Label();
            DoctorNamecb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Back = new Label();
            ContralPanel = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            PatientNamecb = new ComboBox();
            label1 = new Label();
            Diagnosiscb = new TextBox();
            label2 = new Label();
            Prescriptioncb = new TextBox();
            datecb = new DateTimePicker();
            label7 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Blue;
            submitbtn.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbtn.ForeColor = Color.White;
            submitbtn.Location = new Point(710, 913);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(517, 63);
            submitbtn.TabIndex = 122;
            submitbtn.Text = "S U B M I T";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(13, 250);
            label10.Name = "label10";
            label10.Size = new Size(274, 44);
            label10.TabIndex = 121;
            label10.Text = "Doctor Name :";
            // 
            // DoctorNamecb
            // 
            DoctorNamecb.BackColor = Color.Silver;
            DoctorNamecb.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoctorNamecb.FormattingEnabled = true;
            DoctorNamecb.Location = new Point(23, 297);
            DoctorNamecb.Name = "DoctorNamecb";
            DoctorNamecb.Size = new Size(721, 48);
            DoctorNamecb.TabIndex = 120;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(13, 132);
            label5.Name = "label5";
            label5.Size = new Size(278, 44);
            label5.TabIndex = 119;
            label5.Text = "Patient Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(549, 49);
            label4.Name = "label4";
            label4.Size = new Size(609, 70);
            label4.TabIndex = 117;
            label4.Text = "Patient Report Entry";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(215, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 27);
            label3.TabIndex = 116;
            label3.Text = "Report";
            label3.Click += label3_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(184, 25);
            Back.Name = "Back";
            Back.Size = new Size(25, 27);
            Back.TabIndex = 115;
            Back.Text = ">";
            // 
            // ContralPanel
            // 
            ContralPanel.AutoSize = true;
            ContralPanel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContralPanel.ForeColor = Color.Blue;
            ContralPanel.Location = new Point(0, 25);
            ContralPanel.Name = "ContralPanel";
            ContralPanel.Size = new Size(178, 27);
            ContralPanel.TabIndex = 114;
            ContralPanel.Text = "Controal Panel";
            ContralPanel.Click += ContralPanel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1012);
            panel2.Name = "panel2";
            panel2.Size = new Size(1751, 39);
            panel2.TabIndex = 113;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1751, 13);
            panel1.TabIndex = 112;
            // 
            // PatientNamecb
            // 
            PatientNamecb.BackColor = Color.Silver;
            PatientNamecb.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientNamecb.FormattingEnabled = true;
            PatientNamecb.Location = new Point(23, 179);
            PatientNamecb.Name = "PatientNamecb";
            PatientNamecb.Size = new Size(721, 48);
            PatientNamecb.TabIndex = 126;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 481);
            label1.Name = "label1";
            label1.Size = new Size(221, 44);
            label1.TabIndex = 130;
            label1.Text = "Diagnosis :";
            // 
            // Diagnosiscb
            // 
            Diagnosiscb.BackColor = Color.Silver;
            Diagnosiscb.BorderStyle = BorderStyle.FixedSingle;
            Diagnosiscb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Diagnosiscb.Location = new Point(23, 528);
            Diagnosiscb.Multiline = true;
            Diagnosiscb.Name = "Diagnosiscb";
            Diagnosiscb.PlaceholderText = "Diagnosis :";
            Diagnosiscb.Size = new Size(721, 339);
            Diagnosiscb.TabIndex = 129;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(899, 170);
            label2.Name = "label2";
            label2.Size = new Size(259, 44);
            label2.TabIndex = 134;
            label2.Text = "Prescription :";
            // 
            // Prescriptioncb
            // 
            Prescriptioncb.BackColor = Color.Silver;
            Prescriptioncb.BorderStyle = BorderStyle.FixedSingle;
            Prescriptioncb.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prescriptioncb.Location = new Point(909, 217);
            Prescriptioncb.Multiline = true;
            Prescriptioncb.Name = "Prescriptioncb";
            Prescriptioncb.PlaceholderText = "Prescription";
            Prescriptioncb.Size = new Size(792, 375);
            Prescriptioncb.TabIndex = 133;
            // 
            // datecb
            // 
            datecb.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datecb.Location = new Point(23, 423);
            datecb.Name = "datecb";
            datecb.Size = new Size(547, 45);
            datecb.TabIndex = 136;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(17, 362);
            label7.Name = "label7";
            label7.Size = new Size(270, 44);
            label7.TabIndex = 135;
            label7.Text = "Date Of Birth :";
            // 
            // Report
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1751, 1051);
            Controls.Add(datecb);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(Prescriptioncb);
            Controls.Add(submitbtn);
            Controls.Add(label1);
            Controls.Add(Diagnosiscb);
            Controls.Add(PatientNamecb);
            Controls.Add(label10);
            Controls.Add(DoctorNamecb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Back);
            Controls.Add(ContralPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Report";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += Report_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Label label10;
        private ComboBox DoctorNamecb;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Back;
        private Label ContralPanel;
        private Panel panel2;
        private Panel panel1;
        private ComboBox PatientNamecb;
        private Label label1;
        private TextBox Diagnosiscb;
        private Label label2;
        private TextBox Prescriptioncb;
        private DateTimePicker datecb;
        private Label label7;
    }
}