namespace Employee.Presentation
{
    partial class UesrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UesrForm));
            UsersDataGridView = new DataGridView();
            AddUser = new Button();
            UpdateUser = new Button();
            DeleteUser = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            UserIdTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            UserPasswordTextBox = new TextBox();
            AddressTextBox = new TextBox();
            AgeUpDown = new NumericUpDown();
            RoleComboBox = new ComboBox();
            Back = new Button();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgeUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.Location = new Point(571, 28);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.Size = new Size(217, 191);
            UsersDataGridView.TabIndex = 0;
            UsersDataGridView.CellClick += UsersDataGridView_CellClick;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.SeaGreen;
            AddUser.Cursor = Cursors.Hand;
            AddUser.FlatStyle = FlatStyle.Flat;
            AddUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddUser.ForeColor = SystemColors.ControlLightLight;
            AddUser.Location = new Point(639, 232);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(140, 30);
            AddUser.TabIndex = 1;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = false;
            AddUser.Click += AddUser_Click;
            // 
            // UpdateUser
            // 
            UpdateUser.BackColor = Color.SeaGreen;
            UpdateUser.Cursor = Cursors.Hand;
            UpdateUser.FlatStyle = FlatStyle.Flat;
            UpdateUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateUser.ForeColor = SystemColors.ControlLightLight;
            UpdateUser.Location = new Point(639, 289);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(140, 30);
            UpdateUser.TabIndex = 2;
            UpdateUser.Text = "Update User";
            UpdateUser.UseVisualStyleBackColor = false;
            UpdateUser.Click += UpdateUser_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.BackColor = Color.SeaGreen;
            DeleteUser.Cursor = Cursors.Hand;
            DeleteUser.FlatStyle = FlatStyle.Flat;
            DeleteUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteUser.ForeColor = SystemColors.ControlLightLight;
            DeleteUser.Location = new Point(639, 351);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(140, 30);
            DeleteUser.TabIndex = 3;
            DeleteUser.Text = "Delete User";
            DeleteUser.UseVisualStyleBackColor = false;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 16);
            label1.TabIndex = 4;
            label1.Text = "User Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 93);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 146);
            label3.Name = "label3";
            label3.Size = new Size(41, 16);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 203);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(243, 289);
            label5.Name = "label5";
            label5.Size = new Size(32, 16);
            label5.TabIndex = 8;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(243, 348);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(243, 410);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 10;
            label7.Text = "Role";
            // 
            // UserIdTextBox
            // 
            UserIdTextBox.Location = new Point(243, 60);
            UserIdTextBox.Multiline = true;
            UserIdTextBox.Name = "UserIdTextBox";
            UserIdTextBox.ReadOnly = true;
            UserIdTextBox.Size = new Size(305, 30);
            UserIdTextBox.TabIndex = 11;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(243, 113);
            UserNameTextBox.Multiline = true;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(305, 30);
            UserNameTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(243, 165);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(305, 30);
            EmailTextBox.TabIndex = 13;
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.Location = new Point(243, 222);
            UserPasswordTextBox.Multiline = true;
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.Size = new Size(305, 30);
            UserPasswordTextBox.TabIndex = 14;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(243, 368);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(305, 30);
            AddressTextBox.TabIndex = 15;
            // 
            // AgeUpDown
            // 
            AgeUpDown.Location = new Point(243, 313);
            AgeUpDown.Name = "AgeUpDown";
            AgeUpDown.Size = new Size(305, 23);
            AgeUpDown.TabIndex = 16;
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(243, 429);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(305, 23);
            RoleComboBox.TabIndex = 17;
            // 
            // Back
            // 
            Back.BackColor = Color.SeaGreen;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.ControlLightLight;
            Back.Location = new Point(639, 410);
            Back.Name = "Back";
            Back.Size = new Size(140, 30);
            Back.TabIndex = 18;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(248, 9);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 7;
            label8.Text = "Our Users";
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
            panel1.Location = new Point(0, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 476);
            panel1.TabIndex = 19;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Cursor = Cursors.Hand;
            ShowPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPassword.Location = new Point(243, 258);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(121, 20);
            ShowPassword.TabIndex = 26;
            ShowPassword.Text = "Show password";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // UesrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(ShowPassword);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(UsersDataGridView);
            Controls.Add(Back);
            Controls.Add(RoleComboBox);
            Controls.Add(AgeUpDown);
            Controls.Add(AddressTextBox);
            Controls.Add(UserPasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserIdTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteUser);
            Controls.Add(UpdateUser);
            Controls.Add(AddUser);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UesrForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uesr Form";
            Load += UesrForm_Load;
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgeUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UsersDataGridView;
        private Button AddUser;
        private Button UpdateUser;
        private Button DeleteUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox UserIdTextBox;
        private TextBox UserNameTextBox;
        private TextBox EmailTextBox;
        private TextBox UserPasswordTextBox;
        private TextBox AddressTextBox;
        private NumericUpDown AgeUpDown;
        private ComboBox RoleComboBox;
        private Button Back;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox ShowPassword;
    }
}