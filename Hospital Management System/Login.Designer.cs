namespace Hospital_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            emailbox = new TextBox();
            Emailcb = new Label();
            label5 = new Label();
            Passwordbox = new TextBox();
            loginbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 877);
            panel2.Name = "panel2";
            panel2.Size = new Size(1704, 39);
            panel2.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1704, 13);
            panel1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(273, 257);
            label3.Name = "label3";
            label3.Size = new Size(344, 45);
            label3.TabIndex = 42;
            label3.Text = " Simplifying Health";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(184, 212);
            label2.Name = "label2";
            label2.Size = new Size(325, 45);
            label2.TabIndex = 41;
            label2.Text = "Connecting Care,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Imprint MT Shadow", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 84);
            label1.Name = "label1";
            label1.Size = new Size(581, 142);
            label1.TabIndex = 40;
            label1.Text = "MediLink";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(746, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 829);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // emailbox
            // 
            emailbox.BackColor = Color.Silver;
            emailbox.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.Location = new Point(36, 453);
            emailbox.Name = "emailbox";
            emailbox.PlaceholderText = "Admin@mail.com";
            emailbox.Size = new Size(482, 50);
            emailbox.TabIndex = 44;
            // 
            // Emailcb
            // 
            Emailcb.AutoSize = true;
            Emailcb.BackColor = Color.Transparent;
            Emailcb.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emailcb.Location = new Point(36, 400);
            Emailcb.Name = "Emailcb";
            Emailcb.Size = new Size(118, 42);
            Emailcb.TabIndex = 45;
            Emailcb.Text = "Email ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 538);
            label5.Name = "label5";
            label5.Size = new Size(180, 42);
            label5.TabIndex = 47;
            label5.Text = "Password";
            // 
            // Passwordbox
            // 
            Passwordbox.BackColor = Color.Silver;
            Passwordbox.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordbox.Location = new Point(36, 591);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PlaceholderText = "123";
            Passwordbox.Size = new Size(482, 50);
            Passwordbox.TabIndex = 46;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Blue;
            loginbtn.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(36, 696);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(482, 52);
            loginbtn.TabIndex = 48;
            loginbtn.Text = "L O G I N";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 916);
            Controls.Add(loginbtn);
            Controls.Add(label5);
            Controls.Add(Passwordbox);
            Controls.Add(Emailcb);
            Controls.Add(emailbox);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox emailbox;
        private Label Emailcb;
        private Label label5;
        private TextBox Passwordbox;
        private Button loginbtn;
    }
}