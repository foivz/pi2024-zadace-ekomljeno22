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
    public partial class FrmChangeOrderStatus : Form
    {
        public Narudzbe SelectedOrder { get; set; }
        public FrmChangeOrderStatus(Narudzbe selectedOrder)
        {
            InitializeComponent();
            SelectedOrder = selectedOrder;
        }

        private void FrmChangeOrderStatus_Load(object sender, EventArgs e)
        {
            List<StatusNarudzbe> statuses = OrderRepository.DajSveStatusNarudzbe();
            cboStatus.DataSource = statuses;
            cboStatus.DisplayMember = "Status";
            cboStatus.ValueMember = "IdStatusNarudzbe";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                int newStatusId = (int)cboStatus.SelectedValue;

                OrderRepository.UpdateOrderStatus(SelectedOrder.IdNarudzba, newStatusId);

                this.Close();

                Refresh();
            }
        }

    }
}
