using System;
using System.Windows.Forms;
using DBLayer;
using SCVZ.Models;
using SCVZ.Repositories;

namespace SCVZ
{
    public partial class FrmAddOrder : Form
    {
        private string enteredUsername;
        private int nextIdOrder;
        private Student randomStudent;

        public FrmAddOrder(string enteredUsername)
        {
            InitializeComponent();
            this.enteredUsername = enteredUsername;
            txtOrderServer.Text = this.enteredUsername;
            PrikaziSljedecegId();

            randomStudent = StudentRepository.GetRandomStudent();
            if (randomStudent != null)
            {
                txtStudentId.Text = $"{randomStudent.Ime} {randomStudent.Prezime}";
            }
            else
            {
                txtStudentId.Text = "Nema studenata";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (randomStudent != null)
                {
                    txtStudentId.Text = $"{randomStudent.Ime} {randomStudent.Prezime}";
                }
                else
                {
                    txtStudentId.Text = "Nema studenata";
                }

                int idStudent = randomStudent.IdStudent;
                Narudzbe newOrder = new Narudzbe
                {
                    DatumNarudzbe = DateTime.Now,
                    IdMeni = int.Parse(txtIdMenu.Text),
                    IdZaposlenik = DajIdZaposlenikPremaKImenu(enteredUsername),
                    IdStudent = idStudent
                };

                if (randomStudent.BrojKupona >= 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Želite li iskoristiti kupon za ovu narudžbu?", "Kupon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Meni selectedMenu = MenuRepository.DajMeni(newOrder.IdMeni);

                        decimal discountedPrice = selectedMenu.CijenaMenija * 0.85m;
                        newOrder.KuponCijenaMenija = (float)discountedPrice;

                        randomStudent.BrojKupona--;

                        string updateSql = $"UPDATE Student SET BrojKupona = {randomStudent.BrojKupona} WHERE IdStudent = {randomStudent.IdStudent}";

                        try
                        {
                            DB.OpenConnection();
                            DB.ExecuteCommand(updateSql);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Greška prilikom ažuriranja tablice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Narudžba uspješno izrađena i dana studentu s JMBAG: {randomStudent.JMBAG}");
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

        private int DajIdZaposlenikPremaKImenu(string username)
        {
            Zaposlenik employee = StaffRepository.DajZaposlenikaByUsername(username);
            return (employee != null) ? employee.IdZaposlenik : 0;
        }

        private void PrikaziSljedecegId()
        {
            try
            {
                nextIdOrder = OrderRepository.DajSljedeceg();
                txtOrderId.Text = nextIdOrder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dohvaćanja sljedećeg ID-a: {ex.Message}");
            }
        }

        private void btnChooseMenu_Click(object sender, EventArgs e)
        {
            FrmAddMenuToOrder form1 = new FrmAddMenuToOrder();
            form1.ParentForm = this;
            form1.Show();
        }

        public void SetSelectedMenu(int menuId)
        {
            Meni selectedMenu = MenuRepository.DajMeni(menuId);
            txtIdMenu.Text = menuId.ToString();
            txtOrderPrice.Text = selectedMenu.CijenaMenija.ToString();
            txtOrderServer.Text = enteredUsername;
        }

        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            ConversionManager.ConvertPoklonBodoviToKupons(randomStudent);
            MenuRepository.IzračunajPoklonBodove(randomStudent.IdStudent);
        }
    }
}