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
            InitializeListViews();
        }

        private void InitializeListViews()
        {
            // Clear existing parts list
            PartList.Items.Clear();

            // Add items to the parts list
            foreach (var part in _inventory.AllParts)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                part.PartId.ToString(),
                part.Name,
                part.InStock.ToString(),
                part.Price.ToString("C2"),
                part.Min.ToString(),
                part.Max.ToString()
            });
                PartList.Items.Add(item);
            }

            // Clear existing products list
            ProductList.Items.Clear();

            // Add items to the products list
            foreach (var product in _inventory.Products)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                product.ProductId.ToString(),
                product.Name,
                product.InStock.ToString(),
                product.Price.ToString("C2"),
                product.Min.ToString(),
                product.Max.ToString()
            });
                ProductList.Items.Add(item);
            }
        }

        private void PartsList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Check if the item is a null item (all subitems are empty)
            bool isNullItem = true;
            foreach (ListViewItem.ListViewSubItem subItem in e.Item.SubItems)
            {
                if (!string.IsNullOrEmpty(subItem.Text))
                {
                    isNullItem = false;
                    break;
                }
            }

            // Set the background color based on whether it is a null item
            Color backgroundColor = isNullItem ? Color.Gray : Color.White;
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Draw the focus rectangle if the item is selected
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                e.DrawFocusRectangle();
            }

            // Draw the text for the item
            e.DrawText();
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

