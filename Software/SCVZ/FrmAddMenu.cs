using DBLayer;
using SCVZ.Models;
using SCVZ.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class FrmAddMenu : Form
    {
        private int nextIdMeni;

        public FrmAddMenu()
        {
            InitializeComponent();
            UcitajNaziveJelaComboBox();
            PrikaziSljedecegId();
        }

        private void UcitajNaziveJelaComboBox()
        {
            try
            {
                var jeloList = MealRepository.DajJela();

                // Filter meals by type for each combo box
                var mealType1 = 1; // Example type, replace with actual meal type IDs
                var mealType2 = 2; // Example type, replace with actual meal type IDs
                var mealType3 = 3; // Example type, replace with actual meal type IDs

                var mealsType1 = jeloList.Where(j => j.IdVrstaJela == mealType1).ToList();
                var mealsType2 = jeloList.Where(j => j.IdVrstaJela == mealType2).ToList();
                var mealsType3 = jeloList.Where(j => j.IdVrstaJela == mealType3).ToList();

                cboMeal01.DataSource = mealsType1;
                cboMeal01.DisplayMember = "NazivJela";
                cboMeal01.ValueMember = "IdJelo";

                cboMeal02.DataSource = mealsType2;
                cboMeal02.DisplayMember = "NazivJela";
                cboMeal02.ValueMember = "IdJelo";

                cboMeal03.DataSource = mealsType3;
                cboMeal03.DisplayMember = "NazivJela";
                cboMeal03.ValueMember = "IdJelo";

                // Load menu types
                var vrstaMenijaList = MenuTypeRepository.DajVrsteMenija();
                cboMenuType.DataSource = vrstaMenijaList;
                cboMenuType.DisplayMember = "NazivVrstaMenija";
                cboMenuType.ValueMember = "IdVrstaMenija";
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
                nextIdMeni = MenuRepository.DajSljedeceg();
                txtMenuId.Text = nextIdMeni.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the next available ID: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ocisti()
        {
            txtMenuPrice.Text = string.Empty;
            txtMenuGiftPoints.Text = string.Empty;
            cboMenuType.SelectedIndex = -1;
            cboMeal01.SelectedIndex = -1;
            cboMeal02.SelectedIndex = -1;
            cboMeal03.SelectedIndex = -1;
            PrikaziSljedecegId();
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            Meni meni=new Meni();
            meni.CijenaMenija=Convert.ToDecimal(txtMenuPrice.Text);
            meni.VrijednostPoklonBodova = Convert.ToInt32(txtMenuGiftPoints.Text);
            meni.stavkeMenija.Add(MealRepository.DajJelo(cboMeal01.SelectedValue.ToString()));
            meni.stavkeMenija.Add(MealRepository.DajJelo(cboMeal02.SelectedValue.ToString()));
            meni.stavkeMenija.Add(MealRepository.DajJelo(cboMeal03.SelectedValue.ToString()));
            meni.IdVrstaMenija = Convert.ToInt32(cboMenuType.SelectedValue);
            meni.IdMeni = Convert.ToInt32(txtMenuId.Text);
            MenuRepository.DodajMenu(meni);
        }
    }
}

