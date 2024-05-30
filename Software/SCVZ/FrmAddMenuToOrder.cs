using System;
using System.Windows.Forms;
using SCVZ.Models;
using SCVZ.Repositories;

namespace SCVZ
{
    public partial class FrmAddMenuToOrder : Form
    {
        public FrmAddOrder ParentForm { get; set; }

        public FrmAddMenuToOrder()
        {
            InitializeComponent();
        }

        private void FrmAddMenuToOrder_Load(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            PokaziMenije();
        }

        private void PokaziMenije()
        {
            var meni = MenuRepository.DajMenije();
            dgvPreview.DataSource = meni;

            if (meni != null)
            {
                dgvPreview.Columns["IdMeni"].DisplayIndex = 0;
                dgvPreview.Columns["CijenaMenija"].DisplayIndex = 1;
                dgvPreview.Columns["IdVrstaMenija"].DisplayIndex = 2;
                dgvPreview.Columns["VrijednostPoklonBodova"].DisplayIndex = 3;

                foreach (DataGridViewRow row in dgvPreview.Rows)
                {
                    int idMeni = (int)row.Cells["IdMeni"].Value;
                    Console.WriteLine($"Processing IdMeni: {idMeni}");
                }
            }
            else
            {
                MessageBox.Show("No menus found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Debugging statement
            Console.WriteLine($"Double-clicked cell at row index: {e.RowIndex}");

            if (e.RowIndex >= 0 && e.RowIndex < dgvPreview.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvPreview.Rows[e.RowIndex];
                int selectedIdMeni = Convert.ToInt32(selectedRow.Cells["IdMeni"].Value);

                // Debugging statement
                Console.WriteLine($"Selected Menu ID: {selectedIdMeni}");

                ParentForm?.SetSelectedMenu(selectedIdMeni);

                this.Close();
            }
        }

        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Meni meni = dgvPreview.Rows[e.RowIndex].DataBoundItem as Meni;
                if (meni != null)
                {
                    // Debugging statement
                    Console.WriteLine($"Displaying details for Menu ID: {meni.IdMeni}");

                    dgvDetails.DataSource = meni.stavkeMenija;
                }
                else
                {
                    // Debugging statement
                    Console.WriteLine("No menu details available");

                    dgvDetails.DataSource = null;
                }
            }
        }
    }
}


