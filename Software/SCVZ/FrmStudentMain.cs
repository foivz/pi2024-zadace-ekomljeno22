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
        public FrmStudentMain()
        {
            InitializeComponent();

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

        private void pnlDinner_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlDinner.BackColor = color;
        }

        private void pnlLunch_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlLunch.BackColor = color;
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
            FrmAddOrder form2 = new FrmAddOrder();
            form2.Show();
        }


        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            FrmOrderHistory form3 = new FrmOrderHistory();
            form3.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlMenuTitle.BackColor = color;
        }
    }
}
