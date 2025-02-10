namespace Employee.Presentation
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            AddProduct = new Button();
            ProductsDataGridView = new DataGridView();
            ProductNameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            CategoryIdTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DeleteProduct = new Button();
            ProductIdTextBox = new TextBox();
            label4 = new Label();
            UpdateProduct = new Button();
            Back = new Button();
            label5 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.SeaGreen;
            AddProduct.Cursor = Cursors.Hand;
            AddProduct.FlatStyle = FlatStyle.Flat;
            AddProduct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProduct.ForeColor = SystemColors.ControlLightLight;
            AddProduct.Location = new Point(629, 39);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(140, 30);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(243, 38);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.Size = new Size(299, 180);
            ProductsDataGridView.TabIndex = 1;
            ProductsDataGridView.CellClick += ProductsDataGridView_CellClick;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(244, 297);
            ProductNameTextBox.Multiline = true;
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(305, 30);
            ProductNameTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(244, 358);
            PriceTextBox.Multiline = true;
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(305, 30);
            PriceTextBox.TabIndex = 3;
            // 
            // CategoryIdTextBox
            // 
            CategoryIdTextBox.Location = new Point(244, 420);
            CategoryIdTextBox.Multiline = true;
            CategoryIdTextBox.Name = "CategoryIdTextBox";
            CategoryIdTextBox.Size = new Size(305, 30);
            CategoryIdTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 278);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 5;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 401);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 6;
            label2.Text = "Category Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(244, 339);
            label3.Name = "label3";
            label3.Size = new Size(38, 16);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // DeleteProduct
            // 
            DeleteProduct.BackColor = Color.SeaGreen;
            DeleteProduct.Cursor = Cursors.Hand;
            DeleteProduct.FlatStyle = FlatStyle.Flat;
            DeleteProduct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteProduct.ForeColor = SystemColors.ControlLightLight;
            DeleteProduct.Location = new Point(629, 160);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(140, 30);
            DeleteProduct.TabIndex = 8;
            DeleteProduct.Text = "Delete Product";
            DeleteProduct.UseVisualStyleBackColor = false;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // ProductIdTextBox
            // 
            ProductIdTextBox.Location = new Point(243, 240);
            ProductIdTextBox.Multiline = true;
            ProductIdTextBox.Name = "ProductIdTextBox";
            ProductIdTextBox.ReadOnly = true;
            ProductIdTextBox.Size = new Size(305, 30);
            ProductIdTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 221);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 10;
            label4.Text = "Product Id";
            // 
            // UpdateProduct
            // 
            UpdateProduct.BackColor = Color.SeaGreen;
            UpdateProduct.Cursor = Cursors.Hand;
            UpdateProduct.FlatStyle = FlatStyle.Flat;
            UpdateProduct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateProduct.ForeColor = SystemColors.ControlLightLight;
            UpdateProduct.Location = new Point(629, 100);
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Size = new Size(140, 30);
            UpdateProduct.TabIndex = 11;
            UpdateProduct.Text = "Update Product";
            UpdateProduct.UseVisualStyleBackColor = false;
            UpdateProduct.Click += UpdateProduct_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.SeaGreen;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.ControlLightLight;
            Back.Location = new Point(629, 420);
            Back.Name = "Back";
            Back.Size = new Size(140, 30);
            Back.TabIndex = 12;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(243, 9);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 24;
            label5.Text = "Our Products";
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
            panel1.Location = new Point(0, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 477);
            panel1.TabIndex = 25;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(Back);
            Controls.Add(UpdateProduct);
            Controls.Add(label4);
            Controls.Add(ProductIdTextBox);
            Controls.Add(DeleteProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CategoryIdTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductsDataGridView);
            Controls.Add(AddProduct);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Form";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProduct;
        private DataGridView ProductsDataGridView;
        private TextBox ProductNameTextBox;
        private TextBox PriceTextBox;
        private TextBox CategoryIdTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button DeleteProduct;
        private TextBox ProductIdTextBox;
        private Label label4;
        private Button UpdateProduct;
        private Button Back;
        private Label label5;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}