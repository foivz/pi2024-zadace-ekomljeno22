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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SCVZ
{
    public partial class FrmStudentRating : Form
    {
        private int meniId;
        private string JMBAG;

        public FrmStudentRating(int meniId, string jMBAG)
        {
            InitializeComponent();
            this.meniId = meniId;
            JMBAG = jMBAG;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentRating_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            try
            {
                int rating = GetSelectedRating();
                if (rating == 0)
                {
                    MessageBox.Show("Odaberite ocjenu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string comment = txtComments.Text.Trim();
                Student student = StudentRepository.DajStudentaByJMBAG(JMBAG);
                if (student == null)
                {
                    MessageBox.Show("Student nije pronađen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int studentId = student.IdStudent;

                if (RatingsRepository.MeniOcjenjen(studentId, meniId))
                {
                    MessageBox.Show("Već ste ocijenili ovaj Meni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Recenzije recenzija = new Recenzije
                {
                    Ocjena = rating,
                    Komentar = comment
                };
                int newRecenzijaId = RatingsRepository.DodajRecenziju(recenzija);

                if (newRecenzijaId == -1)
                {
                    MessageBox.Show("Greška prilikom dodavanja recenzije", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RatingsRepository.DodajSkupRecenzija(meniId, newRecenzijaId, studentId);
                MessageBox.Show("Recenzija uspješno dodana", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom unosa recenzije: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }


        private int GetSelectedRating()
        {
            if (rboUnsufficient.Checked) return 1;
            if (rboSufficient.Checked) return 2;
            if (rboGood.Checked) return 3;
            if (rboVeryGood.Checked) return 4;
            if (rboExcellent.Checked) return 5;
            return 0;
        }
    }
}
