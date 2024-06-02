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
    public partial class FrmAddMealUpdate : Form
    {
        private int idJelo;

        public FrmAddMealUpdate(int idJelo)
        {
            InitializeComponent();
            this.idJelo = idJelo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcitajNaziveJelaComboBox()
        {
            try
            {
                var vrstaJelaList = MealTypeRepository.DajVrsteJela();
                cboMealType.DataSource = vrstaJelaList;
                cboMealType.DisplayMember = "NazivVrsteJela";
                cboMealType.ValueMember = "IdVrstaJela";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja podataka: {ex.Message}");
            }
        }
        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string updatedNazivJela = txtMealName.Text;
                var vrstaJela = cboMealType.SelectedItem as VrsteJela;

                Jelo updatedJelo = new Jelo
                {
                    IdJelo = idJelo,
                    NazivJela = updatedNazivJela,
                    IdVrstaJela = (int)cboMealType.SelectedValue
                };
                MealRepository.AzurirajJelo(updatedJelo);

                MessageBox.Show("Jelo uspješno ažurirano!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Neuspješno ažuriranje jela. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmAddMealUpdate_Load(object sender, EventArgs e)
        {
            txtMealId.Text = idJelo.ToString();
            UcitajNaziveJelaComboBox();
        }
    }
}
