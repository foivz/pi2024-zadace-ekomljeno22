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
        private Timer periodicTimer;
        private int currentOrderCount;

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

            periodicTimer = new Timer
            {
                Interval = 5000
            };
            periodicTimer.Tick += PeriodicTimer_Tick;
        }

        private void PeriodicTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine($"Periodic method executed at {DateTime.Now}");

            RefreshOrdersPeriodically();
        }

        private void RefreshOrdersPeriodically()
        {
            try
            {
                int newOrderCount = OrderRepository.GetOrderCount();
                if (newOrderCount != currentOrderCount)
                {
                    currentOrderCount = newOrderCount;
                    var newOrders = OrderRepository.DajNarudzbe();
                    dgvPreview.DataSource = null;
                    dgvPreview.DataSource = newOrders;
                    PokaziNarudzbe();

                    Console.WriteLine($"Orders refreshed. New count: {currentOrderCount}");
                }
                else
                {
                    Console.WriteLine("No changes in the number of orders.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error refreshing orders: {ex.Message}");
            }
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

        private void FrmStaffMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (periodicTimer != null)
            {
                periodicTimer.Stop();
                periodicTimer.Dispose();
            }
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
            LoadUser();
            RefreshOrdersPeriodically();
            periodicTimer.Start();
        }

        private void LoadUser()
        {
            var staff = StaffRepository.DajZaposlenikaByUsername(enteredUsername);
            tboUsername.Text = staff.KorisnickoIme;
            tboPosition.Text = staff.Pozicija;
        }

        private void PokaziNarudzbe()
        {
            dgvPreview.AutoGenerateColumns = false;

            dgvPreview.Columns.Clear();

            dgvPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdNarudzba",
                HeaderText = "Id",
                DataPropertyName = "IdNarudzba",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DatumNarudzbe",
                HeaderText = "Datum",
                DataPropertyName = "DatumNarudzbe",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdZaposlenik",
                HeaderText = "Zaposlenik",
                DataPropertyName = "IdZaposlenik",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdStudent",
                HeaderText = "Student",
                DataPropertyName = "IdStudent",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Narudzbe order = (Narudzbe)dgvPreview.CurrentRow.DataBoundItem;
                tboIdNarudzbe.Text = order.IdNarudzba.ToString();
                tboUkupniIznos.Text = order.KuponCijenaMenija.ToString();
                tboDatumNarudzbe.Text = order.DatumNarudzbe.ToString();

                if (order != null)
                {
                    Console.WriteLine($"Narudžba nađena: {order.IdNarudzba}, Menu ID: {order.IdMeni}, Student ID: {order.IdStudent}");

                    Meni menu = MenuRepository.DajMeni(order.IdMeni);
                    if (menu != null)
                    {
                        Console.WriteLine($"Meni nađen: {menu.IdMeni}");
                        tboCijenaMenija.Text = menu.CijenaMenija.ToString();
                        tboVrstaMenija.Text = menu.IdVrstaMenija.ToString();
                        tboVrijemePripreme.Text = menu.VrijemePripreme.ToString();
                        tboVrijednostPoklonBodova.Text = menu.VrijednostPoklonBodova.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Podaci o Meniju nedostupni");
                    }
                    if (menu != null)
                    {
                        lboJela.DataSource = menu.stavkeMenija;
                        lboJela.DisplayMember = "NazivJela";
                    }
                    else
                    {
                        Console.WriteLine("Nema detalja o stavkeMenija");
                    }
                    Student student = StudentRepository.DajStudentaZaDGV(order.IdStudent.ToString());
                    if (student != null)
                    {
                        Console.WriteLine($"Student nađen: {student.Ime} {student.Prezime}");
                        tboJMBAG.Text = student.JMBAG;
                        tboBrojKupona.Text = student.BrojKupona.ToString();
                        tboBrojPoklonBodova.Text = student.BrojPoklonBodova.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Nema podataka o studentu.");
                    }
                    StatusNarudzbe status = OrderRepository.DajStatusNarudzbe(order.IdStatusNarudzbe);
                    if (status != null)
                    {
                        Console.WriteLine($"Status nađen: {status.Status}");
                        tboStatusNarudzbe.Text = status.ToString();

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
    }
}
