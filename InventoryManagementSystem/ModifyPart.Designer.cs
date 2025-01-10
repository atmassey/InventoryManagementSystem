namespace InventoryManagementSystem
{
    partial class ModifyPart
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
            CancelButton = new Button();
            SaveButton = new Button();
            MachineIDTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MinTextBox = new TextBox();
            PriceTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            NameTextBox = new TextBox();
            MachineIDLabel = new Label();
            IDTextBox = new TextBox();
            MinLabel = new Label();
            MaxLabel = new Label();
            PriceLabel = new Label();
            PartInventoryLabel = new Label();
            PartNameLabel = new Label();
            PartIDLabel = new Label();
            OutsourcedRadio = new RadioButton();
            InHouseRadio = new RadioButton();
            TitleLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(262, 346);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(80, 30);
            CancelButton.TabIndex = 37;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += Cancel_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(162, 346);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(80, 30);
            SaveButton.TabIndex = 36;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SavePart_Click;
            // 
            // MachineIDTextBox
            // 
            MachineIDTextBox.Location = new Point(138, 263);
            MachineIDTextBox.Name = "MachineIDTextBox";
            MachineIDTextBox.Size = new Size(170, 23);
            MachineIDTextBox.TabIndex = 35;
            MachineIDTextBox.TextChanged += MachineIDTextBox_TextChanged;
            MachineIDTextBox.Validating += MachineIDTextBox_Validating;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(138, 224);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(85, 23);
            MaxTextBox.TabIndex = 34;
            MaxTextBox.TextChanged += MaxTextBox_TextChanged;
            MaxTextBox.Validating += MaxTextBox_Validating;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(274, 224);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(85, 23);
            MinTextBox.TabIndex = 33;
            MinTextBox.TextChanged += MinTextBox_TextChanged;
            MinTextBox.Validating += MinTextBox_Validating;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(138, 183);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(170, 23);
            PriceTextBox.TabIndex = 32;
            PriceTextBox.TextChanged += PriceTextBox_TextChanged;
            PriceTextBox.Validating += PriceTextBox_Validating;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(138, 143);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(170, 23);
            InventoryTextBox.TabIndex = 31;
            InventoryTextBox.TextChanged += InventoryTextBox_TextChanged;
            InventoryTextBox.Validating += InventoryTextBox_Validating;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(138, 100);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(170, 23);
            NameTextBox.TabIndex = 30;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Validating += NameTextBox_Validating;
            // 
            // MachineIDLabel
            // 
            MachineIDLabel.AutoSize = true;
            MachineIDLabel.Location = new Point(43, 266);
            MachineIDLabel.Name = "MachineIDLabel";
            MachineIDLabel.Size = new Size(67, 15);
            MachineIDLabel.TabIndex = 29;
            MachineIDLabel.Text = "Machine ID";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(138, 60);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(170, 23);
            IDTextBox.TabIndex = 28;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(240, 227);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 27;
            MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(82, 227);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 26;
            MaxLabel.Text = "Max";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(44, 183);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(68, 15);
            PriceLabel.TabIndex = 25;
            PriceLabel.Text = "Price / Cost";
            // 
            // PartInventoryLabel
            // 
            PartInventoryLabel.AutoSize = true;
            PartInventoryLabel.Location = new Point(55, 143);
            PartInventoryLabel.Name = "PartInventoryLabel";
            PartInventoryLabel.Size = new Size(57, 15);
            PartInventoryLabel.TabIndex = 24;
            PartInventoryLabel.Text = "Inventory";
            // 
            // PartNameLabel
            // 
            PartNameLabel.AutoSize = true;
            PartNameLabel.Location = new Point(73, 103);
            PartNameLabel.Name = "PartNameLabel";
            PartNameLabel.Size = new Size(39, 15);
            PartNameLabel.TabIndex = 23;
            PartNameLabel.Text = "Name";
            // 
            // PartIDLabel
            // 
            PartIDLabel.AutoSize = true;
            PartIDLabel.Location = new Point(92, 63);
            PartIDLabel.Name = "PartIDLabel";
            PartIDLabel.Size = new Size(18, 15);
            PartIDLabel.TabIndex = 22;
            PartIDLabel.Text = "ID";
            // 
            // OutsourcedRadio
            // 
            OutsourcedRadio.AutoSize = true;
            OutsourcedRadio.Location = new Point(212, 8);
            OutsourcedRadio.Name = "OutsourcedRadio";
            OutsourcedRadio.Size = new Size(87, 19);
            OutsourcedRadio.TabIndex = 21;
            OutsourcedRadio.TabStop = true;
            OutsourcedRadio.Text = "Outsourced";
            OutsourcedRadio.UseVisualStyleBackColor = true;
            OutsourcedRadio.Click += OutsourcedRadio_CheckedChanged;
            // 
            // InHouseRadio
            // 
            InHouseRadio.AutoSize = true;
            InHouseRadio.Location = new Point(112, 8);
            InHouseRadio.Name = "InHouseRadio";
            InHouseRadio.Size = new Size(74, 19);
            InHouseRadio.TabIndex = 20;
            InHouseRadio.TabStop = true;
            InHouseRadio.Text = "In-House";
            InHouseRadio.UseVisualStyleBackColor = true;
            InHouseRadio.Click += InHouseRadio_CheckedChanged;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(6, 6);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(90, 21);
            TitleLabel.TabIndex = 19;
            TitleLabel.Text = "Modify Part";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 399);
            Controls.Add(CancelButton);
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
            Name = "ModifyPart";
            ShowIcon = false;
            Text = "Part";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private TextBox MachineIDTextBox;
        private TextBox MaxTextBox;
        private TextBox MinTextBox;
        private TextBox PriceTextBox;
        private TextBox InventoryTextBox;
        private TextBox NameTextBox;
        private Label MachineIDLabel;
        private TextBox IDTextBox;
        private Label MinLabel;
        private Label MaxLabel;
        private Label PriceLabel;
        private Label PartInventoryLabel;
        private Label PartNameLabel;
        private Label PartIDLabel;
        private RadioButton OutsourcedRadio;
        private RadioButton InHouseRadio;
        private Label TitleLabel;
        private ErrorProvider errorProvider1;
    }
}