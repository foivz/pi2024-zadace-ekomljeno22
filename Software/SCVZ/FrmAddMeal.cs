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
    public partial class FrmAddMeal : Form
    {
        public FrmAddMeal()
        {
            InitializeComponent();
            UcitajNaziveJelaComboBox();
            PrikaziSljedecegId();
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

        private void PrikaziSljedecegId()
        {
            try
            {
                int newId = MealRepository.DajSljedeceg();

                txtMealId.Text = newId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dohvaćanja ID-a: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                var vrstaJela = cboMealType.SelectedItem as VrsteJela;
                int newId = int.Parse(txtMealId.Text);

                var jelo = new Jelo
                {
                    IdJelo = newId,
                    NazivJela = txtMealName.Text,
                    IdVrstaJela = (int)cboMealType.SelectedValue
                };

                MealRepository.DodajJelo(jelo);

                MessageBox.Show("Jelo uspješno dodano!");

                Ocisti();
                Close();
                PrikaziSljedecegId();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja jela: {ex.Message}");
            }
        }

        private void Ocisti()
        {
            txtMealName.Text = string.Empty;
            cboMealType.SelectedIndex = -1;
            PrikaziSljedecegId();
        }
    }
}

