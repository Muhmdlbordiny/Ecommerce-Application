namespace Employee.Presentation
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            CRUDProducts = new Button();
            CRUDCategories = new Button();
            CRUDUsers = new Button();
            BackButton = new Button();
            label1 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CRUDProducts
            // 
            CRUDProducts.BackColor = Color.SeaGreen;
            CRUDProducts.Cursor = Cursors.Hand;
            CRUDProducts.FlatStyle = FlatStyle.Flat;
            CRUDProducts.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CRUDProducts.ForeColor = SystemColors.ControlLightLight;
            CRUDProducts.Location = new Point(367, 102);
            CRUDProducts.Name = "CRUDProducts";
            CRUDProducts.Size = new Size(305, 30);
            CRUDProducts.TabIndex = 0;
            CRUDProducts.Text = "CRUD Products";
            CRUDProducts.UseVisualStyleBackColor = false;
            CRUDProducts.Click += CRUDProducts_Click;
            // 
            // CRUDCategories
            // 
            CRUDCategories.BackColor = Color.SeaGreen;
            CRUDCategories.Cursor = Cursors.Hand;
            CRUDCategories.FlatStyle = FlatStyle.Flat;
            CRUDCategories.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CRUDCategories.ForeColor = SystemColors.ControlLightLight;
            CRUDCategories.Location = new Point(367, 181);
            CRUDCategories.Name = "CRUDCategories";
            CRUDCategories.Size = new Size(305, 30);
            CRUDCategories.TabIndex = 1;
            CRUDCategories.Text = "CRUD Categories";
            CRUDCategories.UseVisualStyleBackColor = false;
            CRUDCategories.Click += CRUDCategories_Click;
            // 
            // CRUDUsers
            // 
            CRUDUsers.BackColor = Color.SeaGreen;
            CRUDUsers.Cursor = Cursors.Hand;
            CRUDUsers.FlatStyle = FlatStyle.Flat;
            CRUDUsers.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CRUDUsers.ForeColor = SystemColors.ControlLightLight;
            CRUDUsers.Location = new Point(367, 272);
            CRUDUsers.Name = "CRUDUsers";
            CRUDUsers.Size = new Size(305, 30);
            CRUDUsers.TabIndex = 2;
            CRUDUsers.Text = "CRUD Users";
            CRUDUsers.UseVisualStyleBackColor = false;
            CRUDUsers.Click += CRUDUsers_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.SeaGreen;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ControlLightLight;
            BackButton.Location = new Point(367, 408);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(140, 30);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 23;
            label1.Text = "Admin Form";
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
            panel1.Size = new Size(237, 473);
            panel1.TabIndex = 24;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(CRUDUsers);
            Controls.Add(CRUDCategories);
            Controls.Add(CRUDProducts);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CRUDProducts;
        private Button CRUDCategories;
        private Button CRUDUsers;
        private Button BackButton;
        private Label label1;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}