using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Security.AccessControl;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private Inventory _inventory;
        public MainForm(Inventory inventory)
        {
            _inventory = inventory;
            InitializeComponent();
            InitializeViews();
        }

        private void InitializeViews()
        {
            DeletePart.Enabled = false;
            DeleteProduct.Enabled = false;
            ModifyPart.Enabled = false;
            ModifyProduct.Enabled = false;

            var partView = new BindingSource();
            partView.DataSource = _inventory.AllParts;
            PartsDataView.DataSource = partView;
            PartsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartsDataView.AutoResizeColumns();
            PartsDataView.AutoResizeRows();

            var productView = new BindingSource();
            productView.DataSource = _inventory.Products;
            ProductsDataView.DataSource = productView;
            ProductsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataView.AutoResizeColumns();
            ProductsDataView.AutoResizeRows();
        }
        
        private void PartsDataView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            ModifyPart.Enabled = true;
            DeletePart.Enabled = true;
        }
        private void ProductsDataView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            ModifyProduct.Enabled = true;
            DeleteProduct.Enabled = true;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
            // Exit the program if main form is closed by user because there is no longer and interface to interact with
            Environment.Exit(0);
        }
        private void AddPart_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart(_inventory);
            addPart.Show();
            Hide();
        }
        private void ModifyPart_Click(Object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PartsDataView.SelectedRows)
            {
                int partId = Convert.ToInt32(row.Cells[0].Value);
                Part part = _inventory.LookupPart(partId);
                ModifyPart modifyPart = new ModifyPart(_inventory, part);
                modifyPart.Show();
                Hide();
            }
        }
        private void SearchParts_Click(Object sender, EventArgs e)
        {
            int searchValue = Convert.ToInt32(SearchPartTextBox.Text);
            Part part = _inventory.LookupPart(searchValue);
            if (part == null)
            {
                MessageBox.Show("Part not found.");
                return;
            }
            PartsDataView.ClearSelection();
            foreach (DataGridViewRow row in PartsDataView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == searchValue)
                {
                    row.Selected = true;
                    break;
                }
            }

        }
        private void DeletePart_Click(Object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in PartsDataView.SelectedRows)
                {
                    {
                        // Delete the part from the inventory
                        PartsDataView.Rows.RemoveAt(row.Index);
                    }
                }
            }
            PartsDataView.ClearSelection();
            DeletePart.Enabled = false;
            ModifyPart.Enabled = false;
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(_inventory);
            addProduct.Show();
            Hide();
        }
        private void ModifyProduct_Click(Object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct(_inventory);
            modifyProduct.Show();
            Hide();
        }
        private void DeleteProduct_Click(Object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in ProductsDataView.SelectedRows)
                {
                    {
                        // Delete the product from the inventory
                        ProductsDataView.Rows.RemoveAt(row.Index);
                    }
                }
            }
            ProductsDataView.ClearSelection();
            DeleteProduct.Enabled = false;
            ModifyProduct.Enabled = false;
        }
        private void SearchProducts_Click(Object sender, EventArgs e)
        {
            int searchValue = Convert.ToInt32(SearchProductTextBox.Text);
            Product product = _inventory.LookupProduct(searchValue);
            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }
            ProductsDataView.ClearSelection();
            foreach (DataGridViewRow row in ProductsDataView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == searchValue)
                {
                    row.Selected = true;
                    break;
                }
            }
        }
    }
}

