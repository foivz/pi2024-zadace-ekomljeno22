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
                var vrstaJelaList = MealTypeRepository.DajVrstaJela();
                cboMealType.DataSource = vrstaJelaList;
                cboMealType.DisplayMember = "NazivVrsteJela";
                cboMealType.ValueMember = "IdVrstaJela";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
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
                MessageBox.Show($"An error occurred while retrieving the next available ID: {ex.Message}");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
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

                MessageBox.Show("Meal added successfully!");

                Ocisti();
                Close();
                PrikaziSljedecegId();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the meal: {ex.Message}");
            }
        }

        private void Ocisti()
        {
            txtMealName.Text = string.Empty;
            cboMealType.SelectedIndex = -1;
            PrikaziSljedecegId();
        }

        private void txtMealId_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

