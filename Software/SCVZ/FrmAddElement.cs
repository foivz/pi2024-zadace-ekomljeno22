using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmAddElement : Form
    {
        public FrmAddElement()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            FrmAddMeal form1 = new FrmAddMeal();
            form1.Show();
        }

        private void btnAddMenus_Click(object sender, EventArgs e)
            {
                FrmAddMenu form2 = new FrmAddMenu();
                form2.Show();
            }

        private void btnAddMoreMeals_Click(object sender, EventArgs e)
        {
            string directoryToOpen = @"C:\";
            Process.Start("explorer.exe", directoryToOpen);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
