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
    public partial class AddProduct : Form
    {
        private Inventory _inventory;
        public AddProduct(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            // TODO: Add product logic
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
    }
}
