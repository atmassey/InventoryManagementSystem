using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
            IDTextBox.Text = _product.ProductId.ToString();
            NameTextBox.Text = _product.Name;
            InventoryTextBox.Text = _product.InStock.ToString();
            PriceTextBox.Text = _product.Price.ToString();
            MaxTextBox.Text = _product.Max.ToString();
            MinTextBox.Text = _product.Min.ToString();
            SaveProduct.Enabled = false;
            DeleteAssocPart.Enabled = false;

            var partView = new BindingSource();
            partView.DataSource = _inventory.AllParts;
            PartDataView.DataSource = partView;
            PartDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartDataView.AutoResizeColumns();
            PartDataView.AutoResizeRows();

            var associatedPartView = new BindingSource();
            associatedPartView.DataSource = _product.AssociatedParts;
            AssocPartDataView.DataSource = associatedPartView;
            AssocPartDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssocPartDataView.AutoResizeColumns();
            AssocPartDataView.AutoResizeRows();
        }
        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            IDTextBox.Enabled = false;
            NameTextBox.SelectionStart = 0;
            PartDataView.ClearSelection();
            PartDataView.ColumnHeadersDefaultCellStyle.SelectionBackColor = PartDataView.ColumnHeadersDefaultCellStyle.BackColor;
            PartDataView.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            AssocPartDataView.ClearSelection();
            AssocPartDataView.ColumnHeadersDefaultCellStyle.SelectionBackColor = AssocPartDataView.ColumnHeadersDefaultCellStyle.BackColor;
            AssocPartDataView.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }
        private void AssocPartDataView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            DeleteAssocPart.Enabled = true;
        }
        private void EnableSaveProduct()
        {
            SaveProduct.Enabled = NameTextBox.Text != "" && InventoryTextBox.Text != "" && PriceTextBox.Text != "" && MaxTextBox.Text != "" && MinTextBox.Text != "";
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveProduct();
        }
        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveProduct();
        }
        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveProduct();
        }
        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveProduct();
        }
        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveProduct();
        }
        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                e.Cancel = true;
                NameTextBox.Focus();
                errorProvider1.SetError(NameTextBox, "Name is required");
                NameTextBox.BackColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NameTextBox, "");
                NameTextBox.BackColor = SystemColors.Window;
            }
        }
        private void InventoryTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InventoryTextBox.Text))
            {
                e.Cancel = true;
                InventoryTextBox.Focus();
                errorProvider1.SetError(InventoryTextBox, "Inventory is required");
                InventoryTextBox.BackColor = Color.Red;
            }
            else if (!int.TryParse(InventoryTextBox.Text, out int result))
            {
                e.Cancel = true;
                InventoryTextBox.Focus();
                errorProvider1.SetError(InventoryTextBox, "Inventory must be a number");
                InventoryTextBox.BackColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(InventoryTextBox, "");
                InventoryTextBox.BackColor = SystemColors.Window;
            }
        }
        private void PriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                e.Cancel = true;
                PriceTextBox.Focus();
                errorProvider1.SetError(PriceTextBox, "Price is required");
                PriceTextBox.BackColor = Color.Red;
            }
            else if (!decimal.TryParse(PriceTextBox.Text, out decimal result))
            {
                e.Cancel = true;
                PriceTextBox.Focus();
                errorProvider1.SetError(PriceTextBox, "Price must be a number");
                PriceTextBox.BackColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PriceTextBox, "");
                PriceTextBox.BackColor = SystemColors.Window;
            }
        }
        private void MaxTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaxTextBox.Text))
            {
                e.Cancel = true;
                MaxTextBox.Focus();
                errorProvider1.SetError(MaxTextBox, "Max is required");
                MaxTextBox.BackColor = Color.Red;
            }
            else if (!int.TryParse(MaxTextBox.Text, out int result))
            {
                e.Cancel = true;
                MaxTextBox.Focus();
                errorProvider1.SetError(MaxTextBox, "Max must be a number");
                MaxTextBox.BackColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(MaxTextBox, "");
                MaxTextBox.BackColor = SystemColors.Window;
            }
        }
        private void MinTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MinTextBox.Text))
            {
                e.Cancel = true;
                MinTextBox.Focus();
                errorProvider1.SetError(MinTextBox, "Min is required");
                MinTextBox.BackColor = Color.Red;
            }
            else if (!int.TryParse(MinTextBox.Text, out int result))
            {
                e.Cancel = true;
                MinTextBox.Focus();
                errorProvider1.SetError(MinTextBox, "Min must be a number");
                MinTextBox.BackColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(MinTextBox, "");
                MinTextBox.BackColor = SystemColors.Window;
            }
        }
        private void AddAssocPart_Click(object sender, EventArgs e)
        {
            if (PartDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to associate.");
                return;
            }
            foreach (DataGridViewRow row in PartDataView.SelectedRows)
            {
                int partId = Convert.ToInt32(row.Cells[0].Value);
                Part part = _inventory.LookupPart(partId);
                var alreadyAssociated = _product.LookupAssociatedPart(partId);
                if (alreadyAssociated != null)
                {
                    MessageBox.Show("Part is already associated with this product.");
                    return;
                }
                _product.AddAssociatedPart(part);
            }
            var associatedPartView = new BindingSource();
            associatedPartView.DataSource = _product.AssociatedParts;
            AssocPartDataView.DataSource = associatedPartView;
            AssocPartDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssocPartDataView.AutoResizeColumns();
            PartDataView.ClearSelection();
            AssocPartDataView.ClearSelection();
            EnableSaveProduct();
        }
        private void SearchParts_Click(object sender, EventArgs e)
        {
            try
            {
                int searchValue = Convert.ToInt32(SearchPartTextBox.Text);
                Part part = _inventory.LookupPart(searchValue);
                if (part == null)
                {
                    MessageBox.Show("Part not found.");
                    return;
                }
                PartDataView.ClearSelection();
                foreach (DataGridViewRow row in PartDataView.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == searchValue)
                    {
                        row.Selected = true;
                        break;
                    }
                }
                SearchPartTextBox.BackColor = SystemColors.Window;
                errorProvider1.Clear();
            }
            catch (FormatException)
            {
                var message = "Search Part ID must be a number.";
                MessageBox.Show(message);
                errorProvider1.SetError(SearchPartTextBox, message);
                SearchPartTextBox.Focus();
                SearchPartTextBox.BackColor = Color.Red;
            }
            catch (Exception)
            {
                MessageBox.Show("Part not found.");
            }
        }
        private void DeleteAssocPart_Click(object sender, EventArgs e)
        {
            if (AssocPartDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to disassociate.");
                return;
            }
            foreach (DataGridViewRow row in AssocPartDataView.SelectedRows)
            {
                int partId = Convert.ToInt32(row.Cells[0].Value);
                _product.RemoveAssociatedPart(partId);
            }
            var associatedPartView = new BindingSource();
            associatedPartView.DataSource = _product.AssociatedParts;
            AssocPartDataView.DataSource = associatedPartView;
            AssocPartDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssocPartDataView.AutoResizeColumns();
            AssocPartDataView.ClearSelection();
            EnableSaveProduct();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm(_inventory);
            mainForm.Show();
        }
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateChildren(ValidationConstraints.Enabled);
                _product.Name = NameTextBox.Text;
                _product.InStock = int.Parse(InventoryTextBox.Text);
                _product.Price = decimal.Parse(PriceTextBox.Text);
                _product.Max = int.Parse(MaxTextBox.Text);
                _product.Min = int.Parse(MinTextBox.Text);
                if (_product.Min > _product.Max)
                {
                    MessageBox.Show("Min must be less than Max.");
                    return;
                }
                if (_product.InStock < _product.Min || _product.InStock > _product.Max)
                {
                    MessageBox.Show("Inventory must be between Min and Max.");
                    return;
                }
                _inventory.UpdateProduct(_product.ProductId, _product);
                Close();
                MainForm mainForm = new MainForm(_inventory);
                mainForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save product {ex.Message}");
            }
        }
    }
}
