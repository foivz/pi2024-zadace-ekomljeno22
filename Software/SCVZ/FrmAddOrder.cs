using System;
using System.Windows.Forms;
using SCVZ.Models;
using SCVZ.Repositories;

namespace SCVZ
{
    public partial class FrmAddOrder : Form
    {
        private string enteredUsername;
        private int nextIdOrder;

        public FrmAddOrder()
        {
            InitializeComponent();
            PrikaziSljedecegId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboOrderMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtOrderPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOrderServer_TextChanged(object sender, EventArgs e)
        {
        }

        private void PrikaziSljedecegId()
        {
            try
            {
                nextIdOrder = OrderRepository.DajSljedeceg();
                txtOrderId.Text = nextIdOrder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the next available ID: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddMenuToOrder form1 = new FrmAddMenuToOrder();
            form1.ParentForm = this;
            form1.Show();
        }

        public void SetSelectedMenu(int menuId)
        {
            Meni selectedMenu = MenuRepository.DajMeni(menuId);
            txtIdMenu.Text = menuId.ToString();
            txtOrderPrice.Text = selectedMenu.CijenaMenija.ToString();
        }
    }
}



