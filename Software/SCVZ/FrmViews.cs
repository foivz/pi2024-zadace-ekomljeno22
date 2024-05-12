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
    public partial class FrmViews : Form
    {

        public FrmViews()
        {
            InitializeComponent();

            imgLogo.MouseEnter += imgLogo_MouseEnter;
            imgLogo.MouseLeave += imgLogo_MouseLeave;
            imgBack.MouseEnter += imgLogo_MouseEnter;
            imgBack.MouseLeave += imgLogo_MouseLeave;
            imgHome.MouseEnter += imgLogo_MouseEnter;
            imgHome.MouseLeave += imgLogo_MouseLeave;
            imgStaff.MouseEnter += imgLogo_MouseEnter;
            imgStaff.MouseLeave += imgLogo_MouseLeave;
            imgStudents.MouseEnter += imgLogo_MouseEnter;
            imgStudents.MouseLeave += imgLogo_MouseLeave;
        }

        private void FrmOdaberiPogled_Load(object sender, EventArgs e)
        {
            pnlFooter.Dock = DockStyle.Bottom;
            pnlNav.Dock = DockStyle.Top;
            pnlLogo.Dock = DockStyle.Top;
        }


        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmMain FrmMain = new FrmMain();
            FrmMain.Show();
            this.Close();
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmMain FrmMain = new FrmMain();
            FrmMain.Show();
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

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void imgStaff_Click(object sender, EventArgs e)
        {
            FrmLoginStaff form4 = new FrmLoginStaff();
            form4.Show();
            this.Close();
        }

        private void imgStudents_Click(object sender, EventArgs e)
        {
            FrmLoginStudents form5 = new FrmLoginStudents();
            form5.Show();
            this.Close();
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlStaff.BackColor = color;
        }

        private void pnlStaff_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlStudents.BackColor = color;
        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

    }
}
