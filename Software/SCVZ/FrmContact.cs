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
    public partial class FrmContact : Form
    {

        public FrmContact()
        {
            InitializeComponent();

            imgLogo.MouseEnter += imgLogo_MouseEnter;
            imgLogo.MouseLeave += imgLogo_MouseLeave;
            imgBack.MouseEnter += imgLogo_MouseEnter;
            imgBack.MouseLeave += imgLogo_MouseLeave;
            imgHome.MouseEnter += imgLogo_MouseEnter;
            imgHome.MouseLeave += imgLogo_MouseLeave;

            lblContact.BorderStyle = BorderStyle.None;
            lblAuthor.BorderStyle = BorderStyle.None;
            lblAuthorName.BorderStyle = BorderStyle.None;
            lblAuthorProblems.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.None;
        }

        private void FrmKontakt_Load(object sender, EventArgs e)
        {
            pnlFooter.Dock = DockStyle.Bottom;
            pnlNav.Dock = DockStyle.Top;
            pnlLogo.Dock = DockStyle.Top;

        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmMain FrmMain = new FrmMain();
            FrmMain.Show();
            this.Close();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmMain form1 = new FrmMain();
            form1.Show();
            this.Close();
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

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void pnlContact_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlContact.BackColor = color;
        }

        private void pnlAuthor_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlAuthor.BackColor = color;
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }
    }
}
