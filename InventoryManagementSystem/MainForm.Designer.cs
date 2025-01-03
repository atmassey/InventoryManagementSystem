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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(1060, 499);
            Exit.Name = "Exit";
            Exit.Size = new Size(73, 34);
            Exit.TabIndex = 0;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(202, 319);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(80, 30);
            AddPart.TabIndex = 1;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            // 
            // ModifyPart
            // 
            ModifyPart.Location = new Point(288, 319);
            ModifyPart.Name = "ModifyPart";
            ModifyPart.Size = new Size(80, 30);
            ModifyPart.TabIndex = 2;
            ModifyPart.Text = "Modify";
            ModifyPart.UseVisualStyleBackColor = true;
            // 
            // DeletePart
            // 
            DeletePart.Location = new Point(374, 319);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(80, 30);
            DeletePart.TabIndex = 3;
            DeletePart.Text = "Delete";
            DeletePart.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(842, 325);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(80, 30);
            AddProduct.TabIndex = 4;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            // 
            // ModifyProduct
            // 
            ModifyProduct.Location = new Point(928, 325);
            ModifyProduct.Name = "ModifyProduct";
            ModifyProduct.Size = new Size(80, 30);
            ModifyProduct.TabIndex = 5;
            ModifyProduct.Text = "Modify";
            ModifyProduct.UseVisualStyleBackColor = true;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(1014, 325);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(80, 30);
            DeleteProduct.TabIndex = 6;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // SearchParts
            // 
            SearchParts.Location = new Point(405, 58);
            SearchParts.Name = "SearchParts";
            SearchParts.Size = new Size(60, 25);
            SearchParts.TabIndex = 7;
            SearchParts.Text = "Search";
            SearchParts.UseVisualStyleBackColor = true;
            // 
            // SearchProducts
            // 
            SearchProducts.Location = new Point(862, 60);
            SearchProducts.Name = "SearchProducts";
            SearchProducts.Size = new Size(60, 25);
            SearchProducts.TabIndex = 8;
            SearchProducts.Text = "Search";
            SearchProducts.UseVisualStyleBackColor = true;
            // 
            // SearchPartTextBox
            // 
            SearchPartTextBox.Location = new Point(471, 60);
            SearchPartTextBox.Name = "SearchPartTextBox";
            SearchPartTextBox.Size = new Size(180, 23);
            SearchPartTextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(928, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 545);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
    }
}
