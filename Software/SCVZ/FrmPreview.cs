using SCVZ.Repositories;
using SCVZ.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics form2 = new FrmStatistics(enteredUsername);
            form2.Show();
            this.Close();
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

            dgvPreview.Columns["IdKorisnik"].DisplayIndex = 0;
            dgvPreview.Columns["Ime"].DisplayIndex = 1;
            dgvPreview.Columns["Prezime"].DisplayIndex = 2;
            dgvPreview.Columns["Pozicija"].DisplayIndex = 3;

            dgvPreview.Columns["Lozinka"].Visible = true;
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

            dgvPreview.Columns["IdJelo"].DisplayIndex = 0;
            dgvPreview.Columns["NazivJela"].DisplayIndex = 1;
            dgvPreview.Columns["IdVrstaJela"].DisplayIndex = 2;
        }

        private void rboAppetizer_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "SELECT J.* FROM Jelo J INNER JOIN VrsteJela V ON J.IdVrstaJela = V.IdVrstaJela WHERE V.IdVrstaJela = 1";
            MealRepository.FiltrirajPremaPredjelima(sql);
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = openFileDialog.FileName;
                    UnosCSV(csvFilePath);
                }
            }
        }

        public static void UnosCSV(string csvFilePath)
        {
            try
            {
                using (var reader = new StreamReader(csvFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        var nazivJela = values[0];
                        var idVrstaJela = int.Parse(values[1]);

                        var jelo = new Jelo
                        {
                            NazivJela = nazivJela,
                            IdVrstaJela = idVrstaJela
                        };

                        MealRepository.DodajJelo(jelo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while importing CSV: {ex.Message}");
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            FrmAddStaff form3 = new FrmAddStaff();
            form3.Show();
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
                Console.WriteLine($"Processing IdMeni: {idMeni}");
            }
        }

        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPreview.CurrentRow?.DataBoundItem is Meni meni)
            {
                dgvDetails.DataSource = meni.stavkeMenija;
            }
            else
            {
                return;
            }
        }

    }
}
