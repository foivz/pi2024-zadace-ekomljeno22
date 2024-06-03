using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SCVZ.Repositories
{
    public class ReportGenerator
    {
        public void GeneratePdfReport(string filePath, string fileName, DataGridView dgvPreview, DataGridView dgvDetails, DataGridView dgvMenu, DataGridView dgvRatings, string avgText, string countText, DataGridViewRow selectedRow)
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
                    DrawMenuItems(graphics, yOffset, dgvMenu, selectedRow);
                }
                bitmap.Save(filePath, ImageFormat.Png);
                GenerateRatingsReport(filePath, fileName, dgvRatings);
                GenerateAvgCountReport(filePath, fileName, avgText, countText);
                MessageBox.Show("PNG izvještaj uspješno generiran!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GenerateRatingsReport(string filePath, string fileName, DataGridView dgvRatings)
        {
            int width = 850;
            int height = 1100;

            string directoryPath = Path.GetDirectoryName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_Ratings{fileExtension}";
            string newFilePath = Path.Combine(directoryPath, newFileName);

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);

                    Font titleFont = new Font("Arial", 20, FontStyle.Bold);

                    graphics.DrawString("Recenzije", titleFont, Brushes.Black, new PointF(300, 30));

                    float yOffset = 80;
                    DrawDataGridView(graphics, dgvRatings, yOffset, 30);
                }
                bitmap.Save(newFilePath, ImageFormat.Png);
            }
        }

        public void GenerateAvgCountReport(string filePath, string fileName, string avgText, string countText)
        {
            int width = 850;
            int height = 1100;

            string directoryPath = Path.GetDirectoryName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}1{fileExtension}";
            string newFilePath = Path.Combine(directoryPath, newFileName);

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);

                    Font titleFont = new Font("Arial", 20, FontStyle.Bold);

                    graphics.DrawString("Analiza menija", titleFont, Brushes.Black, new PointF(300, 30));

                    graphics.DrawString("Average:", new Font("Arial", 12), Brushes.Black, new PointF(30, 80));
                    graphics.DrawString(avgText, new Font("Arial", 12), Brushes.Black, new PointF(150, 80));

                    graphics.DrawString("Count:", new Font("Arial", 12), Brushes.Black, new PointF(30, 130));
                    graphics.DrawString(countText, new Font("Arial", 12), Brushes.Black, new PointF(150, 130));
                }
                bitmap.Save(newFilePath, ImageFormat.Png);
            }
        }
        private void DrawStudentOrders(Graphics graphics, float yOffset, DataGridView dgvDetails)
        {
            graphics.DrawString("Studentske narudžbe", new Font("Arial", 15), Brushes.Black, new PointF(30, yOffset));
            yOffset += 30;
            DrawDataGridView(graphics, dgvDetails, yOffset, 30);
        }

        private void DrawMenuItems(Graphics graphics, float yOffset, DataGridView dgvMenu, DataGridViewRow selectedRow)
        {

            if (selectedRow != null)
            {
                int cellWidth = 150;
                int cellHeight = 30;
                PointF tableStartPoint = new PointF(30, yOffset + 30);

                string[] customHeaders = {"Id", "Cijena", "Vrsta", "Poklon bodovi", "Vrijeme pripreme"};

                for (int i = 0; i < customHeaders.Length; i++)
                {
                    PointF headerPosition = new PointF(tableStartPoint.X + i * cellWidth, tableStartPoint.Y);

                    string columnHeader = customHeaders[i];
                    graphics.DrawString(columnHeader, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, headerPosition.X + 5, headerPosition.Y + 5);
                }
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    PointF cellPosition = new PointF(tableStartPoint.X + i * cellWidth, tableStartPoint.Y + cellHeight);

                    graphics.DrawRectangle(Pens.Black, cellPosition.X, cellPosition.Y, cellWidth, cellHeight);

                    string cellContent = selectedRow.Cells[i].Value.ToString();
                    graphics.DrawString(cellContent, new Font("Arial", 12), Brushes.Black, cellPosition.X + 5, cellPosition.Y + 5);
                }
            }
        }

        public void DrawDataGridView(Graphics graphics, DataGridView dgv, float yOffset, float xOffset)
        {
            if (dgv == null)
            {
                throw new ArgumentNullException(nameof(dgv), "DataGridView cannot be null");
            }

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font cellFont = new Font("Arial", 12);
            int cellWidth = 150;
            int cellHeight = 30;
            PointF tableStartPoint = new PointF(30, yOffset + 30);

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                PointF headerPosition = new PointF(tableStartPoint.X + i * cellWidth, tableStartPoint.Y);
                string columnHeader = dgv.Columns[i].HeaderText;
                graphics.DrawString(columnHeader, headerFont, Brushes.Black, headerPosition.X + 5, headerPosition.Y + 5);
            }
            for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
            {
                DataGridViewRow row = dgv.Rows[rowIndex];
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        PointF cellPosition = new PointF(tableStartPoint.X + i * cellWidth, tableStartPoint.Y + (rowIndex + 1) * cellHeight);

                        graphics.DrawRectangle(Pens.Black, cellPosition.X, cellPosition.Y, cellWidth, cellHeight);

                        string cellContent = row.Cells[i].Value?.ToString() ?? "";
                        graphics.DrawString(cellContent, cellFont, Brushes.Black, cellPosition.X + 5, cellPosition.Y + 5);
                    }
                }
            }
        }
    }
}
