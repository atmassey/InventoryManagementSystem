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
        private void SaveButton_Click(object sender, EventArgs e)
        {
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
    }
}
