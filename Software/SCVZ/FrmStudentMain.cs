using SCVZ.Models;
using SCVZ.Repositories;
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
    public partial class FrmStudentMain : Form
    {
        private string JMBAG { get; set; }
        public FrmStudentMain(string jMBAG)
        {
            InitializeComponent();

            imgLogo.MouseEnter += cursorState_MouseEnter;
            imgLogo.MouseLeave += cursorState_MouseLeave;
            imgBack.MouseEnter += cursorState_MouseEnter;
            imgBack.MouseLeave += cursorState_MouseLeave;
            imgHome.MouseEnter += cursorState_MouseEnter;
            imgHome.MouseLeave += cursorState_MouseLeave;

            JMBAG = jMBAG;
        }

        private void cursorState_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cursorState_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            DialogResult prviRezultat = MessageBox.Show(
                "Želite li se odjaviti?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (prviRezultat == DialogResult.Yes)
            {
                Odlogiraj();
            }
            else
            {
                DialogResult drugiRezultat = MessageBox.Show(
                    "Želite li izaći iz aplikacije?",
                    "Potvrda",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (drugiRezultat == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void Odlogiraj()
        {
            FrmMain form1 = new FrmMain();
            form1.Show();
            this.Close();
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlOrders_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#AFAFAF");
            pnlOrders.BackColor = color;
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#C5C5C5");
            pnlOrders.BackColor = color;
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }
        private void imgHome_Click(object sender, EventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void btnOrderStudent_Click(object sender, EventArgs e)
        {
            FrmAddOrderStudent form2 = new FrmAddOrderStudent(JMBAG);
            form2.Show();
        }


        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            FrmOrderHistory form3 = new FrmOrderHistory(JMBAG);
            form3.Show();
            this.Close();
        }

        private void FrmStudentMain_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            dgvStudentOrders.DataSource = null;
            PokaziSadasnjeNarudzbe();

            dgvPreview.DataSource = null;
            PokaziMenije();

            Student student = StudentRepository.DajStudentaByJMBAG(JMBAG);
            FillStudentTable(student);

            ConversionManager.ConvertPoklonBodoviToKupons(student);
            MenuRepository.IzračunajPoklonBodove(student.IdStudent);
        }

        private void FillStudentTable(Student student)
        {
            tblStudent.Controls.Clear();
            tblStudent.RowCount = 0;

            tblStudent.AutoSize = true;

            if (student != null)
            {
                AddRowToTable("Ime", student.Ime);
                AddRowToTable("Prezime", student.Prezime);
                AddRowToTable("JMBAG", student.JMBAG);
                AddRowToTable("Poklon bodovi", student.BrojPoklonBodova.ToString());
                AddRowToTable("Kuponi", student.BrojKupona.ToString());

                tblStudent.AutoSize = true;
                tblStudent.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            }
            else
            {
                MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRowToTable(string label, string value)
        {
            tblStudent.RowCount++;
            var lblProperty = new Label
            {
                Text = label,
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Blue,
                Padding = new Padding(5)
            };

            var lblValue = new Label
            {
                Text = value,
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Padding = new Padding(5)
            };
            tblStudent.Controls.Add(lblProperty, 0, tblStudent.RowCount - 1);
            tblStudent.Controls.Add(lblValue, 1, tblStudent.RowCount - 1);
        }

        private void PokaziSadasnjeNarudzbe()
        {
            var orders = OrderRepository.DajNarudzbePoJMBAG(JMBAG);
            var uniqueMeniIds = new HashSet<int>();

            foreach (var order in orders)
            {
                uniqueMeniIds.Add(order.IdMeni);
            }

            var uniqueMenis = new List<Meni>();
            foreach (var meniId in uniqueMeniIds)
            {
                var meni = MenuRepository.DajMeni(meniId);
                uniqueMenis.Add(meni);
            }

            dgvStudentOrders.DataSource = uniqueMenis;

            dgvStudentOrders.Columns["IdMeni"].HeaderText = "Id";
            dgvStudentOrders.Columns["CijenaMenija"].HeaderText = "Cijena";
            dgvStudentOrders.Columns["IdVrstaMenija"].HeaderText = "Vrsta menija";
            dgvStudentOrders.Columns["VrijednostPoklonBodova"].HeaderText = "Broj poklon bodova";
            dgvStudentOrders.Columns["VrijemePripreme"].HeaderText = "Vrijeme pripreme";

            foreach (DataGridViewColumn column in dgvStudentOrders.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvStudentOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Meni selectedMeni = (Meni)dgvStudentOrders.Rows[e.RowIndex].DataBoundItem;

                int meniId = selectedMeni.IdMeni;

                FrmStudentRating form4 = new FrmStudentRating(meniId, JMBAG);
                form4.Show();
            }
        }

        private void PokaziMenije()
        {
            var meni = MenuRepository.DajMenije();
            dgvPreview.DataSource = meni;

            dgvPreview.Columns["IdMeni"].HeaderText = "Id";
            dgvPreview.Columns["CijenaMenija"].HeaderText = "Cijena";
            dgvPreview.Columns["IdVrstaMenija"].HeaderText = "Vrsta menija";
            dgvPreview.Columns["VrijednostPoklonBodova"].HeaderText = "Broj poklon bodova";

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

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
            Meni meni = (Meni)dgvPreview.CurrentRow.DataBoundItem;
            dgvDetails.DataSource = meni.stavkeMenija;

            foreach (DataGridViewColumn column in dgvDetails.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
           // pnlLogo.Dock = DockStyle.Left;
        }
    }
}
