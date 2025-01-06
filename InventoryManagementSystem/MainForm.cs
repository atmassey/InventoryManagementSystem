using System.Drawing.Text;
using System.Security.AccessControl;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private Inventory _inventory;
        public MainForm(Inventory inventory)
        {
            InitializeComponent();

            _inventory = inventory;
            var partList = new BindingSource();
            partList.DataSource = _inventory.AllParts;
            partList.DataSource = partList;

            var productList = new BindingSource();
            productList.DataSource = _inventory.Products;
            productList.DataSource = productList;
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
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            Hide();
        }
        private void ModifyProduct_Click(Object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct();
            modifyProduct.Show();
            Hide();
        }

    }
}

