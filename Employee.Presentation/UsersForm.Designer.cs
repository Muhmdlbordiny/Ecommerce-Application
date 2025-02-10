namespace Employee.Presentation
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            ProductsDataGridView = new DataGridView();
            ViewProducts = new Button();
            AddProductToFavourite = new Button();
            OpenMyFavourites = new Button();
            label1 = new Label();
            ProductIdTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            CategoryIdTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BackButton = new Button();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(247, 32);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.Size = new Size(281, 183);
            ProductsDataGridView.TabIndex = 0;
            ProductsDataGridView.CellClick += ProductsDataGridView_CellClick;
            // 
            // ViewProducts
            // 
            ViewProducts.BackColor = Color.SeaGreen;
            ViewProducts.Cursor = Cursors.Hand;
            ViewProducts.FlatStyle = FlatStyle.Flat;
            ViewProducts.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewProducts.ForeColor = SystemColors.ControlLightLight;
            ViewProducts.Location = new Point(637, 32);
            ViewProducts.Name = "ViewProducts";
            ViewProducts.Size = new Size(140, 30);
            ViewProducts.TabIndex = 1;
            ViewProducts.Text = "View Products";
            ViewProducts.UseVisualStyleBackColor = false;
            ViewProducts.Click += ViewProducts_Click;
            // 
            // AddProductToFavourite
            // 
            AddProductToFavourite.BackColor = Color.SeaGreen;
            AddProductToFavourite.Cursor = Cursors.Hand;
            AddProductToFavourite.FlatStyle = FlatStyle.Flat;
            AddProductToFavourite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProductToFavourite.ForeColor = SystemColors.ControlLightLight;
            AddProductToFavourite.Location = new Point(637, 86);
            AddProductToFavourite.Name = "AddProductToFavourite";
            AddProductToFavourite.Size = new Size(140, 30);
            AddProductToFavourite.TabIndex = 2;
            AddProductToFavourite.Text = "Add To Favourite";
            AddProductToFavourite.UseVisualStyleBackColor = false;
            AddProductToFavourite.Click += AddProductToFavourite_Click;
            // 
            // OpenMyFavourites
            // 
            OpenMyFavourites.BackColor = Color.SeaGreen;
            OpenMyFavourites.Cursor = Cursors.Hand;
            OpenMyFavourites.FlatStyle = FlatStyle.Flat;
            OpenMyFavourites.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenMyFavourites.ForeColor = SystemColors.ControlLightLight;
            OpenMyFavourites.Location = new Point(637, 138);
            OpenMyFavourites.Name = "OpenMyFavourites";
            OpenMyFavourites.Size = new Size(140, 30);
            OpenMyFavourites.TabIndex = 3;
            OpenMyFavourites.Text = "Open My Favourites";
            OpenMyFavourites.UseVisualStyleBackColor = false;
            OpenMyFavourites.Click += OpenMyFavourites_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 233);
            label1.Name = "label1";
            label1.Size = new Size(67, 16);
            label1.TabIndex = 4;
            label1.Text = "Product Id";
            // 
            // ProductIdTextBox
            // 
            ProductIdTextBox.Location = new Point(243, 252);
            ProductIdTextBox.Multiline = true;
            ProductIdTextBox.Name = "ProductIdTextBox";
            ProductIdTextBox.ReadOnly = true;
            ProductIdTextBox.Size = new Size(305, 30);
            ProductIdTextBox.TabIndex = 8;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(247, 304);
            ProductNameTextBox.Multiline = true;
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.ReadOnly = true;
            ProductNameTextBox.Size = new Size(305, 30);
            ProductNameTextBox.TabIndex = 10;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(247, 356);
            PriceTextBox.Multiline = true;
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.ReadOnly = true;
            PriceTextBox.Size = new Size(305, 30);
            PriceTextBox.TabIndex = 11;
            // 
            // CategoryIdTextBox
            // 
            CategoryIdTextBox.Location = new Point(247, 408);
            CategoryIdTextBox.Multiline = true;
            CategoryIdTextBox.Name = "CategoryIdTextBox";
            CategoryIdTextBox.ReadOnly = true;
            CategoryIdTextBox.Size = new Size(305, 30);
            CategoryIdTextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 285);
            label3.Name = "label3";
            label3.Size = new Size(93, 16);
            label3.TabIndex = 13;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 337);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 14;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(247, 389);
            label5.Name = "label5";
            label5.Size = new Size(76, 16);
            label5.TabIndex = 15;
            label5.Text = "Category Id";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.SeaGreen;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ControlLightLight;
            BackButton.Location = new Point(637, 408);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(140, 30);
            BackButton.TabIndex = 16;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
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
            panel1.Size = new Size(237, 471);
            panel1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(243, 9);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 25;
            label6.Text = "Our Products";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(BackButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CategoryIdTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductIdTextBox);
            Controls.Add(label1);
            Controls.Add(OpenMyFavourites);
            Controls.Add(AddProductToFavourite);
            Controls.Add(ViewProducts);
            Controls.Add(ProductsDataGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users Form";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private Button ViewProducts;
        private Button AddProductToFavourite;
        private Button OpenMyFavourites;
        private Label label1;
        private TextBox ProductIdTextBox;
        private TextBox ProductNameTextBox;
        private TextBox PriceTextBox;
        private TextBox CategoryIdTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BackButton;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
    }
}