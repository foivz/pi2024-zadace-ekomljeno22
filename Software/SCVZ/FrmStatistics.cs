using SCVZ.Models;
using SCVZ.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
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

        private void pnlOverview_Paint(object sender, PaintEventArgs e)
        {
            // Add any custom painting code here if needed
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            // Add any custom painting code here if needed
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

        private void btnFilterAllTime_Click(object sender, EventArgs e)
        {
            // Add filter all-time functionality here
        }

        private void btnFilterThisWeek_Click(object sender, EventArgs e)
        {
            // Add filter this week functionality here
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
                    Console.WriteLine($"Displaying details for Menu ID: {menu.IdMeni}");

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
                        Console.WriteLine("No menu types available for this menu");
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
                        Console.WriteLine("No ratings available for this menu");
                        dgvRatings.DataSource = null;
                        txtAvg.Text = "No ratings";
                    }
                    int orderCount = OrderRepository.GetOrderCountForMenu(menu.IdMeni);
                    txtCount.Text = orderCount.ToString();
                }
                else
                {
                    Console.WriteLine("No menu details available");
                    dgvMenu.DataSource = null;
                    dgvMenuType.DataSource = null;
                    dgvRatings.DataSource = null;
                    txtAvg.Text = "No menu details";
                    txtCount.Text = "0";
                }
            }
        }

        private void btnSortOrderNbr_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            PokaziMenije();
        }

        private void btnSortTotalRating_Click(object sender, EventArgs e)
        {
            var sortedOrders = OrderRepository.GetOrdersSortedByMenuRating();
            dgvPreview.DataSource = sortedOrders;

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvPreview.Columns["IdNarudzba"].HeaderText = "Id";
            dgvPreview.Columns["DatumNarudzbe"].HeaderText = "Datum";
            dgvPreview.Columns["IdMeni"].HeaderText = "IdMeni";
            dgvPreview.Columns["IdZaposlenik"].HeaderText = "Zaposlenik";
            dgvPreview.Columns["IdStudent"].HeaderText = "Student";

            dgvPreview.Columns["IdZaposlenik"].Visible = false;
            dgvPreview.Columns["IdStudent"].Visible = false;
        }

        private void btnSortPreparationTime_Click(object sender, EventArgs e)
        {
            var sortedOrders = OrderRepository.GetOrdersSortedByPreparationTime();
            dgvPreview.DataSource = sortedOrders;

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvPreview.Columns["IdNarudzba"].HeaderText = "Id";
            dgvPreview.Columns["DatumNarudzbe"].HeaderText = "Datum";
            dgvPreview.Columns["IdMeni"].HeaderText = "IdMeni";
            dgvPreview.Columns["IdZaposlenik"].HeaderText = "Zaposlenik";
            dgvPreview.Columns["IdStudent"].HeaderText = "Student";

            dgvPreview.Columns["IdZaposlenik"].Visible = false;
            dgvPreview.Columns["IdStudent"].Visible = false;
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

        private void txtAvg_TextChanged(object sender, EventArgs e)
        {

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
                    GeneratePdfReport(filePath);
                }
            }
        }

        private void GeneratePdfReport(string filePath)
        {
            int width = 850;
            int height = 1100;

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);

                    Font titleFont = new Font("Arial", 20, FontStyle.Bold);

                    graphics.DrawString("Student Report", titleFont, Brushes.Black, new PointF(300, 30));
                    float yOffset = 80;
                    DrawStudentInformation(graphics, yOffset);

                    if (yOffset + dgvDetails.Rows.Count * 20 + 100 > height)
                    {
                        graphics.DrawString("Continued on Next Page...", new Font("Arial", 12), Brushes.Black, new PointF(30, height - 30));
                        graphics.ResetTransform();
                        bitmap.Save(filePath, ImageFormat.Png);
                        MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    yOffset += dgvPreview.Rows.Count * 20 + 100;
                    DrawStudentOrders(graphics, yOffset);

                    yOffset += dgvDetails.Rows.Count * 20 + 100;
                    DrawMenuItems(graphics, yOffset);

                    yOffset += dgvMenu.Rows.Count * 20 + 100;
                    DrawRatings(graphics, yOffset);
                }
                bitmap.Save(filePath, ImageFormat.Png);
                MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DrawStudentInformation(Graphics graphics, float yOffset)
        {
            graphics.DrawString("Student Information", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvPreview, yOffset, 30);
        }

        private void DrawStudentOrders(Graphics graphics, float yOffset)
        {
            graphics.DrawString("Student Orders", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvDetails, yOffset, 30);
        }

        private void DrawMenuItems(Graphics graphics, float yOffset)
        {
            graphics.DrawString("Menu Items", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvMenu, yOffset, 30);
        }

        private void DrawRatings(Graphics graphics, float yOffset)
        {
            graphics.DrawString("Ratings", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvRatings, yOffset, 30);
        }


        private float DrawDataGridView(Graphics graphics, DataGridView dgv, float yOffset, float xOffset)
        {
            if (dgv == null)
            {
                throw new ArgumentNullException(nameof(dgv), "DataGridView cannot be null.");
            }

            Font font = new Font("Arial", 10);
            float cellHeight = 20;

            Pen gridPen = new Pen(Brushes.Black, 1);

            float[] columnWidths = new float[dgv.ColumnCount];
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    float maxWidth = graphics.MeasureString(dgv.Columns[i].HeaderText, font).Width;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string cellValue = row.Cells[i].Value?.ToString() ?? "";
                            float width = graphics.MeasureString(cellValue, font).Width;
                            if (width > maxWidth)
                            {
                                maxWidth = width;
                            }
                        }
                    }
                    columnWidths[i] = Math.Max(maxWidth + 10, dgv.Columns[i].Width);
                }
            }
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    float columnWidth = columnWidths[i];
                    graphics.DrawString(dgv.Columns[i].HeaderText, font, Brushes.Black, new RectangleF(xOffset, yOffset, columnWidth, cellHeight), StringFormat.GenericDefault);

                    graphics.DrawLine(gridPen, new PointF(xOffset + columnWidth, yOffset), new PointF(xOffset + columnWidth, yOffset + dgv.Rows.Count * cellHeight));
                    xOffset += columnWidth;
                }
            }

            yOffset += cellHeight;

            for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
            {
                DataGridViewRow row = dgv.Rows[rowIndex];
                if (!row.IsNewRow)
                {
                    xOffset = 30;
                    float rowHeight = cellHeight;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (dgv.Columns[i].Visible)
                        {
                            float columnWidth = columnWidths[i];
                            string value = row.Cells[i].Value?.ToString() ?? string.Empty;

                            graphics.DrawString(value, font, Brushes.Black, new RectangleF(xOffset, yOffset, columnWidth, rowHeight), StringFormat.GenericDefault);

                            graphics.DrawLine(gridPen, new PointF(xOffset, yOffset + rowHeight), new PointF(xOffset + columnWidth, yOffset + rowHeight));

                            xOffset += columnWidth;
                        }
                    }
                    yOffset += rowHeight;
                }
            }
            return yOffset;
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
