﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPart : Form
    {
        private Inventory _inventory;
        private Part _part;
        public ModifyPart(Inventory inventory, Part part) 
            
        {
            InitializeComponent();
            _inventory = inventory;
            _part = part;
            IDTextBox.Text = _part.PartId.ToString();
            IDTextBox.Enabled = false;
            NameTextBox.Text = _part.Name;
            InventoryTextBox.Text = _part.InStock.ToString();
            PriceTextBox.Text = _part.Price.ToString();
            MaxTextBox.Text = _part.Max.ToString();
            MinTextBox.Text = _part.Min.ToString();
            if (_part is Inhouse inhouse)
            {
                InHouseRadio.Checked = true;
                MachineIDTextBox.Text = inhouse.MachineId.ToString();
            }
            else
            {
                OutsourcedRadio.Checked = true;
                MachineIDTextBox.Text = ((Outsourced) part).CompanyName;
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDLabel.Text = @"Machine ID";
        }
        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDLabel.Text = @"Company Name";
        }
        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                e.Cancel = true;
                NameTextBox.Focus();
                NameTextBox.BackColor = Color.Red;
                errorProvider1.SetError(NameTextBox, "Part name is required");
            }
            else
            {
                e.Cancel = false;
                NameTextBox.BackColor = SystemColors.Window;
                errorProvider1.SetError(NameTextBox, "");
            }
        }
        private void InventoryTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(InventoryTextBox.Text))
            {
                e.Cancel = true;
                InventoryTextBox.Focus();
                InventoryTextBox.BackColor = Color.Red;
                errorProvider1.SetError(InventoryTextBox, "Inventory is required");
            }
            else if (!int.TryParse(InventoryTextBox.Text, out _))
            {
                e.Cancel = true;
                InventoryTextBox.Focus();
                InventoryTextBox.BackColor = Color.Red;
                errorProvider1.SetError(InventoryTextBox, "Inventory must be a number");
            }
            else
            {
                e.Cancel = false;
                InventoryTextBox.BackColor = SystemColors.Window;
                errorProvider1.SetError(InventoryTextBox, "");
            }
        }
        private void PriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PriceTextBox.Text))
            {
                e.Cancel = true;
                PriceTextBox.Focus();
                PriceTextBox.BackColor = Color.Red;
                errorProvider1.SetError(PriceTextBox, "Price is required");
            }
            else if (!decimal.TryParse(PriceTextBox.Text, out _))
            {
                e.Cancel = true;
                PriceTextBox.Focus();
                PriceTextBox.BackColor = Color.Red;
                errorProvider1.SetError(PriceTextBox, "Price must be a number");
            }
            else
            {
                e.Cancel = false;
                PriceTextBox.BackColor = SystemColors.Window;
                errorProvider1.SetError(PriceTextBox, "");
            }
            }
        private void MinTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MinTextBox.Text))
            {
                e.Cancel = true;
                MinTextBox.Focus();
                MinTextBox.BackColor = Color.Red;
                errorProvider1.SetError(MinTextBox, "Min is required");
            }
            else if (!int.TryParse(MinTextBox.Text, out _))
            {
                e.Cancel = true;
                MinTextBox.Focus();
                MinTextBox.BackColor = Color.Red;
                errorProvider1.SetError(MinTextBox, "Min must be a number");
            }
            else
            {
                e.Cancel = false;
                MinTextBox.BackColor = SystemColors.Window;
                errorProvider1.SetError(MinTextBox, "");
            }
        }
        private void MaxTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MaxTextBox.Text))
            {
                e.Cancel = true;
                MaxTextBox.Focus();
                MaxTextBox.BackColor = Color.Red;
                errorProvider1.SetError(MaxTextBox, "Max is required");
            }
            else if (!int.TryParse(MaxTextBox.Text, out _))
            {
                e.Cancel = true;
                MaxTextBox.Focus();
                MaxTextBox.BackColor = Color.Red;
                errorProvider1.SetError(MaxTextBox, "Max must be a number");
            }
            else
            {
                e.Cancel = false;
                MaxTextBox.BackColor = SystemColors.Window;
                errorProvider1.SetError(MaxTextBox, "");
            }
        }
        private void MachineIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (InHouseRadio.Checked) {
                if (string.IsNullOrEmpty(MachineIDTextBox.Text))
                {
                    e.Cancel = true;
                    MachineIDTextBox.Focus();
                    MachineIDTextBox.BackColor = Color.Red;
                    errorProvider1.SetError(MachineIDTextBox, "Machine ID is required");
                }
                else if (!int.TryParse(MachineIDTextBox.Text, out _))
                {
                    e.Cancel = true;
                    MachineIDTextBox.Focus();
                    MachineIDTextBox.BackColor = Color.Red;
                    errorProvider1.SetError(MachineIDTextBox, "Machine ID must be a number");
                }
                else
                {
                    e.Cancel = false;
                    MachineIDTextBox.BackColor = SystemColors.Window;
                    errorProvider1.SetError(MachineIDTextBox, "");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(MachineIDTextBox.Text))
                {
                    e.Cancel = true;
                    MachineIDTextBox.Focus();
                    MachineIDTextBox.BackColor = Color.Red;
                    errorProvider1.SetError(MachineIDTextBox, "Company Name is required");
                }
                else
                {
                    e.Cancel = false;
                    MachineIDTextBox.BackColor = SystemColors.Window;
                    errorProvider1.SetError(MachineIDTextBox, "");
                }
            }
        }
        private void SavePart_Click(object sender, EventArgs e)
        {
            try {
                int min = int.Parse(MinTextBox.Text);
                int max = int.Parse(MaxTextBox.Text);
                int inStock = int.Parse(InventoryTextBox.Text);
                decimal price = decimal.Parse(PriceTextBox.Text);
                Part updatedPart;
                if (InHouseRadio.Checked)
                {
                    updatedPart = new Inhouse
                    {
                        PartId = _part.PartId,
                        Name = NameTextBox.Text,
                        Price = price,
                        InStock = inStock,
                        Min = min,
                        Max = max,
                        MachineId = int.Parse(MachineIDTextBox.Text)
                    };
                }
                else
                {
                    updatedPart = new Outsourced
                    {
                        PartId = _part.PartId,
                        Name = NameTextBox.Text,
                        Price = price,
                        InStock = inStock,
                        Min = min,
                        Max = max,
                        CompanyName = MachineIDTextBox.Text
                    };
                }
                if(min > max)
                {
                    MessageBox.Show("Min must be less than Max");
                    return;
                }
                if (inStock > max || inStock < min)
                {
                    MessageBox.Show("Inventory must be between Min and Max");
                    return;
                }
                _inventory.UpdatePart(_part.PartId, updatedPart);
                Close();
                MainForm mainForm = new MainForm(_inventory);
                mainForm.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
