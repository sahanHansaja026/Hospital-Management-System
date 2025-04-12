namespace Hospital_Management_System
{
    partial class userinput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userinput));
            loginbtn = new Button();
            label5 = new Label();
            Passwordbox = new TextBox();
            Emailcb = new Label();
            emailbox = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            userinputpage = new Label();
            label4 = new Label();
            usernamecb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Blue;
            loginbtn.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(36, 709);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(482, 52);
            loginbtn.TabIndex = 59;
            loginbtn.Text = "S I G N  U P";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 572);
            label5.Name = "label5";
            label5.Size = new Size(180, 42);
            label5.TabIndex = 58;
            label5.Text = "Password";
            // 
            // Passwordbox
            // 
            Passwordbox.BackColor = Color.Silver;
            Passwordbox.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordbox.Location = new Point(36, 625);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PlaceholderText = "123";
            Passwordbox.Size = new Size(482, 50);
            Passwordbox.TabIndex = 57;
            // 
            // Emailcb
            // 
            Emailcb.AutoSize = true;
            Emailcb.BackColor = Color.Transparent;
            Emailcb.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emailcb.Location = new Point(36, 325);
            Emailcb.Name = "Emailcb";
            Emailcb.Size = new Size(118, 42);
            Emailcb.TabIndex = 56;
            Emailcb.Text = "Email ";
            // 
            // emailbox
            // 
            emailbox.BackColor = Color.Silver;
            emailbox.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.Location = new Point(36, 378);
            emailbox.Name = "emailbox";
            emailbox.PlaceholderText = "Admin@mail.com";
            emailbox.Size = new Size(482, 50);
            emailbox.TabIndex = 55;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(746, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 829);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(273, 270);
            label3.Name = "label3";
            label3.Size = new Size(344, 45);
            label3.TabIndex = 53;
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
            label2.TabIndex = 52;
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
            label1.TabIndex = 51;
            label1.Text = "MediLink";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 877);
            panel2.Name = "panel2";
            panel2.Size = new Size(1704, 39);
            panel2.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1704, 13);
            panel1.TabIndex = 49;
            // 
            // userinputpage
            // 
            userinputpage.AutoSize = true;
            userinputpage.BackColor = Color.Transparent;
            userinputpage.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userinputpage.Location = new Point(36, 795);
            userinputpage.Name = "userinputpage";
            userinputpage.Size = new Size(556, 42);
            userinputpage.TabIndex = 60;
            userinputpage.Text = "Alredy Have Account , Click Hear";
            userinputpage.Click += userinputpage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 452);
            label4.Name = "label4";
            label4.Size = new Size(181, 42);
            label4.TabIndex = 62;
            label4.Text = "username";
            // 
            // usernamecb
            // 
            usernamecb.BackColor = Color.Silver;
            usernamecb.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamecb.Location = new Point(36, 497);
            usernamecb.Name = "usernamecb";
            usernamecb.PlaceholderText = "Admin";
            usernamecb.Size = new Size(482, 50);
            usernamecb.TabIndex = 61;
            // 
            // userinput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 916);
            Controls.Add(label4);
            Controls.Add(usernamecb);
            Controls.Add(userinputpage);
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
            Name = "userinput";
            Text = "MediLink";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Label label5;
        private TextBox Passwordbox;
        private Label Emailcb;
        private TextBox emailbox;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Label userinputpage;
        private Label label4;
        private TextBox usernamecb;
    }
}