using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddPart : Form
    {
        private Inventory _inventory;
        public AddPart(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
            int newPartId = _inventory.AllParts.Count + 1;
            IDTextBox.Text = newPartId.ToString();
            IDTextBox.Enabled = false;
            SaveButton.CausesValidation = true;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateChildren(ValidationConstraints.Enabled);
                if (InHouseRadio.Checked)
                {
                    Inhouse inHouse = new Inhouse();
                    inHouse.PartId = int.Parse(IDTextBox.Text);
                    inHouse.Name = NameTextBox.Text;
                    inHouse.Price = decimal.Parse(PriceTextBox.Text);
                    inHouse.InStock = int.Parse(InventoryTextBox.Text);
                    inHouse.Min = int.Parse(MinTextBox.Text);
                    inHouse.Max = int.Parse(MaxTextBox.Text);
                    inHouse.MachineId = int.Parse(MachineIDTextBox.Text);
                    if (inHouse.Min > inHouse.Max)
                    {
                        MessageBox.Show("Min must be less than Max");
                        return;
                    }
                    if (inHouse.InStock < inHouse.Min || inHouse.InStock > inHouse.Max)
                    {
                        MessageBox.Show("Inventory must be between Min and Max");
                        return;
                    }
                    _inventory.AddPart(inHouse);
                }
                else
                {
                    Outsourced outsourced = new Outsourced();
                    outsourced.PartId = int.Parse(IDTextBox.Text);
                    outsourced.Name = NameTextBox.Text;
                    outsourced.Price = decimal.Parse(PriceTextBox.Text);
                    outsourced.InStock = int.Parse(InventoryTextBox.Text);
                    outsourced.Min = int.Parse(MinTextBox.Text);
                    outsourced.Max = int.Parse(MaxTextBox.Text);
                    outsourced.CompanyName = MachineIDTextBox.Text;
                    _inventory.AddPart(outsourced);
                }
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
