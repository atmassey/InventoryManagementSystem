using System.Security.AccessControl;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            AddPart addPart = new AddPart();
            addPart.Show();
            Hide();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            Hide();
        }
    }
}

