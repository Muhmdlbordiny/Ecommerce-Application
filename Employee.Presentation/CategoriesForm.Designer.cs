namespace Employee.Presentation
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            CategoriesDataGridView = new DataGridView();
            AddCategory = new Button();
            CategoryNameTextBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            CategoryIdTextBox = new TextBox();
            label2 = new Label();
            Back = new Button();
            label3 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)CategoriesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CategoriesDataGridView
            // 
            CategoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesDataGridView.Location = new Point(243, 32);
            CategoriesDataGridView.Name = "CategoriesDataGridView";
            CategoriesDataGridView.Size = new Size(302, 200);
            CategoriesDataGridView.TabIndex = 0;
            CategoriesDataGridView.CellClick += CategoriesDataGridView_CellClick;
            // 
            // AddCategory
            // 
            AddCategory.BackColor = Color.SeaGreen;
            AddCategory.Cursor = Cursors.Hand;
            AddCategory.FlatStyle = FlatStyle.Flat;
            AddCategory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddCategory.ForeColor = SystemColors.ControlLightLight;
            AddCategory.Location = new Point(631, 45);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(140, 30);
            AddCategory.TabIndex = 1;
            AddCategory.Text = "Add Category";
            AddCategory.UseVisualStyleBackColor = false;
            AddCategory.Click += AddCategory_Click;
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.Location = new Point(243, 341);
            CategoryNameTextBox.Multiline = true;
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(305, 30);
            CategoryNameTextBox.TabIndex = 2;
            CategoryNameTextBox.TextChanged += CategoryNameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 322);
            label1.Name = "label1";
            label1.Size = new Size(102, 16);
            label1.TabIndex = 3;
            label1.Text = "Category Name";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(631, 115);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 4;
            button1.Text = "Update Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += UpdateCategory_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(631, 190);
            button2.Name = "button2";
            button2.Size = new Size(140, 30);
            button2.TabIndex = 5;
            button2.Text = "Delete Category";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DeleteCategory_Click;
            // 
            // CategoryIdTextBox
            // 
            CategoryIdTextBox.Location = new Point(243, 276);
            CategoryIdTextBox.Multiline = true;
            CategoryIdTextBox.Name = "CategoryIdTextBox";
            CategoryIdTextBox.ReadOnly = true;
            CategoryIdTextBox.Size = new Size(305, 30);
            CategoryIdTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 257);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 7;
            label2.Text = "Category Id";
            // 
            // Back
            // 
            Back.BackColor = Color.SeaGreen;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.ControlLightLight;
            Back.Location = new Point(631, 420);
            Back.Name = "Back";
            Back.Size = new Size(140, 30);
            Back.TabIndex = 13;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 9);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 7;
            label3.Text = "Our Categories";
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
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 475);
            panel1.TabIndex = 14;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Back);
            Controls.Add(label2);
            Controls.Add(CategoryIdTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(AddCategory);
            Controls.Add(CategoriesDataGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories Form";
            ((System.ComponentModel.ISupportInitialize)CategoriesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CategoriesDataGridView;
        private Button AddCategory;
        private TextBox CategoryNameTextBox;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox CategoryIdTextBox;
        private Label label2;
        private Button Back;
        private Label label3;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}