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
            components = new System.ComponentModel.Container();
            CancelProduct = new Button();
            SaveProduct = new Button();
            AddPart = new Button();
            SearchPartTextBox = new TextBox();
            SearchParts = new Button();
            DeleteAssocPart = new Button();
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
            PartDataView = new DataGridView();
            AssocPartDataView = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)PartDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssocPartDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            SaveProduct.Click += SaveProduct_Click;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(803, 283);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(80, 30);
            AddPart.TabIndex = 53;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            AddPart.Click += AddAssocPart_Click;
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
            SearchParts.Click += SearchParts_Click;
            // 
            // DeleteAssocPart
            // 
            DeleteAssocPart.Location = new Point(637, 545);
            DeleteAssocPart.Name = "DeleteAssocPart";
            DeleteAssocPart.Size = new Size(80, 30);
            DeleteAssocPart.TabIndex = 55;
            DeleteAssocPart.Text = "Delete";
            DeleteAssocPart.UseVisualStyleBackColor = true;
            DeleteAssocPart.Click += DeleteAssocPart_Click;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(112, 374);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(85, 23);
            MaxTextBox.TabIndex = 48;
            MaxTextBox.TextChanged += MaxTextBox_TextChanged;
            MaxTextBox.Validating += MaxTextBox_Validating;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(248, 374);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(85, 23);
            MinTextBox.TabIndex = 47;
            MinTextBox.TextChanged += MinTextBox_TextChanged;
            MinTextBox.Validating += MinTextBox_Validating;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(112, 333);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(170, 23);
            PriceTextBox.TabIndex = 46;
            PriceTextBox.TextChanged += PriceTextBox_TextChanged;
            PriceTextBox.Validating += PriceTextBox_Validating;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(112, 293);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(170, 23);
            InventoryTextBox.TabIndex = 45;
            InventoryTextBox.TextChanged += InventoryTextBox_TextChanged;
            InventoryTextBox.Validating += InventoryTextBox_Validating;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(112, 250);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(170, 23);
            NameTextBox.TabIndex = 44;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Validating += NameTextBox_Validating;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
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
            // PartDataView
            // 
            PartDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartDataView.EnableHeadersVisualStyles = false;
            PartDataView.Location = new Point(412, 65);
            PartDataView.Name = "PartDataView";
            PartDataView.ReadOnly = true;
            PartDataView.RowHeadersVisible = false;
            PartDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartDataView.Size = new Size(480, 199);
            PartDataView.TabIndex = 59;
            // 
            // AssocPartDataView
            // 
            AssocPartDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssocPartDataView.EnableHeadersVisualStyles = false;
            AssocPartDataView.Location = new Point(412, 324);
            AssocPartDataView.Name = "AssocPartDataView";
            AssocPartDataView.ReadOnly = true;
            AssocPartDataView.RowHeadersVisible = false;
            AssocPartDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssocPartDataView.Size = new Size(480, 199);
            AssocPartDataView.TabIndex = 60;
            AssocPartDataView.RowStateChanged += AssocPartDataView_RowStateChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 587);
            Controls.Add(AssocPartDataView);
            Controls.Add(PartDataView);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsAssocLabel);
            Controls.Add(CancelProduct);
            Controls.Add(SaveProduct);
            Controls.Add(AddPart);
            Controls.Add(SearchPartTextBox);
            Controls.Add(SearchParts);
            Controls.Add(DeleteAssocPart);
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
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)PartDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssocPartDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelProduct;
        private Button SaveProduct;
        private Button AddPart;
        private TextBox SearchPartTextBox;
        private Button SearchParts;
        private Button DeleteAssocPart;
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
        private DataGridView PartDataView;
        private DataGridView AssocPartDataView;
        private ErrorProvider errorProvider1;
    }
}