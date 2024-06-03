using SCVZ.Repositories;
using SCVZ.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SCVZ
{
    public partial class FrmPreview : Form
    {
        private string enteredUsername;

        public FrmPreview(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;

            imgLogo.MouseEnter += cursorState_MouseEnter;
            imgLogo.MouseLeave += cursorState_MouseLeave;
            imgBack.MouseEnter += cursorState_MouseEnter;
            imgBack.MouseLeave += cursorState_MouseLeave;
            imgHome.MouseEnter += cursorState_MouseEnter;
            imgHome.MouseLeave += cursorState_MouseLeave;
        }

        private void cursorState_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cursorState_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmStaffMain form1 = new FrmStaffMain(enteredUsername);
            form1.Show();
            this.Close();
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmStaffMain form1 = new FrmStaffMain(enteredUsername);
            form1.Show();
            this.Close();
        }

        private void pnlFilters_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            OcistiDrugiDGV();
            PokaziZaposlenike();
        }

        private void PokaziZaposlenike()
        {
            var zaposlenici = StaffRepository.DajZaposlenike();
            dgvPreview.DataSource = zaposlenici;

            dgvPreview.Columns["IdKorisnik"].HeaderText = "Id";
            dgvPreview.Columns["Ime"].HeaderText = "Ime";
            dgvPreview.Columns["Prezime"].HeaderText = "Prezime";
            dgvPreview.Columns["Pozicija"].HeaderText = "Pozicija";

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvPreview.Columns["IdKorisnik"].DisplayIndex = 2;
            dgvPreview.Columns["Ime"].DisplayIndex = 3;
            dgvPreview.Columns["Prezime"].DisplayIndex = 4;
            dgvPreview.Columns["Pozicija"].DisplayIndex = 5;

            dgvPreview.Columns["Lozinka"].Visible = false;
            dgvPreview.Columns["IdKorisnik"].Visible = false;
        }

        private void btnAllMeals_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            OcistiDrugiDGV();
            PokaziJela();
        }

        private void OcistiDrugiDGV()
        {
            dgvDetails.DataSource = null;
        }

        private void PokaziJela()
        {
            var jela = MealRepository.DajJela();
            dgvPreview.DataSource = jela;

            dgvPreview.Columns["IdJelo"].HeaderText = "Id";
            dgvPreview.Columns["NazivJela"].HeaderText = "Jelo";
            dgvPreview.Columns["IdVrstaJela"].HeaderText = "Vrsta jela";


            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvPreview.Columns["IdJelo"].DisplayIndex = 0;
            dgvPreview.Columns["NazivJela"].DisplayIndex = 1;
            dgvPreview.Columns["IdVrstaJela"].DisplayIndex = 2;
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            FrmAddMeal frmAddMeal = new FrmAddMeal();
            frmAddMeal.FormClosed += FrmAddMeal_FormClosed;
            frmAddMeal.Show();
        }

        private void btnAddMenus_Click(object sender, EventArgs e)
        {
            FrmAddMenu frmAddMenu = new FrmAddMenu();
            frmAddMenu.FormClosed += FrmAddMenu_FormClosed;
            frmAddMenu.Show();
        }

        private void FrmAddMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvPreview.DataSource is List<Meni>)
            {
                PokaziMenije();
            }
        }
        private void FrmAddMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvPreview.DataSource is List<Jelo>)
            {
                PokaziJela();
            }
        }

        private void btnAddMoreMeals_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = openFileDialog.FileName;
                    MealRepository.UnosCSV(csvFilePath);
                    PokaziJela();
                }
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            FrmAddStaff frmAddStaff = new FrmAddStaff();
            frmAddStaff.FormClosed += FrmAddStaff_FormClosed;
            frmAddStaff.Show();
        }

        private void FrmAddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvPreview.DataSource is List<Zaposlenik>)
            {
                PokaziZaposlenike();
            }
        }

        private void btnAllMenus_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            PokaziMenije();
        }

        private void PokaziMenije()
        {
            var meni = MenuRepository.DajMenije();
            dgvPreview.DataSource = meni;

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

        private void dgvPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPreview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPreview.SelectedRows[0];

                if (selectedRow.DataBoundItem is Jelo)
                {
                    DialogResult dialogResult = MessageBox.Show("Želite li ažurirati odabrano jelo?", "Ažuriranje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idJelo = Convert.ToInt32(selectedRow.Cells["IdJelo"].Value);
                        FrmAddMealUpdate frmAddMeal = new FrmAddMealUpdate(idJelo);
                        frmAddMeal.ShowDialog();
                        PokaziJela();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (selectedRow.DataBoundItem is Zaposlenik)
                {
                    DialogResult deleteResult = MessageBox.Show("Želite li obrasati odabrano jelo?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (deleteResult == DialogResult.Yes)
                    {
                        var zaposlenikToDelete = (Zaposlenik)selectedRow.DataBoundItem;
                        StaffRepository.DeleteZaposlenik(zaposlenikToDelete);
                        PokaziZaposlenike();
                    }
                }
            }
        }
        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPreview.CurrentRow == null)
            {
                return;
            }
            if (dgvPreview.DataSource is List<Meni>)
            {
                if (dgvPreview.CurrentRow.DataBoundItem is Meni meni)
                {
                    dgvDetails.DataSource = meni.stavkeMenija;
                }
            }
            else if (dgvPreview.DataSource is List<Zaposlenik>)
            {
                if (dgvPreview.CurrentRow.DataBoundItem is Zaposlenik zaposlenik)
                {
                    dgvDetails.DataSource = zaposlenik.Pozicija;
                }
            }
            else if (dgvPreview.DataSource is List<Jelo>)
            {
                if (dgvPreview.CurrentRow.DataBoundItem is Jelo jelo)
                {
                    VrsteJela vrstaJela = MealTypeRepository.DajVrstaJela(jelo.IdVrstaJela);

                    List<VrsteJela> vrstaJelaList = new List<VrsteJela> { vrstaJela };

                    dgvDetails.DataSource = vrstaJelaList;
                }
            }
            else
            {
                dgvDetails.DataSource = null;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                ResetDataGridViewDataSource();
                return;
            }

            if (dgvPreview.DataSource is List<Jelo>)
            {
                List<Jelo> jela = (List<Jelo>)dgvPreview.DataSource;
                List<Jelo> filteredJela = jela.Where(j => j.NazivJela.ToLower().Contains(searchText)).ToList();
                dgvPreview.DataSource = filteredJela;
            }
            else if (dgvPreview.DataSource is List<Zaposlenik>)
            {
                List<Zaposlenik> zaposlenici = (List<Zaposlenik>)dgvPreview.DataSource;
                List<Zaposlenik> filteredZaposlenici = zaposlenici
                    .Where(z => z.Ime.ToLower().Contains(searchText) || z.Prezime.ToLower().Contains(searchText))
                    .ToList();
                dgvPreview.DataSource = filteredZaposlenici;
            }
            else if (dgvPreview.DataSource is List<Meni>)
            {
                List<Meni> meniji = (List<Meni>)dgvPreview.DataSource;
                List<Meni> filteredMeniji = meniji.Where(m => m.stavkeMenija.Any(j => j.NazivJela.ToLower().Contains(searchText))).ToList();
                dgvPreview.DataSource = filteredMeniji;
            }
        }
        private void ResetDataGridViewDataSource()
        {
            if (dgvPreview.DataSource is List<Zaposlenik>)
            {
                PokaziZaposlenike();
            }
            else if (dgvPreview.DataSource is List<Jelo>)
            {
                PokaziJela();
            }
            else if (dgvPreview.DataSource is List<Meni>)
            {
                PokaziMenije();
            }
            else
            {
                dgvPreview.DataSource = null;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetDataGridViewDataSource();
        }
    }
}
