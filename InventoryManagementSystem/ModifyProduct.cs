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
        public ModifyProduct()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
