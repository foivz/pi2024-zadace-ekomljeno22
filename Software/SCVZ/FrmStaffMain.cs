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

            dgvPreview.Columns["IdNarudzba"].DisplayIndex = 0;
            dgvPreview.Columns["DatumNarudzbe"].DisplayIndex = 1;
            dgvPreview.Columns["IdMeni"].DisplayIndex = 2;
            dgvPreview.Columns["IdZaposlenik"].DisplayIndex = 3;
            dgvPreview.Columns["IdStudent"].DisplayIndex = 4;
        }

        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Narudzbe order = (Narudzbe)dgvPreview.CurrentRow.DataBoundItem;

                Meni menu = MenuRepository.DajMeni(order.IdMeni);
                Console.WriteLine($"Displaying details for Narudzbe.Meni ID: {order.IdMeni}");
                

                if (menu != null)
                {
                    Console.WriteLine($"Displaying details for Menu ID: {menu.IdMeni}");
                    dgvDetails.DataSource = menu.stavkeMenija;
                    Student student = new Student();
                    student= StudentRepository.DajStudenta(order.IdStudent.ToString());
                    Console.WriteLine(student.Ime + " " + student.Prezime);
                    dgvStudent.DataSource = new List<Student>{student};   
                }
                else
                {
                    Console.WriteLine("No menu details available");
                    dgvDetails.DataSource = null;
                }         
            }
        }
    }
}
