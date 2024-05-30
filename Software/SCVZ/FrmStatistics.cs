using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmStatistics : Form
    {
        private string enteredUsername;

        public FrmStatistics(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;

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

        private void pnlOverview_Paint(object sender, PaintEventArgs e)
        {
            // Add any custom painting code here if needed
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            // Add any custom painting code here if needed
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmStaffMain form1 = new FrmStaffMain(enteredUsername);
            form1.Show();
            this.Close();
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmStaffMain form1 = new FrmStaffMain(enteredUsername);
            form1.Show();
            this.Close();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void btnFilterAllTime_Click(object sender, EventArgs e)
        {
            // Add filter all-time functionality here
        }

        private void btnFilterThisWeek_Click(object sender, EventArgs e)
        {
            // Add filter this week functionality here
        }
    }
}
