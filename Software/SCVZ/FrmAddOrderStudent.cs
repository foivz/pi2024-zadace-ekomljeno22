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
    public partial class FrmAddOrderStudent : Form
    {
        private int nextIdOrder;
        private string JMBAG { get; set; }
        private Zaposlenik randomZaposlenik;
        Student student;

        public FrmAddOrderStudent(string jMBAG)
        {
            InitializeComponent();
            PrikaziSljedecegId();
            JMBAG = jMBAG;
            student = StudentRepository.DajStudentaByJMBAG(JMBAG);

            if (student != null)
            {
                txtStudentId.Text = student.JMBAG;
            }
            else
            {
                MessageBox.Show("Ne postoji student sa zadanim JMBAG.");
                return;
            }
            randomZaposlenik = StaffRepository.GetRandomBlagajnik();

            if (randomZaposlenik != null)
            {
                txtOrderServer.Text = $"{randomZaposlenik.KorisnickoIme}";
            }
            else
            {
                txtOrderServer.Text = "Nema blagajnika";
            }
        }

        private void PrikaziSljedecegId()
        {
            try
            {
                nextIdOrder = OrderRepository.DajSljedeceg();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dohvaćanja sljedećeg ID-a: {ex.Message}");
            }
        }

        public void SetSelectedMenu(int menuId)
        {
            Meni selectedMenu = MenuRepository.DajMeni(menuId);
            txtOrderPrice.Text = selectedMenu.CijenaMenija.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (student != null)
                {
                    txtStudentId.Text = $"{student.Ime} {student.Prezime}";
                }
                else
                {
                    txtStudentId.Text = "Nema studenata";
                    return;
                }

                int idStudent = student.IdStudent;
                Narudzbe newOrder = new Narudzbe
                {
                    DatumNarudzbe = DateTime.Now,
                    IdZaposlenik = randomZaposlenik.IdZaposlenik,
                    IdStudent = idStudent,
                    KuponCijenaMenija = 0
                };
                if (student.BrojKupona >= 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Želite li iskoristiti kupon za ovu narudžbu?", "Kupon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Meni selectedMenu = MenuRepository.DajMeni(newOrder.IdMeni);
                        decimal discountedPrice = selectedMenu.CijenaMenija * 0.85m;
                        newOrder.KuponCijenaMenija = (float)discountedPrice;

                        student.BrojKupona--;

                        string updateSql = $"UPDATE Student SET BrojKupona = {student.BrojKupona} WHERE IdStudent = {student.IdStudent}";

                        try
                        {
                            DB.OpenConnection();
                            DB.ExecuteCommand(updateSql);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Greška prilikom ažuriranja studenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {
                            DB.CloseConnection();
                        }
                    }
                }

                int newOrderId = OrderRepository.InsertOrder(newOrder, idStudent);

                if (newOrderId != -1)
                {
                    MessageBox.Show($"Narudžba uspješno izrađena i dana studentu s JMBAG: { student.JMBAG}");
                }
                else
                {
                    MessageBox.Show("Nije moguće izvršiti narudžbu");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom generiranja narudžbe: {ex.Message}");
            }
        }

        private void btnChooseMenu_Click(object sender, EventArgs e)
        {
            FrmAddMenuToOrder form2 = new FrmAddMenuToOrder();
            form2.ParentFormStudent = this;
            form2.Show();
        }

    }
}
