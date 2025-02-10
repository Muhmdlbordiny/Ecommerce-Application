namespace Ecommerce_Application
{
    partial class WelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Register = new Button();
            Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 52);
            label1.Name = "label1";
            label1.Size = new Size(563, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our Ecommerce Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 232);
            label2.Name = "label2";
            label2.Size = new Size(174, 17);
            label2.TabIndex = 1;
            label2.Text = "if you haven't account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 328);
            label3.Name = "label3";
            label3.Size = new Size(153, 17);
            label3.TabIndex = 2;
            label3.Text = "If you have account";
            // 
            // Register
            // 
            Register.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register.Location = new Point(374, 214);
            Register.Name = "Register";
            Register.Size = new Size(200, 50);
            Register.TabIndex = 3;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Login
            // 
            Login.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(374, 310);
            Login.Name = "Login";
            Login.Size = new Size(200, 50);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(657, 450);
            Controls.Add(Login);
            Controls.Add(Register);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WelcomePage";
            Text = "Welcome Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Register;
        private Button Login;
    }
}
