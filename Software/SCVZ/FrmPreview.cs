using SCVZ.Repositories;
using SCVZ.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SCVZ
{
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();

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
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmStaffMain form1 = new FrmStaffMain();
            form1.Show();
            this.Close();
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmStaffMain form1 = new FrmStaffMain();
            form1.Show();
            this.Close();
        }

        private void pnlFilters_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics form2 = new FrmStatistics();
            form2.Show();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
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

            dgvPreview.Columns["Lozinka"].Visible = false;
        }

        private void btnAllMeals_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            PokaziJela();
        }

        private void PokaziJela()
        {
            var jela = MealRepository.DajJela();
            dgvPreview.DataSource = jela;

            dgvPreview.Columns["IdJelo"].DisplayIndex = 0;
            dgvPreview.Columns["NazivJela"].DisplayIndex = 1;
            dgvPreview.Columns["OpisJela"].DisplayIndex = 2;
            dgvPreview.Columns["IdVrstaJela"].DisplayIndex = 3;
        }

        private void rboAppetizer_CheckedChanged(object sender, EventArgs e)
        {

            string sql = "SELECT J.* FROM Jelo J INNER JOIN VrstaJela V ON J.IdVrstaJela = V.IdVrstaJela WHERE V.IdVrstaJela = 1";

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

        private void UnosCSV(string csvFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
