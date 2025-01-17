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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCVZ
{
    public partial class FrmStudentMain : Form
    {
        private string JMBAG { get; set; }
        private List<Narudzbe> allOrders;

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
            if (student != null)
            {
                tboIme.Text = student.Ime;
                tboPrezime.Text = student.Prezime;
                tboJMBAG.Text = student.JMBAG;
                tboPoklonBodovi.Text = student.BrojPoklonBodova.ToString();
                tboKuponi.Text = student.BrojKupona.ToString();
            }
            else
            {
                MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokaziSadasnjeNarudzbe()
        {
            allOrders = OrderRepository.DajNarudzbePoJMBAG(JMBAG); // Fetch all orders for the student

            var uniqueMeniIds = new HashSet<int>();
            foreach (var order in allOrders)
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
            var orders = OrderRepository.DajNarudzbePoJMBAG(JMBAG);
            dgvPreview.DataSource = orders;

            dgvPreview.Columns["IdNarudzba"].HeaderText = "Id";
            dgvPreview.Columns["IdMeni"].Visible = false;
            dgvPreview.Columns["IdZaposlenik"].Visible = false;
            dgvPreview.Columns["IdStudent"].Visible = false;
            dgvPreview.Columns["IdStatusNarudzbe"].Visible = false;
            dgvPreview.Columns["KuponCijenaMenija"].Visible = false;


            dgvPreview.Columns["DatumNarudzbe"].HeaderText = "Datum narudžbe";

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvPreview.Columns["IdNarudzba"].DisplayIndex = 0;
            dgvPreview.Columns["DatumNarudzbe"].DisplayIndex = 1;

            foreach (DataGridViewRow row in dgvPreview.Rows)
            {
                int idMeni = (int)row.Cells["IdMeni"].Value;
                Console.WriteLine($"Processing IdMeni: {idMeni}");
            }
        }
        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Narudzbe selectedNarudzba = (Narudzbe)dgvPreview.Rows[e.RowIndex].DataBoundItem;
                Meni meni = MenuRepository.DajMeni(selectedNarudzba.IdMeni);

                if (selectedNarudzba != null)
                {
                    tboDatumNarudzbe.Text = selectedNarudzba.DatumNarudzbe.ToString("yyyy-MM-dd HH:mm:ss");
                    tboUkupniIznos.Text = selectedNarudzba.KuponCijenaMenija.ToString("F2");
                    tboIdNarudzbe.Text = selectedNarudzba.IdNarudzba.ToString();

                    lboJela.DataSource = meni.stavkeMenija;
                    lboJela.DisplayMember = "NazivJela";
                }
                else
                {
                    tboDatumNarudzbe.Text = "No order found for this menu.";
                    tboUkupniIznos.Text = string.Empty;
                    tboIdNarudzbe.Text = string.Empty;
                }
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
