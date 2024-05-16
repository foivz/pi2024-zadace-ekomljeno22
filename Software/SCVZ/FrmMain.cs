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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            imgLogo.MouseEnter += imgLogo_MouseEnter;
            imgLogo.MouseLeave += imgLogo_MouseLeave;
            ImgBack.MouseEnter += imgLogo_MouseEnter;
            ImgBack.MouseLeave += imgLogo_MouseLeave;
            imgHome.MouseEnter += imgLogo_MouseEnter;
            imgHome.MouseLeave += imgLogo_MouseLeave;
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlFooter.Dock = DockStyle.Bottom;
            pnlNav.Dock = DockStyle.Top;
            pnlLogo.Dock = DockStyle.Top;

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlButtonContainer_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#B9B9B9");
            pnlButtonContainer.BackColor = color;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {

            FrmContact form2 = new FrmContact();
            form2.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin form3 = new FrmLogin();
            form3.Show();
            this.Hide();
        }

        private void imgLogo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void imgLogo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgHome_Click(object sender, EventArgs e)
        {

        }
    }
}
