namespace Employee.Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Login = new Button();
            LoginPasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxRole = new ComboBox();
            label1 = new Label();
            BackButton = new Button();
            RegisterHere = new Label();
            label7 = new Label();
            label4 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.SeaGreen;
            Login.Cursor = Cursors.Hand;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ControlLightLight;
            Login.Location = new Point(616, 405);
            Login.Name = "Login";
            Login.Size = new Size(140, 30);
            Login.TabIndex = 2;
            Login.Text = "Login ";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // LoginPasswordTextBox
            // 
            LoginPasswordTextBox.Location = new Point(364, 190);
            LoginPasswordTextBox.Multiline = true;
            LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            LoginPasswordTextBox.PasswordChar = '*';
            LoginPasswordTextBox.Size = new Size(305, 30);
            LoginPasswordTextBox.TabIndex = 16;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(364, 109);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(305, 30);
            EmailTextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(364, 157);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 72);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.ItemHeight = 15;
            comboBoxRole.Location = new Point(364, 309);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(305, 23);
            comboBoxRole.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 282);
            label1.Name = "label1";
            label1.Size = new Size(36, 16);
            label1.TabIndex = 18;
            label1.Text = "Role";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.SeaGreen;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ControlLightLight;
            BackButton.Location = new Point(291, 405);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(140, 30);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RegisterHere
            // 
            RegisterHere.AutoSize = true;
            RegisterHere.Cursor = Cursors.Hand;
            RegisterHere.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterHere.Location = new Point(568, 353);
            RegisterHere.Name = "RegisterHere";
            RegisterHere.Size = new Size(101, 16);
            RegisterHere.TabIndex = 7;
            RegisterHere.Text = "Register here";
            RegisterHere.Click += RegisterHere_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(364, 353);
            label7.Name = "label7";
            label7.Size = new Size(146, 16);
            label7.TabIndex = 6;
            label7.Text = "Don't have an account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 9);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 21;
            label4.Text = "Welcome Back!";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(73, 148);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 7;
            label9.Text = "E-commerce";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(3);
            pictureBox1.Size = new Size(171, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 471);
            panel1.TabIndex = 23;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Cursor = Cursors.Hand;
            ShowPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPassword.Location = new Point(364, 236);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(121, 20);
            ShowPassword.TabIndex = 25;
            ShowPassword.Text = "Show password";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(ShowPassword);
            Controls.Add(panel1);
            Controls.Add(RegisterHere);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Controls.Add(comboBoxRole);
            Controls.Add(LoginPasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Login;
        private TextBox LoginPasswordTextBox;
        private TextBox EmailTextBox;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxRole;
        private Label label1;
        private Button BackButton;
        private Label label4;
        private Label RegisterHere;
        private Label label7;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox ShowPassword;
    }
}