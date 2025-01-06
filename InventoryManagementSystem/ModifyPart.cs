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
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
        private void SavePart_Click(object sender, EventArgs e)
        {
            Part updatedPart = _part;
            updatedPart.Name = NameTextBox.Text;
            updatedPart.InStock = int.Parse(InventoryTextBox.Text);
            updatedPart.Price = decimal.Parse(PriceTextBox.Text);
            updatedPart.Max = int.Parse(MaxTextBox.Text);
            updatedPart.Min = int.Parse(MinTextBox.Text);
            if (InHouseRadio.Checked)
            {
                ((Inhouse) updatedPart).MachineId = int.Parse(MachineIDTextBox.Text);
            }
            else
            {
                ((Outsourced) updatedPart).CompanyName = MachineIDTextBox.Text;
            }
            _inventory.UpdatePart(_part.PartId, updatedPart);
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
    }
}
