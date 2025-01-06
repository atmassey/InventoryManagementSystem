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
    public partial class ModifyProduct : Form
    {
        private Inventory _inventory;
        private Product _product;
        public ModifyProduct(Inventory inventory, Product product)
        {
            InitializeComponent();
            _inventory = inventory;
            _product = product;
            IDTextBox.Text = product.ProductId.ToString();
            NameTextBox.Text = product.Name;
            InventoryTextBox.Text = product.InStock.ToString();
            PriceTextBox.Text = product.Price.ToString("C2");
            MaxTextBox.Text = product.Max.ToString();
            MinTextBox.Text = product.Min.ToString();
            SaveProduct.Enabled = false;
            DeleteProduct.Enabled = false;

            var partView = new BindingSource();
            partView.DataSource = _inventory.AllParts;
            PartDataView.DataSource = partView;
            PartDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartDataView.AutoResizeColumns();
            PartDataView.AutoResizeRows();

            var associatedPartView = new BindingSource();
            associatedPartView.DataSource = product.AssociatedParts;
            AssocPartDataView.DataSource = associatedPartView;
            AssocPartDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssocPartDataView.AutoResizeColumns();
            AssocPartDataView.AutoResizeRows();
        }
        private void EnableSaveProduct()
        {
            SaveProduct.Enabled = NameTextBox.Text != "" && InventoryTextBox.Text != "" && PriceTextBox.Text != "" && MaxTextBox .Text != "" && MinTextBox.Text != "";
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
    }
}
