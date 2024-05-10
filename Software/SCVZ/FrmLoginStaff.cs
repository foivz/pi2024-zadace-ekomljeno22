using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmLoginStaff : Form
    {

        public FrmLoginStaff()
        {
            InitializeComponent();

            imgLogo.MouseEnter += imgLogo_MouseEnter;
            imgLogo.MouseLeave += imgLogo_MouseLeave;
            imgBack.MouseEnter += imgLogo_MouseEnter;
            imgBack.MouseLeave += imgLogo_MouseLeave;
            imgHome.MouseEnter += imgLogo_MouseEnter;
            imgHome.MouseLeave += imgLogo_MouseLeave;
        }

        private void FrmLoginZaposlenici_Load(object sender, EventArgs e)
        {

            lblZaposlenici.BringToFront();
            pnlFooter.Dock = DockStyle.Bottom;
            pnlNav.Dock = DockStyle.Top;
            pnlLogo.Dock = DockStyle.Top;
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
            FrmMain form1 = new FrmMain();
            form1.Show();
            this.Close();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmViews form3 = new FrmViews();
            form3.Show();
            this.Close();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void imgLogo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void imgLogo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void imgLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#B9B9B9");
            pnlLogo.BackColor = color;
        }
    }
}
