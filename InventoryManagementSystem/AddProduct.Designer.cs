namespace InventoryManagementSystem
{
    partial class AddProduct
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
            TitleLabel = new Label();
            MaxTextBox = new TextBox();
            MinTextBox = new TextBox();
            PriceTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            NameTextBox = new TextBox();
            IDTextBox = new TextBox();
            MinLabel = new Label();
            MaxLabel = new Label();
            PriceLabel = new Label();
            PartInventoryLabel = new Label();
            PartNameLabel = new Label();
            PartIDLabel = new Label();
            SearchPartTextBox = new TextBox();
            SearchParts = new Button();
            AddPart = new Button();
            SaveProduct = new Button();
            DeleteProduct = new Button();
            CancelProduct = new Button();
            PartsAssocLabel = new Label();
            ProductsLabel = new Label();
            PartDataView = new DataGridView();
            AssocPartDataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PartDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssocPartDataView).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(96, 21);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Add Product";
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(106, 372);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(85, 23);
            MaxTextBox.TabIndex = 27;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(242, 372);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(85, 23);
            MinTextBox.TabIndex = 26;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(106, 331);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(170, 23);
            PriceTextBox.TabIndex = 25;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(106, 291);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(170, 23);
            InventoryTextBox.TabIndex = 24;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(106, 248);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(170, 23);
            NameTextBox.TabIndex = 23;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(106, 208);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(170, 23);
            IDTextBox.TabIndex = 22;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(208, 375);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 21;
            MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(65, 372);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 20;
            MaxLabel.Text = "Max";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(29, 331);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(68, 15);
            PriceLabel.TabIndex = 19;
            PriceLabel.Text = "Price / Cost";
            // 
            // PartInventoryLabel
            // 
            PartInventoryLabel.AutoSize = true;
            PartInventoryLabel.Location = new Point(40, 291);
            PartInventoryLabel.Name = "PartInventoryLabel";
            PartInventoryLabel.Size = new Size(57, 15);
            PartInventoryLabel.TabIndex = 18;
            PartInventoryLabel.Text = "Inventory";
            // 
            // PartNameLabel
            // 
            PartNameLabel.AutoSize = true;
            PartNameLabel.Location = new Point(58, 251);
            PartNameLabel.Name = "PartNameLabel";
            PartNameLabel.Size = new Size(39, 15);
            PartNameLabel.TabIndex = 17;
            PartNameLabel.Text = "Name";
            // 
            // PartIDLabel
            // 
            PartIDLabel.AutoSize = true;
            PartIDLabel.Location = new Point(77, 211);
            PartIDLabel.Name = "PartIDLabel";
            PartIDLabel.Size = new Size(18, 15);
            PartIDLabel.TabIndex = 16;
            PartIDLabel.Text = "ID";
            // 
            // SearchPartTextBox
            // 
            SearchPartTextBox.Location = new Point(697, 28);
            SearchPartTextBox.Name = "SearchPartTextBox";
            SearchPartTextBox.Size = new Size(180, 23);
            SearchPartTextBox.TabIndex = 31;
            // 
            // SearchParts
            // 
            SearchParts.Location = new Point(631, 26);
            SearchParts.Name = "SearchParts";
            SearchParts.Size = new Size(60, 25);
            SearchParts.TabIndex = 30;
            SearchParts.Text = "Search";
            SearchParts.UseVisualStyleBackColor = true;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(797, 281);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(80, 30);
            AddPart.TabIndex = 32;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            // 
            // SaveProduct
            // 
            SaveProduct.Location = new Point(717, 543);
            SaveProduct.Name = "SaveProduct";
            SaveProduct.Size = new Size(80, 30);
            SaveProduct.TabIndex = 33;
            SaveProduct.Text = "Save";
            SaveProduct.UseVisualStyleBackColor = true;
            SaveProduct.Click += SaveProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(631, 543);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(80, 30);
            DeleteProduct.TabIndex = 34;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // CancelProduct
            // 
            CancelProduct.Location = new Point(801, 543);
            CancelProduct.Name = "CancelProduct";
            CancelProduct.Size = new Size(80, 30);
            CancelProduct.TabIndex = 35;
            CancelProduct.Text = "Cancel";
            CancelProduct.UseVisualStyleBackColor = true;
            CancelProduct.Click += Cancel_Click;
            // 
            // PartsAssocLabel
            // 
            PartsAssocLabel.AutoSize = true;
            PartsAssocLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartsAssocLabel.Location = new Point(401, 306);
            PartsAssocLabel.Name = "PartsAssocLabel";
            PartsAssocLabel.Size = new Size(204, 17);
            PartsAssocLabel.TabIndex = 58;
            PartsAssocLabel.Text = "Parts Associated with this Product";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductsLabel.Location = new Point(401, 47);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(116, 17);
            ProductsLabel.TabIndex = 59;
            ProductsLabel.Text = "All candidate Parts";
            // 
            // PartDataView
            // 
            PartDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartDataView.Location = new Point(406, 70);
            PartDataView.Name = "PartDataView";
            PartDataView.Size = new Size(480, 199);
            PartDataView.TabIndex = 60;
            // 
            // AssocPartDataView
            // 
            AssocPartDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssocPartDataView.Location = new Point(406, 326);
            AssocPartDataView.Name = "AssocPartDataView";
            AssocPartDataView.Size = new Size(480, 199);
            AssocPartDataView.TabIndex = 61;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 587);
            Controls.Add(AssocPartDataView);
            Controls.Add(PartDataView);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsAssocLabel);
            Controls.Add(CancelProduct);
            Controls.Add(DeleteProduct);
            Controls.Add(SaveProduct);
            Controls.Add(AddPart);
            Controls.Add(SearchPartTextBox);
            Controls.Add(SearchParts);
            Controls.Add(MaxTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(MinLabel);
            Controls.Add(MaxLabel);
            Controls.Add(PriceLabel);
            Controls.Add(PartInventoryLabel);
            Controls.Add(PartNameLabel);
            Controls.Add(PartIDLabel);
            Controls.Add(TitleLabel);
            Name = "AddProduct";
            ShowIcon = false;
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)PartDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssocPartDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox MaxTextBox;
        private TextBox MinTextBox;
        private TextBox PriceTextBox;
        private TextBox InventoryTextBox;
        private TextBox NameTextBox;
        private TextBox IDTextBox;
        private Label MinLabel;
        private Label MaxLabel;
        private Label PriceLabel;
        private Label PartInventoryLabel;
        private Label PartNameLabel;
        private Label PartIDLabel;
        private TextBox SearchPartTextBox;
        private Button SearchParts;
        private Button AddPart;
        private Button SaveProduct;
        private Button DeleteProduct;
        private Button CancelProduct;
        private Label PartsAssocLabel;
        private Label ProductsLabel;
        private DataGridView PartDataView;
        private DataGridView AssocPartDataView;
    }
}