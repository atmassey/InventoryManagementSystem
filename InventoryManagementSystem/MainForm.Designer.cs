namespace InventoryManagementSystem
{
    partial class MainForm
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
            Exit = new Button();
            AddPart = new Button();
            ModifyPart = new Button();
            DeletePart = new Button();
            AddProduct = new Button();
            ModifyProduct = new Button();
            DeleteProduct = new Button();
            SearchParts = new Button();
            SearchProducts = new Button();
            SearchPartTextBox = new TextBox();
            SearchProductTextBox = new TextBox();
            PartList = new ListBox();
            ProductList = new ListBox();
            PartsLabel = new Label();
            ProductsLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(979, 502);
            Exit.Name = "Exit";
            Exit.Size = new Size(73, 34);
            Exit.TabIndex = 0;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(252, 335);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(80, 30);
            AddPart.TabIndex = 1;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            // 
            // ModifyPart
            // 
            ModifyPart.Location = new Point(338, 335);
            ModifyPart.Name = "ModifyPart";
            ModifyPart.Size = new Size(80, 30);
            ModifyPart.TabIndex = 2;
            ModifyPart.Text = "Modify";
            ModifyPart.UseVisualStyleBackColor = true;
            // 
            // DeletePart
            // 
            DeletePart.Location = new Point(424, 335);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(80, 30);
            DeletePart.TabIndex = 3;
            DeletePart.Text = "Delete";
            DeletePart.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(800, 335);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(80, 30);
            AddProduct.TabIndex = 4;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            // 
            // ModifyProduct
            // 
            ModifyProduct.Location = new Point(886, 335);
            ModifyProduct.Name = "ModifyProduct";
            ModifyProduct.Size = new Size(80, 30);
            ModifyProduct.TabIndex = 5;
            ModifyProduct.Text = "Modify";
            ModifyProduct.UseVisualStyleBackColor = true;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(972, 335);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(80, 30);
            DeleteProduct.TabIndex = 6;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // SearchParts
            // 
            SearchParts.Location = new Point(258, 74);
            SearchParts.Name = "SearchParts";
            SearchParts.Size = new Size(60, 25);
            SearchParts.TabIndex = 7;
            SearchParts.Text = "Search";
            SearchParts.UseVisualStyleBackColor = true;
            // 
            // SearchProducts
            // 
            SearchProducts.Location = new Point(806, 76);
            SearchProducts.Name = "SearchProducts";
            SearchProducts.Size = new Size(60, 25);
            SearchProducts.TabIndex = 8;
            SearchProducts.Text = "Search";
            SearchProducts.UseVisualStyleBackColor = true;
            // 
            // SearchPartTextBox
            // 
            SearchPartTextBox.Location = new Point(324, 76);
            SearchPartTextBox.Name = "SearchPartTextBox";
            SearchPartTextBox.Size = new Size(180, 23);
            SearchPartTextBox.TabIndex = 9;
            // 
            // SearchProductTextBox
            // 
            SearchProductTextBox.Location = new Point(872, 76);
            SearchProductTextBox.Name = "SearchProductTextBox";
            SearchProductTextBox.Size = new Size(180, 23);
            SearchProductTextBox.TabIndex = 10;
            // 
            // PartList
            // 
            PartList.FormattingEnabled = true;
            PartList.ItemHeight = 15;
            PartList.Location = new Point(24, 118);
            PartList.Name = "PartList";
            PartList.Size = new Size(480, 199);
            PartList.TabIndex = 11;
            // 
            // ProductList
            // 
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 15;
            ProductList.Location = new Point(572, 118);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(480, 199);
            ProductList.TabIndex = 12;
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartsLabel.Location = new Point(24, 94);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(44, 21);
            PartsLabel.TabIndex = 13;
            PartsLabel.Text = "Parts";
            PartsLabel.Click += label1_Click;
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductsLabel.Location = new Point(572, 94);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(71, 21);
            ProductsLabel.TabIndex = 14;
            ProductsLabel.Text = "Products";
            ProductsLabel.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(227, 21);
            label3.TabIndex = 15;
            label3.Text = "Inventory Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 550);
            Controls.Add(label3);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(ProductList);
            Controls.Add(PartList);
            Controls.Add(SearchProductTextBox);
            Controls.Add(SearchPartTextBox);
            Controls.Add(SearchProducts);
            Controls.Add(SearchParts);
            Controls.Add(DeleteProduct);
            Controls.Add(ModifyProduct);
            Controls.Add(AddProduct);
            Controls.Add(DeletePart);
            Controls.Add(ModifyPart);
            Controls.Add(AddPart);
            Controls.Add(Exit);
            Name = "MainForm";
            Text = "Main Screen";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button AddPart;
        private Button ModifyPart;
        private Button DeletePart;
        private Button AddProduct;
        private Button ModifyProduct;
        private Button DeleteProduct;
        private Button SearchParts;
        private Button SearchProducts;
        private TextBox SearchPartTextBox;
        private TextBox SearchProductTextBox;
        private ListBox PartList;
        private ListBox ProductList;
        private Label PartsLabel;
        private Label ProductsLabel;
        private Label label3;
    }
}
