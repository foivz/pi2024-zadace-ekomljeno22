using SCVZ.Models;
using SCVZ.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace SCVZ
{
    public partial class FrmStatistics : Form
    {
        private string enteredUsername;

        public FrmStatistics(string enteredUsername)
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

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            PokaziMenije();
        }
        private void PokaziMenije()
        {
            var meniList = MenuRepository.DajMenije();
            dgvPreview.DataSource = meniList;

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvPreview.Columns["IdMeni"].HeaderText = "Id";
            dgvPreview.Columns["CijenaMenija"].HeaderText = "Cijena";
            dgvPreview.Columns["IdVrstaMenija"].HeaderText = "Id Vrste Menija";
            dgvPreview.Columns["VrijednostPoklonBodova"].HeaderText = "Vrijednost Poklon Bodova";
            dgvPreview.Columns["VrijemePripreme"].HeaderText = "Vrijeme Pripreme";
        }

        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Meni menu = (Meni)dgvPreview.CurrentRow.DataBoundItem;

                if (menu != null)
                {
                    Console.WriteLine($"Detalji za Meni ID: {menu.IdMeni}");

                    dgvMenu.DataSource = new List<Meni> { menu };
                    foreach (DataGridViewColumn column in dgvMenu.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    dgvMenu.Columns["IdMeni"].HeaderText = "Id";
                    dgvMenu.Columns["CijenaMenija"].HeaderText = "Cijena";
                    dgvMenu.Columns["IdVrstaMenija"].HeaderText = "Vrsta menija";
                    dgvMenu.Columns["VrijednostPoklonBodova"].HeaderText = "Poklon bodovi";
                    dgvMenu.Columns["VrijemePripreme"].HeaderText = "Vrijeme pripreme";

                    dgvDetails.DataSource = menu.stavkeMenija;
                    foreach (DataGridViewColumn column in dgvDetails.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    List<VrstaMenija> menuTypes = MenuTypeRepository.GetMenuTypesForMenu(menu.IdMeni);
                    if (menuTypes != null && menuTypes.Count > 0)
                    {
                        dgvMenuType.DataSource = menuTypes;
                        foreach (DataGridViewColumn column in dgvMenuType.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nema vrsta menija");
                        dgvMenuType.DataSource = null;
                    }
                    List<Recenzije> ratings = RatingsRepository.GetRatingsForMenu(menu.IdMeni);
                    if (ratings != null && ratings.Count > 0)
                    {
                        decimal totalRating = 0;
                        foreach (Recenzije rating in ratings)
                        {
                            totalRating += rating.Ocjena;
                        }
                        decimal averageRating = totalRating / ratings.Count;

                        txtAvg.Text = averageRating.ToString();

                        dgvRatings.DataSource = ratings;
                        foreach (DataGridViewColumn column in dgvRatings.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nema recenzija za ovaj Meni");
                        dgvRatings.DataSource = null;
                        txtAvg.Text = "0";
                    }
                    int orderCount = OrderRepository.GetOrderCountForMenu(menu.IdMeni);
                    txtCount.Text = orderCount.ToString();
                }
                else
                {
                    Console.WriteLine("Nema detalja menija");
                    dgvMenu.DataSource = null;
                    dgvMenuType.DataSource = null;
                    dgvRatings.DataSource = null;
                    txtAvg.Text = "0";
                    txtCount.Text = "0";
                }
            }
        }

        private void btnSortOrderNbr_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            SortMeniByOrderCount();
        }

        private void SortMeniByOrderCount()
        {
            try
            {
                List<Meni> meniList = MenuRepository.DajMenije();

                meniList.Sort((menu1, menu2) =>
                {
                    int orderCount1 = OrderRepository.GetOrderCountForMenu(menu1.IdMeni);
                    int orderCount2 = OrderRepository.GetOrderCountForMenu(menu2.IdMeni);
                    return orderCount2.CompareTo(orderCount1);
                });

                dgvPreview.DataSource = meniList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom sortiranja Menija po broju narudžbi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortTotalRating_Click(object sender, EventArgs e)
        {
            var sortedMeni = MenuRepository.GetMenusSortedByRating();
            dgvPreview.DataSource = sortedMeni;

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvPreview.Columns["IdMeni"].HeaderText = "Id";
            dgvPreview.Columns["CijenaMenija"].HeaderText = "Cijena";
            dgvPreview.Columns["IdVrstaMenija"].HeaderText = "IdVrsta";
            dgvPreview.Columns["VrijednostPoklonBodova"].HeaderText = "Vrijednost Bodova";
            dgvPreview.Columns["VrijemePripreme"].HeaderText = "Vrijeme Pripreme";
        }
        private void btnSortPreparationTime_Click(object sender, EventArgs e)
        {
            var sortedMenus = MenuRepository.GetMenusSortedByPreparationTime();
            dgvPreview.DataSource = sortedMenus;

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvPreview.Columns["IdMeni"].HeaderText = "Id";
            dgvPreview.Columns["CijenaMenija"].HeaderText = "Cijena";
            dgvPreview.Columns["IdVrstaMenija"].HeaderText = "IdVrsta";
            dgvPreview.Columns["VrijednostPoklonBodova"].HeaderText = "Vrijednost Bodova";
            dgvPreview.Columns["VrijemePripreme"].HeaderText = "Vrijeme Pripreme";
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Jelo selectedJelo = (Jelo)dgvDetails.Rows[e.RowIndex].DataBoundItem;

                if (selectedJelo != null)
                {
                    dgvMealType.DataSource = MealTypeRepository.GetVrsteJelaForJelo(selectedJelo.IdVrstaJela);

                    foreach (DataGridViewColumn column in dgvMealType.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files|*.png";
                saveFileDialog.Title = "Save Student Report";
                saveFileDialog.FileName = "StudentReport.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    string avgText = txtAvg.Text;
                    string countText = txtCount.Text;

                    string directoryPath = Path.GetDirectoryName(filePath);
                    string fileName = Path.GetFileName(filePath);
                    DataGridViewRow selectedRow = dgvMenu.CurrentRow;

                    ReportGenerator reportGenerator = new ReportGenerator();
                    reportGenerator.GeneratePdfReport(filePath, fileName, dgvPreview, dgvDetails, dgvMenu, dgvRatings, avgText, countText, selectedRow);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvDetails.DataSource = null;
            dgvMealType.DataSource = null;
            dgvMenu.DataSource = null;
            dgvMenuType.DataSource = null;
            dgvRatings.DataSource = null;
        }
    }
}
