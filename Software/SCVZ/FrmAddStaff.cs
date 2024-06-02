using DBLayer;
using SCVZ.Models;
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
    public partial class FrmAddStaff : Form
    {
        public FrmAddStaff()
        {
            InitializeComponent();
            UcitajPozicije();
            PrikaziSljedecegId();
        }

        private void PrikaziSljedecegId()
        {
            try
            {
                int newId = UserRepository.DajSljedeceg();

                txtStaffId.Text = newId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dohvaćanja sljedećeg dostupnog ID-a: {ex.Message}");
            }
        }

        private void UcitajPozicije()
        {
            try
            {
                var pozicijeList = PositionsRepository.DajPozicije();
                cboStaffPosition.DataSource = pozicijeList;
                cboStaffPosition.DisplayMember = "Pozicija";
                cboStaffPosition.ValueMember = "IdPozicija";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja podataka: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            string passcode = txtPassCode.Text.Trim();
            if (passcode != "12345")
            {
                MessageBox.Show("Netočna lozinka, zaposlenik se ne može dodati", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ime = txtStaffFirstName.Text;
            string prezime = txtStaffLastName.Text;
            string lozinka = txtStaffPassword.Text;
            string korisnickoIme = txtUsername.Text;
            string pozicija = cboStaffPosition.Text;

            Zaposlenik zaposlenik = new Zaposlenik
            {
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                KorisnickoIme = korisnickoIme,
                Pozicija = pozicija
            };

            try
            {
                UserRepository.DodajZaposlenika(zaposlenik);
                MessageBox.Show("Zaposlenik uspješno unesen!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

