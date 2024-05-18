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
        public FrmOrderHistory()
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

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            pnlLogo.BackColor = color;
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmStudentMain form1 = new FrmStudentMain();
            form1.Show();
            this.Close();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmStudentMain form1 = new FrmStudentMain();
            form1.Show();
            this.Close();
        }
    }
}
