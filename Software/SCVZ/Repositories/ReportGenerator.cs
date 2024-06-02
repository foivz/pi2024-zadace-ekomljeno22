using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ.Repositories
{
    public class ReportGenerator
    {
        public void GeneratePdfReport(string filePath, DataGridView dgvPreview, DataGridView dgvDetails, DataGridView dgvMenu, DataGridView dgvRatings)
        {
            int width = 850;
            int height = 1100;

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);

                    Font titleFont = new Font("Arial", 20, FontStyle.Bold);

                    graphics.DrawString("Izvještaj o prehrani", titleFont, Brushes.Black, new PointF(300, 30));
                    float yOffset = 80;
                    DrawStudentInformation(graphics, yOffset, dgvPreview);

                    if (yOffset + dgvDetails.Rows.Count * 20 + 100 > height)
                    {
                        graphics.DrawString("Na drugoj stranici...", new Font("Arial", 12), Brushes.Black, new PointF(30, height - 30));
                        graphics.ResetTransform();
                        bitmap.Save(filePath, ImageFormat.Png);
                        MessageBox.Show("PNG izvještaj uspješno generiran!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    yOffset += dgvPreview.Rows.Count * 20 + 100;
                    DrawStudentOrders(graphics, yOffset, dgvDetails);

                    yOffset += dgvDetails.Rows.Count * 20 + 100;
                    DrawMenuItems(graphics, yOffset, dgvPreview);

                    yOffset += dgvMenu.Rows.Count * 20 + 100;
                    DrawRatings(graphics, yOffset, dgvPreview);
                }
                bitmap.Save(filePath, ImageFormat.Png);
                MessageBox.Show("PNG izvještaj uspješno generiran!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DrawStudentInformation(Graphics graphics, float yOffset, DataGridView dgvPreview)
        {
            graphics.DrawString("Informacije o studentima", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvPreview, yOffset, 30);
        }

        private void DrawStudentOrders(Graphics graphics, float yOffset, DataGridView dgvDetails)
        {
            graphics.DrawString("Studentske narudžbe", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvDetails, yOffset, 30);
        }

        private void DrawMenuItems(Graphics graphics, float yOffset, DataGridView dgvMenu)
        {
            graphics.DrawString("Stavke menija", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvMenu, yOffset, 30);
        }

        public void DrawRatings(Graphics graphics, float yOffset, DataGridView dgvRatings)
        {
            graphics.DrawString("Recenzije", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            yOffset = DrawDataGridView(graphics, dgvRatings, yOffset, 30);
        }


        public float DrawDataGridView(Graphics graphics, DataGridView dgv, float yOffset, float xOffset)
        {
            if (dgv == null)
            {
                throw new ArgumentNullException(nameof(dgv), "DataGridView ne može biti null");
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
    }
}
