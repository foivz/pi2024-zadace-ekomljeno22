using System;
using System.Windows.Forms;
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

                int newOrderId = OrderRepository.InsertOrder(newOrder, idStudent);

                if (newOrderId != -1)
                {
                    if (randomStudent != null)
                    {
                        MessageBox.Show($"Order created successfully and assigned to student with JMBAG: {randomStudent.JMBAG}");
                    }
                    else
                    {
                        MessageBox.Show("No students found to assign the order.");
                    }
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
    }
}



