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
                txtStudentId.Text = "No student found";
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
                    txtStudentId.Text = "No student found";
                }

                int idStudent = randomStudent.IdStudent;
                Narudzbe newOrder = new Narudzbe
                {
                    DatumNarudzbe = DateTime.Now,
                    IdMeni = int.Parse(txtIdMenu.Text),
                    IdZaposlenik = GetEmployeeIdByUsername(enteredUsername),
                    IdStudent = idStudent
                };

                if (randomStudent.BrojKupona >= 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to use a coupon for this order?", "Coupon Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            MessageBox.Show($"An error occurred while updating the student table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Order created successfully and assigned to student with JMBAG: {randomStudent.JMBAG}");
                }
                else
                {
                    MessageBox.Show("Failed to create the order.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the order: {ex.Message}");
            }
        }


        private int GetEmployeeIdByUsername(string username)
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
                MessageBox.Show($"An error occurred while retrieving the next available ID: {ex.Message}");
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
            MenuRepository.CalculateGiftPointsForStudent(randomStudent.IdStudent);
        }

        private void btnUseCoupon_Click(object sender, EventArgs e)
        {
            try
            {
                int menuId;
                if (!int.TryParse(txtIdMenu.Text, out menuId))
                {
                    MessageBox.Show("Please select a menu item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (randomStudent == null)
                {
                    MessageBox.Show("No student found with the provided JMBAG.");
                    return;
                }

                if (randomStudent.BrojKupona >= 1)
                {
                    randomStudent.BrojKupona--;

                    // Update the student table with the new coupon count
                    string updateSql = $"UPDATE Student SET BrojKupona = {randomStudent.BrojKupona} WHERE IdStudent = {randomStudent.IdStudent}";

                    try
                    {
                        DB.OpenConnection();
                        DB.ExecuteCommand(updateSql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the student table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DB.CloseConnection();
                    }

                    // Retrieve the selected menu
                    Meni selectedMenu = MenuRepository.DajMeni(menuId);

                    if (selectedMenu != null)
                    {
                        // Calculate the discounted price
                        decimal discountedPrice = selectedMenu.CijenaMenija * 0.85m;

                        // Update the order price textbox with the discounted price
                        txtOrderPrice.Text = discountedPrice.ToString();

                        MessageBox.Show("Coupon successfully used.");
                    }
                    else
                    {
                        MessageBox.Show("No menu found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient coupons. Cannot use coupon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while using the coupon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}



