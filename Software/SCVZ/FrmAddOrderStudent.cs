using SCVZ.Models;
using SCVZ.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmAddOrderStudent : Form
    {
        private int nextIdOrder;

        public FrmAddOrderStudent()
        {
            InitializeComponent();
            PrikaziSljedecegId();
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
