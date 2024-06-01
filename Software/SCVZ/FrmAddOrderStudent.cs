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

        public FrmAddOrderStudent(string jMBAG)
        {
            InitializeComponent();
            PrikaziSljedecegId();
            JMBAG = jMBAG;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddMenuToOrder form1 = new FrmAddMenuToOrder();
            form1.Show();
        }

        public void SetSelectedMenu(int menuId)
        {
            Meni selectedMenu = MenuRepository.DajMeni(menuId);
            txtIdMenu.Text = menuId.ToString();
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
                string jmbag = txtStudentId.Text;
                Student student = StudentRepository.DajStudentaByJMBAG(jmbag);

                if (student == null)
                {
                    MessageBox.Show("No student found with the provided JMBAG.");
                    return;
                }

                Zaposlenik randomBlagajnik = StaffRepository.GetRandomBlagajnik();

                if (randomBlagajnik == null)
                {
                    MessageBox.Show("No cashier found to assign the order.");
                    return;
                }

                Narudzbe newOrder = new Narudzbe
                {
                    DatumNarudzbe = DateTime.Now,
                    IdMeni = int.Parse(txtIdMenu.Text),
                    IdZaposlenik = randomBlagajnik.IdZaposlenik,
                    IdStudent = student.IdStudent
                };

                int newOrderId = OrderRepository.InsertOrder(newOrder, student.IdStudent);

                if (newOrderId != -1)
                {
                    MessageBox.Show($"Order created successfully and assigned to student with JMBAG: {student.JMBAG} and cashier: {randomBlagajnik.Ime} {randomBlagajnik.Prezime}");
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



        private void btnChooseMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
