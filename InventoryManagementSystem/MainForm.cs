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

        private void PartsList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


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
            ModifyPart modifyPart = new ModifyPart(_inventory);
            modifyPart.Show();
            Hide();
        }
        private void DeletePart_Click(Object sender, EventArgs e)
        {
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

    }
}

