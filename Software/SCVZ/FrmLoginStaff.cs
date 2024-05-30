using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SCVZ.Models;
using SCVZ.Repositories;

namespace SCVZ
{
    public partial class FrmLoginStaff : Form
    {
        private Zaposlenik loggedInStaff;

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
            Color color = ColorTranslator.FromHtml("#FCF24A");
            pnlFooter.BackColor = color;
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#D9D9D9");
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
            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();

            // Check Zaposlenik table for the entered username
            Zaposlenik staff = StaffRepository.DajZaposlenikaByUsername(enteredUsername);

            if (staff != null)
            {
                // Check if the entered password matches the stored password
                if (staff.CheckPassword(enteredPassword))
                {
                    // Zaposlenik login successful
                    loggedInStaff = staff;

                    // Proceed to main application form
                    FrmStaffMain form1 = new FrmStaffMain(enteredUsername); // Pass the enteredUsername
                    form1.Show();
                    this.Close();
                    return; // Exit the method early since login was successful
                }
            }

            // If no match is found in the Zaposlenik table or the password is incorrect
            MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

