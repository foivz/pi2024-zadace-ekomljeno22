using System;
using System.Windows.Forms;
using SCVZ.Models;
using SCVZ.Repositories;

namespace SCVZ
{
    public partial class FrmAddMenuToOrder : Form
    {
        public FrmAddOrder ParentForm { get; set; }
        public FrmAddOrderStudent ParentFormStudent { get; set; }

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
                    Console.WriteLine($"Učitavanje Menija: {idMeni}");
                }
            }
            else
            {
                MessageBox.Show("Nije pronađen ni jedan Meni.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"Dvaput kliknuta ćelija u indeksu: {e.RowIndex}");

            if (e.RowIndex >= 0 && e.RowIndex < dgvPreview.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvPreview.Rows[e.RowIndex];
                int selectedIdMeni = Convert.ToInt32(selectedRow.Cells["IdMeni"].Value);

                Console.WriteLine($"Odabrani Meni ID: {selectedIdMeni}");

                if (ParentFormStudent != null)
                {
                    ParentFormStudent.SetSelectedMenu(selectedIdMeni);
                }
                else if (ParentForm != null)
                {
                    ParentForm.SetSelectedMenu(selectedIdMeni);
                }

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
                    Console.WriteLine($"Prikazuju se rezultati za Meni ID: {meni.IdMeni}");
                    dgvDetails.DataSource = meni.stavkeMenija;
                }
                else
                {
                    Console.WriteLine("Nema detalja Menija");
                    dgvDetails.DataSource = null;
                }
            }
        }
    }

}