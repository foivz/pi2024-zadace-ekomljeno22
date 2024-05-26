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
using System.Net;
using System.Net.Mail;
using SCVZ.Models;
using SCVZ.Repositories;

namespace SCVZ
{
    public partial class FrmLoginStudent : Form
    {
        private Student loggedInStudent;

        public FrmLoginStudent()
        {
            InitializeComponent();

            imgLogo.MouseEnter += imgLogo_MouseEnter;
            imgLogo.MouseLeave += imgLogo_MouseLeave;
            imgBack.MouseEnter += imgLogo_MouseEnter;
            imgBack.MouseLeave += imgLogo_MouseLeave;
            imgHome.MouseEnter += imgLogo_MouseEnter;
            imgHome.MouseLeave += imgLogo_MouseLeave;
        }

        private void imgLogo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void imgLogo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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

        private void imgHome_Click(object sender, EventArgs e)
        {
            FrmMain form1 = new FrmMain();
            form1.Show();
            this.Close();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            FrmLogin form2 = new FrmLogin();
            form2.Show();
            this.Close();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scvz.unizg.hr/";
            Process.Start(url);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredJMBAG = txtJMBAG.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();

            Student student = StudentRepository.DajStudentaByJMBAG(enteredJMBAG);

            if (student != null)
            {
                if (student.CheckPassword(enteredPassword))
                {
                    loggedInStudent = student;

                    FrmStudentMain form1 = new FrmStudentMain();
                    form1.Show();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Incorrect JMBAG or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}

