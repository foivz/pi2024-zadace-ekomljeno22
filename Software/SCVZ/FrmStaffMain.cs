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

    public partial class FrmStaffMain : Form
    {
        private string enteredUsername;
        public FrmStaffMain(string enteredUsername)
        {
            InitializeComponent();

            imgLogo.MouseEnter += imgLogo_MouseEnter;
            imgLogo.MouseLeave += imgLogo_MouseLeave;
            imgBack.MouseEnter += imgLogo_MouseEnter;
            imgBack.MouseLeave += imgLogo_MouseLeave;
            imgHome.MouseEnter += imgLogo_MouseEnter;
            imgHome.MouseLeave += imgLogo_MouseLeave;

            this.enteredUsername = enteredUsername;
        }

        private void imgLogo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void imgLogo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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

        private void imgHome_Click(object sender, EventArgs e)
        {
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            FrmPreview form2 = new FrmPreview(enteredUsername);
            form2.Show();
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics form3 = new FrmStatistics(enteredUsername);
            form3.Show();
            this.Close();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            FrmAddOrder form4 = new FrmAddOrder(enteredUsername);
            form4.Show();
        }

        private void FrmStaffMain_Load(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            PokaziNarudzbe();
        }

        private void PokaziNarudzbe()
        {
            var orders = OrderRepository.DajNarudzbe();
            dgvPreview.DataSource = orders;

            dgvPreview.Columns["IdNarudzba"].HeaderText = "Id";
            dgvPreview.Columns["DatumNarudzbe"].HeaderText = "Datum";
            dgvPreview.Columns["IdZaposlenik"].HeaderText = "Zaposlenik";
            dgvPreview.Columns["IdStudent"].HeaderText = "Student";

            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvPreview.Columns["IdNarudzba"].DisplayIndex = 0;
            dgvPreview.Columns["DatumNarudzbe"].DisplayIndex = 1;
            dgvPreview.Columns["IdZaposlenik"].DisplayIndex = 2;
            dgvPreview.Columns["IdStudent"].DisplayIndex = 3;
        }
        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetails.DataSource = null;
            dgvStudent.DataSource = null;
            dgvMenu.DataSource = null;
            dgvStatus.DataSource = null;

            if (e.RowIndex >= 0)
            {
                Narudzbe order = (Narudzbe)dgvPreview.CurrentRow.DataBoundItem;

                if (order != null)
                {
                    Console.WriteLine($"Narudžba nađena: {order.IdNarudzba}, Menu ID: {order.IdMeni}, Student ID: {order.IdStudent}");

                    Meni menu = MenuRepository.DajMeni(order.IdMeni);
                    if (menu != null)
                    {
                        Console.WriteLine($"Menu nađen: {menu.IdMeni}");
                        dgvMenu.DataSource = new List<Meni> { menu };
                        foreach (DataGridViewColumn column in dgvMenu.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podaci o Meniju nedostupni");
                    }
                    if (menu != null)
                    {
                        dgvDetails.DataSource = menu.stavkeMenija;
                        foreach (DataGridViewColumn column in dgvDetails.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nema detalja o stavkeMenija");
                    }
                    Student student = StudentRepository.DajStudentaZaDGV(order.IdStudent.ToString());
                    if (student != null)
                    {
                        Console.WriteLine($"Student nađen: {student.Ime} {student.Prezime}");
                        dgvStudent.DataSource = new List<Student> { student };
                        foreach (DataGridViewColumn column in dgvStudent.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nema podataka o studentu.");
                    }
                    StatusNarudzbe status = OrderRepository.DajStatusNarudzbe(order.IdStatusNarudzbe);
                    if (status != null)
                    {
                        Console.WriteLine($"Status nađen: {status.Status}");
                        dgvStatus.DataSource = new List<StatusNarudzbe> { status };
                        foreach (DataGridViewColumn column in dgvStatus.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nema detalja o statusu");
                    }
                }
                else
                {
                    Console.WriteLine("Nema narudžbe");
                }
            }
            else
            {
                Console.WriteLine("Krivi indeks retka.");
            }
        }

        private void dgvPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Narudzbe selectedOrder = (Narudzbe)dgvPreview.Rows[e.RowIndex].DataBoundItem;

                if (selectedOrder != null)
                {
                    FrmChangeOrderStatus form3 = new FrmChangeOrderStatus(selectedOrder);
                    form3.ShowDialog();
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PokaziNarudzbe();
        }
    }
}
