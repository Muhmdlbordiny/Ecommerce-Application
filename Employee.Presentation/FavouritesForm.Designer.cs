namespace Employee.Presentation
{
    partial class FavouritesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouritesForm));
            FavouritesGridView = new DataGridView();
            Back = new Button();
            DeleteButton = new Button();
            label1 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)FavouritesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FavouritesGridView
            // 
            FavouritesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FavouritesGridView.Location = new Point(257, 51);
            FavouritesGridView.Name = "FavouritesGridView";
            FavouritesGridView.Size = new Size(521, 240);
            FavouritesGridView.TabIndex = 0;
            FavouritesGridView.CellContentClick += FavouritesGridView_CellContentClick;
            // 
            // Back
            // 
            Back.BackColor = Color.SeaGreen;
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.ControlLightLight;
            Back.Location = new Point(257, 383);
            Back.Name = "Back";
            Back.Size = new Size(140, 30);
            Back.TabIndex = 1;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SeaGreen;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = SystemColors.ControlLightLight;
            DeleteButton.Location = new Point(638, 383);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(140, 30);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 23;
            label1.Text = "Favourites Form";
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
            panel1.Size = new Size(237, 472);
            panel1.TabIndex = 24;
            // 
            // FavouritesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 462);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(FavouritesGridView);
            Controls.Add(DeleteButton);
            Controls.Add(Back);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FavouritesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favourites Form";
            ((System.ComponentModel.ISupportInitialize)FavouritesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView FavouritesGridView;
        private Button Back;
        private Button DeleteButton;
        private Label label1;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}