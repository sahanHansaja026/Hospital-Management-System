namespace Hospital_Management_System
{
    partial class Rview
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rview));
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            label3 = new Label();
            Back = new Label();
            ContralPanel = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            searchDoctor = new Button();
            Doctorslbl = new Label();
            Patientslbl = new Label();
            Adddoctor = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(215, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 27);
            label3.TabIndex = 131;
            label3.Text = "Report";
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(184, 25);
            Back.Name = "Back";
            Back.Size = new Size(25, 27);
            Back.TabIndex = 130;
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
            ContralPanel.TabIndex = 129;
            ContralPanel.Text = "Controal Panel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1016);
            panel2.Name = "panel2";
            panel2.Size = new Size(1704, 39);
            panel2.TabIndex = 128;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1704, 13);
            panel1.TabIndex = 127;
            // 
            // searchDoctor
            // 
            searchDoctor.BackgroundImage = (Image)resources.GetObject("searchDoctor.BackgroundImage");
            searchDoctor.BackgroundImageLayout = ImageLayout.Zoom;
            searchDoctor.FlatAppearance.BorderColor = Color.Black;
            searchDoctor.FlatAppearance.BorderSize = 2;
            searchDoctor.Location = new Point(990, 340);
            searchDoctor.Name = "searchDoctor";
            searchDoctor.Size = new Size(347, 191);
            searchDoctor.TabIndex = 135;
            searchDoctor.UseVisualStyleBackColor = true;
            searchDoctor.Click += searchDoctor_Click;
            // 
            // Doctorslbl
            // 
            Doctorslbl.AutoSize = true;
            Doctorslbl.BackColor = Color.Transparent;
            Doctorslbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Doctorslbl.Location = new Point(1046, 534);
            Doctorslbl.Name = "Doctorslbl";
            Doctorslbl.Size = new Size(231, 39);
            Doctorslbl.TabIndex = 134;
            Doctorslbl.Text = "Search Report";
            // 
            // Patientslbl
            // 
            Patientslbl.AutoSize = true;
            Patientslbl.BackColor = Color.Transparent;
            Patientslbl.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Patientslbl.Location = new Point(557, 534);
            Patientslbl.Name = "Patientslbl";
            Patientslbl.Size = new Size(299, 39);
            Patientslbl.TabIndex = 133;
            Patientslbl.Text = "Create New Report";
            // 
            // Adddoctor
            // 
            Adddoctor.BackgroundImage = (Image)resources.GetObject("Adddoctor.BackgroundImage");
            Adddoctor.BackgroundImageLayout = ImageLayout.Zoom;
            Adddoctor.FlatAppearance.BorderColor = Color.Black;
            Adddoctor.FlatAppearance.BorderSize = 2;
            Adddoctor.FlatAppearance.MouseDownBackColor = Color.Black;
            Adddoctor.FlatAppearance.MouseOverBackColor = Color.Black;
            Adddoctor.Location = new Point(526, 340);
            Adddoctor.Name = "Adddoctor";
            Adddoctor.Size = new Size(347, 191);
            Adddoctor.TabIndex = 132;
            Adddoctor.UseVisualStyleBackColor = true;
            Adddoctor.Click += Adddoctor_Click;
            // 
            // Rview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 1055);
            Controls.Add(label3);
            Controls.Add(Back);
            Controls.Add(ContralPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(searchDoctor);
            Controls.Add(Doctorslbl);
            Controls.Add(Patientslbl);
            Controls.Add(Adddoctor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rview";
            Text = "MediLInk";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label3;
        private Label Back;
        private Label ContralPanel;
        private Panel panel2;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button searchDoctor;
        private Label Doctorslbl;
        private Label Patientslbl;
        private Button Adddoctor;
    }
}