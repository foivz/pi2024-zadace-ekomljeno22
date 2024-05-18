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
    public partial class FrmNewOrder : Form
    {
        public FrmNewOrder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
