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

                var mealType1 = 1;
                var mealType2 = 2;
                var mealType3 = 3; 

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

                var vrstaMenijaList = MenuTypeRepository.DajVrsteMenija();
                cboMenuType.DataSource = vrstaMenijaList;
                cboMenuType.DisplayMember = "NazivVrstaMenija";
                cboMenuType.ValueMember = "IdVrstaMenija";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja izbornika: {ex.Message}");
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
                MessageBox.Show($"Greška prilikom prikazivanja sljedećeg slobodnog ID-a: {ex.Message}");
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
            try
            {
                int hours = int.Parse(txtAveragePrepHours.Text);
                int minutes = int.Parse(txtAveragePrepMinutes.Text);
                int seconds = int.Parse(txtAveragePrepSeconds.Text);

                string formattedHours = hours.ToString("D2");
                string formattedMinutes = minutes.ToString("D2");
                string formattedSeconds = seconds.ToString("D2");

                string timeString = $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";

                Console.WriteLine($"Konstruirano vrijeme: {timeString}");

                TimeSpan vrijemePripreme = MenuRepository.ParseTimeSpan(timeString);

                Meni meni = new Meni
                {
                    CijenaMenija = Convert.ToDecimal(txtMenuPrice.Text),
                    VrijednostPoklonBodova = Convert.ToInt32(txtMenuGiftPoints.Text),
                    IdVrstaMenija = Convert.ToInt32(cboMenuType.SelectedValue),
                    IdMeni = Convert.ToInt32(txtMenuId.Text),
                    VrijemePripreme = vrijemePripreme
                };

                meni.stavkeMenija.Add(MealRepository.DajJelo(cboMeal01.SelectedValue.ToString()));
                meni.stavkeMenija.Add(MealRepository.DajJelo(cboMeal02.SelectedValue.ToString()));
                meni.stavkeMenija.Add(MealRepository.DajJelo(cboMeal03.SelectedValue.ToString()));

                MenuRepository.DodajMenu(meni);

                MessageBox.Show("Meni uspješno dodan!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja Menija: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

