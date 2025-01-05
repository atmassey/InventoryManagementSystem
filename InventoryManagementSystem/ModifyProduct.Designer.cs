namespace InventoryManagementSystem
{
    partial class ModifyProduct
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
            CancelProduct = new Button();
            SaveProduct = new Button();
            AddPart = new Button();
            SearchPartTextBox = new TextBox();
            SearchParts = new Button();
            MaxAssoc = new ColumnHeader();
            MinAssoc = new ColumnHeader();
            PriceAssoc = new ColumnHeader();
            InventoryAssoc = new ColumnHeader();
            NameAssoc = new ColumnHeader();
            PartIDAssoc = new ColumnHeader();
            AssociatedParts = new ListView();
            PartMaxAll = new ColumnHeader();
            PartMinAll = new ColumnHeader();
            PartPriceAll = new ColumnHeader();
            DeleteProduct = new Button();
            PartInventoryAll = new ColumnHeader();
            PartIDAll = new ColumnHeader();
            AllCandidateParts = new ListView();
            PartNameAll = new ColumnHeader();
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
            TitleLabel = new Label();
            PartsAssocLabel = new Label();
            ProductsLabel = new Label();
            SuspendLayout();
            // 
            // CancelProduct
            // 
            CancelProduct.Location = new Point(807, 545);
            CancelProduct.Name = "CancelProduct";
            CancelProduct.Size = new Size(80, 30);
            CancelProduct.TabIndex = 56;
            CancelProduct.Text = "Cancel";
            CancelProduct.UseVisualStyleBackColor = true;
            CancelProduct.Click += Cancel_Click;
            // 
            // SaveProduct
            // 
            SaveProduct.Location = new Point(723, 545);
            SaveProduct.Name = "SaveProduct";
            SaveProduct.Size = new Size(80, 30);
            SaveProduct.TabIndex = 54;
            SaveProduct.Text = "Save";
            SaveProduct.UseVisualStyleBackColor = true;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(803, 283);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(80, 30);
            AddPart.TabIndex = 53;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            // 
            // SearchPartTextBox
            // 
            SearchPartTextBox.Location = new Point(703, 30);
            SearchPartTextBox.Name = "SearchPartTextBox";
            SearchPartTextBox.Size = new Size(180, 23);
            SearchPartTextBox.TabIndex = 52;
            // 
            // SearchParts
            // 
            SearchParts.Location = new Point(637, 28);
            SearchParts.Name = "SearchParts";
            SearchParts.Size = new Size(60, 25);
            SearchParts.TabIndex = 51;
            SearchParts.Text = "Search";
            SearchParts.UseVisualStyleBackColor = true;
            // 
            // MaxAssoc
            // 
            MaxAssoc.Text = "Max";
            MaxAssoc.TextAlign = HorizontalAlignment.Center;
            MaxAssoc.Width = 76;
            // 
            // MinAssoc
            // 
            MinAssoc.Text = "Min";
            MinAssoc.TextAlign = HorizontalAlignment.Center;
            MinAssoc.Width = 80;
            // 
            // PriceAssoc
            // 
            PriceAssoc.Text = "Price";
            PriceAssoc.TextAlign = HorizontalAlignment.Center;
            PriceAssoc.Width = 80;
            // 
            // InventoryAssoc
            // 
            InventoryAssoc.Text = "Inventory";
            InventoryAssoc.TextAlign = HorizontalAlignment.Center;
            InventoryAssoc.Width = 80;
            // 
            // NameAssoc
            // 
            NameAssoc.Text = "Name";
            NameAssoc.TextAlign = HorizontalAlignment.Center;
            NameAssoc.Width = 80;
            // 
            // PartIDAssoc
            // 
            PartIDAssoc.Text = "Part ID";
            PartIDAssoc.Width = 80;
            // 
            // AssociatedParts
            // 
            AssociatedParts.BackColor = SystemColors.ScrollBar;
            AssociatedParts.Columns.AddRange(new ColumnHeader[] { PartIDAssoc, NameAssoc, InventoryAssoc, PriceAssoc, MinAssoc, MaxAssoc });
            AssociatedParts.Location = new Point(407, 328);
            AssociatedParts.Name = "AssociatedParts";
            AssociatedParts.Size = new Size(480, 199);
            AssociatedParts.TabIndex = 50;
            AssociatedParts.UseCompatibleStateImageBehavior = false;
            AssociatedParts.View = View.Details;
            // 
            // PartMaxAll
            // 
            PartMaxAll.Text = "Max";
            PartMaxAll.TextAlign = HorizontalAlignment.Center;
            PartMaxAll.Width = 76;
            // 
            // PartMinAll
            // 
            PartMinAll.Text = "Min";
            PartMinAll.TextAlign = HorizontalAlignment.Center;
            PartMinAll.Width = 80;
            // 
            // PartPriceAll
            // 
            PartPriceAll.Text = "Price";
            PartPriceAll.TextAlign = HorizontalAlignment.Center;
            PartPriceAll.Width = 80;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(637, 545);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(80, 30);
            DeleteProduct.TabIndex = 55;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // PartInventoryAll
            // 
            PartInventoryAll.Text = "Inventory";
            PartInventoryAll.TextAlign = HorizontalAlignment.Center;
            PartInventoryAll.Width = 80;
            // 
            // PartIDAll
            // 
            PartIDAll.Text = "Part ID";
            PartIDAll.Width = 80;
            // 
            // AllCandidateParts
            // 
            AllCandidateParts.BackColor = SystemColors.ScrollBar;
            AllCandidateParts.Columns.AddRange(new ColumnHeader[] { PartIDAll, PartNameAll, PartInventoryAll, PartPriceAll, PartMinAll, PartMaxAll });
            AllCandidateParts.Location = new Point(403, 69);
            AllCandidateParts.Name = "AllCandidateParts";
            AllCandidateParts.Size = new Size(480, 199);
            AllCandidateParts.TabIndex = 49;
            AllCandidateParts.UseCompatibleStateImageBehavior = false;
            AllCandidateParts.View = View.Details;
            // 
            // PartNameAll
            // 
            PartNameAll.Text = "Name";
            PartNameAll.TextAlign = HorizontalAlignment.Center;
            PartNameAll.Width = 80;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(112, 374);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(85, 23);
            MaxTextBox.TabIndex = 48;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(248, 374);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(85, 23);
            MinTextBox.TabIndex = 47;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(112, 333);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(170, 23);
            PriceTextBox.TabIndex = 46;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(112, 293);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(170, 23);
            InventoryTextBox.TabIndex = 45;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(112, 250);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(170, 23);
            NameTextBox.TabIndex = 44;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(112, 210);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(170, 23);
            IDTextBox.TabIndex = 43;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(214, 377);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 42;
            MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(71, 374);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 41;
            MaxLabel.Text = "Max";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(35, 333);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(68, 15);
            PriceLabel.TabIndex = 40;
            PriceLabel.Text = "Price / Cost";
            // 
            // PartInventoryLabel
            // 
            PartInventoryLabel.AutoSize = true;
            PartInventoryLabel.Location = new Point(46, 293);
            PartInventoryLabel.Name = "PartInventoryLabel";
            PartInventoryLabel.Size = new Size(57, 15);
            PartInventoryLabel.TabIndex = 39;
            PartInventoryLabel.Text = "Inventory";
            // 
            // PartNameLabel
            // 
            PartNameLabel.AutoSize = true;
            PartNameLabel.Location = new Point(64, 253);
            PartNameLabel.Name = "PartNameLabel";
            PartNameLabel.Size = new Size(39, 15);
            PartNameLabel.TabIndex = 38;
            PartNameLabel.Text = "Name";
            // 
            // PartIDLabel
            // 
            PartIDLabel.AutoSize = true;
            PartIDLabel.Location = new Point(83, 213);
            PartIDLabel.Name = "PartIDLabel";
            PartIDLabel.Size = new Size(18, 15);
            PartIDLabel.TabIndex = 37;
            PartIDLabel.Text = "ID";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(18, 11);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(117, 21);
            TitleLabel.TabIndex = 36;
            TitleLabel.Text = "Modify Product";
            // 
            // PartsAssocLabel
            // 
            PartsAssocLabel.AutoSize = true;
            PartsAssocLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartsAssocLabel.Location = new Point(407, 304);
            PartsAssocLabel.Name = "PartsAssocLabel";
            PartsAssocLabel.Size = new Size(204, 17);
            PartsAssocLabel.TabIndex = 57;
            PartsAssocLabel.Text = "Parts Associated with this Product";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductsLabel.Location = new Point(407, 45);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(116, 17);
            ProductsLabel.TabIndex = 58;
            ProductsLabel.Text = "All candidate Parts";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 587);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsAssocLabel);
            Controls.Add(CancelProduct);
            Controls.Add(SaveProduct);
            Controls.Add(AddPart);
            Controls.Add(SearchPartTextBox);
            Controls.Add(SearchParts);
            Controls.Add(AssociatedParts);
            Controls.Add(DeleteProduct);
            Controls.Add(AllCandidateParts);
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
            Name = "ModifyProduct";
            ShowIcon = false;
            Text = "ModifyProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelProduct;
        private Button SaveProduct;
        private Button AddPart;
        private TextBox SearchPartTextBox;
        private Button SearchParts;
        private ColumnHeader MaxAssoc;
        private ColumnHeader MinAssoc;
        private ColumnHeader PriceAssoc;
        private ColumnHeader InventoryAssoc;
        private ColumnHeader NameAssoc;
        private ColumnHeader PartIDAssoc;
        private ListView AssociatedParts;
        private ColumnHeader PartMaxAll;
        private ColumnHeader PartMinAll;
        private ColumnHeader PartPriceAll;
        private Button DeleteProduct;
        private ColumnHeader PartInventoryAll;
        private ColumnHeader PartIDAll;
        private ListView AllCandidateParts;
        private ColumnHeader PartNameAll;
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
        private Label TitleLabel;
        private Label PartsAssocLabel;
        private Label ProductsLabel;
    }
}