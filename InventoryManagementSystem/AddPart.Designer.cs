namespace InventoryManagementSystem
{
    partial class AddPart
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
            InHouseRadio = new RadioButton();
            OutsourcedRadio = new RadioButton();
            PartIDLabel = new Label();
            PartNameLabel = new Label();
            PartInventoryLabel = new Label();
            PriceLabel = new Label();
            MaxLabel = new Label();
            MinLabel = new Label();
            IDTextBox = new TextBox();
            MachineIDLabel = new Label();
            NameTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            MinTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MachineIDTextBox = new TextBox();
            SaveButton = new Button();
            Cancel_Button = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(9, 7);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(69, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Add Part";
            // 
            // InHouseRadio
            // 
            InHouseRadio.AutoSize = true;
            InHouseRadio.Location = new Point(115, 9);
            InHouseRadio.Name = "InHouseRadio";
            InHouseRadio.Size = new Size(74, 19);
            InHouseRadio.TabIndex = 1;
            InHouseRadio.TabStop = true;
            InHouseRadio.Text = "In-House";
            InHouseRadio.UseVisualStyleBackColor = true;
            // 
            // OutsourcedRadio
            // 
            OutsourcedRadio.AutoSize = true;
            OutsourcedRadio.Location = new Point(215, 9);
            OutsourcedRadio.Name = "OutsourcedRadio";
            OutsourcedRadio.Size = new Size(87, 19);
            OutsourcedRadio.TabIndex = 2;
            OutsourcedRadio.TabStop = true;
            OutsourcedRadio.Text = "Outsourced";
            OutsourcedRadio.UseVisualStyleBackColor = true;
            // 
            // PartIDLabel
            // 
            PartIDLabel.AutoSize = true;
            PartIDLabel.Location = new Point(95, 64);
            PartIDLabel.Name = "PartIDLabel";
            PartIDLabel.Size = new Size(18, 15);
            PartIDLabel.TabIndex = 3;
            PartIDLabel.Text = "ID";
            // 
            // PartNameLabel
            // 
            PartNameLabel.AutoSize = true;
            PartNameLabel.Location = new Point(76, 104);
            PartNameLabel.Name = "PartNameLabel";
            PartNameLabel.Size = new Size(39, 15);
            PartNameLabel.TabIndex = 4;
            PartNameLabel.Text = "Name";
            // 
            // PartInventoryLabel
            // 
            PartInventoryLabel.AutoSize = true;
            PartInventoryLabel.Location = new Point(58, 144);
            PartInventoryLabel.Name = "PartInventoryLabel";
            PartInventoryLabel.Size = new Size(57, 15);
            PartInventoryLabel.TabIndex = 5;
            PartInventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(47, 184);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(68, 15);
            PriceLabel.TabIndex = 6;
            PriceLabel.Text = "Price / Cost";
            PriceLabel.Click += PriceLabel_Click;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(83, 225);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 7;
            MaxLabel.Text = "Max";
            MaxLabel.Click += label2_Click;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(226, 228);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 8;
            MinLabel.Text = "Min";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(124, 61);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(170, 23);
            IDTextBox.TabIndex = 9;
            // 
            // MachineIDLabel
            // 
            MachineIDLabel.AutoSize = true;
            MachineIDLabel.Location = new Point(46, 267);
            MachineIDLabel.Name = "MachineIDLabel";
            MachineIDLabel.Size = new Size(67, 15);
            MachineIDLabel.TabIndex = 10;
            MachineIDLabel.Text = "Machine ID";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(124, 101);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(170, 23);
            NameTextBox.TabIndex = 11;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(124, 144);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(170, 23);
            InventoryTextBox.TabIndex = 12;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(124, 184);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(170, 23);
            PriceTextBox.TabIndex = 13;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(260, 225);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(85, 23);
            MinTextBox.TabIndex = 14;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(124, 225);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(85, 23);
            MaxTextBox.TabIndex = 15;
            // 
            // MachineIDTextBox
            // 
            MachineIDTextBox.Location = new Point(124, 264);
            MachineIDTextBox.Name = "MachineIDTextBox";
            MachineIDTextBox.Size = new Size(170, 23);
            MachineIDTextBox.TabIndex = 16;
            MachineIDTextBox.TextChanged += Inventory_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(165, 347);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(80, 30);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Location = new Point(265, 347);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(80, 30);
            Cancel_Button.TabIndex = 18;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;
            Cancel_Button.Click += Cancel_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 399);
            Controls.Add(Cancel_Button);
            Controls.Add(SaveButton);
            Controls.Add(MachineIDTextBox);
            Controls.Add(MaxTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(MachineIDLabel);
            Controls.Add(IDTextBox);
            Controls.Add(MinLabel);
            Controls.Add(MaxLabel);
            Controls.Add(PriceLabel);
            Controls.Add(PartInventoryLabel);
            Controls.Add(PartNameLabel);
            Controls.Add(PartIDLabel);
            Controls.Add(OutsourcedRadio);
            Controls.Add(InHouseRadio);
            Controls.Add(TitleLabel);
            Name = "AddPart";
            ShowIcon = false;
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private RadioButton InHouseRadio;
        private RadioButton OutsourcedRadio;
        private Label PartIDLabel;
        private Label PartNameLabel;
        private Label PartInventoryLabel;
        private Label PriceLabel;
        private Label MaxLabel;
        private Label MinLabel;
        private TextBox IDTextBox;
        private Label MachineIDLabel;
        private TextBox NameTextBox;
        private TextBox InventoryTextBox;
        private TextBox PriceTextBox;
        private TextBox MinTextBox;
        private TextBox MaxTextBox;
        private TextBox MachineIDTextBox;
        private Button SaveButton;
        private Button Cancel_Button;
    }
}