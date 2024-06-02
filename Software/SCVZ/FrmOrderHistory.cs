﻿using SCVZ.Models;
using SCVZ.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmOrderHistory : Form
    {
        private string JMBAG { get; set; }
        public FrmOrderHistory(string jMBAG)
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

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmStudentMain frmStudentMain = new FrmStudentMain(JMBAG);
            frmStudentMain.Show();
            this.Close();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmStudentMain frmStudentMain = new FrmStudentMain(JMBAG);
            frmStudentMain.Show();
            this.Close();
        }

        private void PokaziNarudzbe()
        {
            var orders = OrderRepository.DajNarudzbePoJMBAG(JMBAG);
            dgvPreview.DataSource = orders;

            dgvPreview.Columns["IdNarudzba"].HeaderText = "Id";
            dgvPreview.Columns["DatumNarudzbe"].HeaderText = "Datum";
            dgvPreview.Columns["IdZaposlenik"].HeaderText = "Zaposlenik";
            dgvPreview.Columns["IdStudent"].HeaderText = "Student";
            dgvPreview.Columns["IdStatusNarudzbe"].HeaderText = "Status Narudžbe";

            dgvPreview.Columns["IdStudent"].Visible = false;
            dgvPreview.Columns["IdZaposlenik"].Visible = false;


            foreach (DataGridViewColumn column in dgvPreview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvPreview.Columns["IdNarudzba"].DisplayIndex = 0;
            dgvPreview.Columns["DatumNarudzbe"].DisplayIndex = 1;
            dgvPreview.Columns["IdMeni"].DisplayIndex = 2;
            dgvPreview.Columns["IdZaposlenik"].DisplayIndex = 3;
            dgvPreview.Columns["IdStudent"].DisplayIndex = 4;
        }

        private void PokaziMenije()
        {
            var orders = OrderRepository.DajNarudzbePoJMBAG(JMBAG);
            var uniqueMenuIds = orders.Select(order => order.IdMeni).Distinct();

            var menus = new List<Meni>();
            foreach (var menuId in uniqueMenuIds)
            {
                var menu = MenuRepository.DajMeni(menuId);
                if (menu != null)
                {
                    menus.Add(menu);
                }
            }

            dgvMenus.DataSource = menus;

            dgvMenus.Columns["IdMeni"].HeaderText = "Id";
            dgvMenus.Columns["CijenaMenija"].HeaderText = "Cijena";
            dgvMenus.Columns["IdVrstaMenija"].HeaderText = "Vrsta menija";
            dgvMenus.Columns["VrijednostPoklonBodova"].HeaderText = "Broj poklon bodova";
            dgvMenus.Columns["VrijemePripreme"].HeaderText = "Vrijeme pripreme";

            foreach (DataGridViewColumn column in dgvMenus.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void dgvMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int studentId = StudentRepository.DajStudentaByJMBAG(JMBAG).IdStudent;
                    int menuId = (int)dgvMenus.Rows[e.RowIndex].Cells["IdMeni"].Value;

                    Recenzije recenzije = RatingsRepository.DajRecenzijuZaMeni(menuId, studentId);

                    if (recenzije != null)
                    {
                        dgvRatings.DataSource = new List<Recenzije> { recenzije };

                        foreach (DataGridViewColumn column in dgvRatings.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        dgvRatings.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Greška: {ex.Message}");
                }
            }
        }
        private void FrmOrderHistory_Load(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            dgvMenus.DataSource = null;
            PokaziNarudzbe();
            PokaziMenije();
        }
        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Narudzbe order = (Narudzbe)dgvPreview.CurrentRow.DataBoundItem;

                Meni menu = MenuRepository.DajMeni(order.IdMeni);
                Console.WriteLine($"Pokazuju se detalji Narudzbe.Meni ID: {order.IdMeni}");

                if (menu != null)
                {
                    Console.WriteLine($"Pokazuju se detalji Menu ID: {menu.IdMeni}");
                    dgvDetails.DataSource = menu.stavkeMenija;

                    foreach (DataGridViewColumn column in dgvDetails.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                else
                {
                    Console.WriteLine("Nema dostupnih menija");
                    dgvDetails.DataSource = null;
                }
                StatusNarudzbe status = OrderRepository.DajStatusNarudzbe(order.IdStatusNarudzbe);
                if (status != null)
                {
                    Console.WriteLine($"Pokazuju se detalji StatusNarudzbe: {status.Status}");
                    dgvStatus.DataSource = new List<StatusNarudzbe> { status };

                    foreach (DataGridViewColumn column in dgvStatus.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                else
                {
                    Console.WriteLine("Nema dostupnih statusa narudžbe");
                    dgvStatus.DataSource = null;
                }
            }
        }

    }
}
