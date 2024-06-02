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
        private int orderId;
        private string JMBAG;

        public FrmStudentRating(int orderId, string jMBAG)
        {
            InitializeComponent();
            this.orderId = orderId;
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
                int studentId = student.IdStudent;

                if (RatingsRepository.MeniOcjenjen(studentId, orderId))
                {
                    MessageBox.Show("Već ste ocjenili ovaj Meni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Greška prilikom recenziranja:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RatingsRepository.DodajSkupRecenzija(orderId, newRecenzijaId, studentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom unosa recenzije: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
