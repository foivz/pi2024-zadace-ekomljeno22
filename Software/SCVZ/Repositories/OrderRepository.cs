using DBLayer;
using SCVZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ.Repositories
{
    public class OrderRepository
    {
        public static Narudzbe DajNarudzbu(string idNarudzba)
        {
            Narudzbe narudzba = null;

            string sql = $"SELECT * FROM Narudzbe WHERE IdNarudzba = {idNarudzba}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                narudzba = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return narudzba;
        }

        public static List<Narudzbe> DajNarudzbe()
        {
            var narudzbe = new List<Narudzbe>();

            string sql = "SELECT N.*, S.Status FROM Narudzbe N " +
                         "LEFT JOIN StatusNarudzbe S ON N.IdStatusNarudzbe = S.IdStatusNarudzbe " +
                         "ORDER BY N.IdNarudzba DESC";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Narudzbe narudzba = CreateObject(reader);
                narudzbe.Add(narudzba);
            }

            reader.Close();
            DB.CloseConnection();

            return narudzbe;
        }

        public static StatusNarudzbe DajStatusNarudzbe(int idStatusNarudzbe)
        {
            StatusNarudzbe statusNarudzbe = null;

            string sql = $"SELECT * FROM StatusNarudzbe WHERE IdStatusNarudzbe = {idStatusNarudzbe}";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.Read())
            {
                statusNarudzbe = new StatusNarudzbe
                {
                    IdStatusNarudzbe = int.Parse(reader["IdStatusNarudzbe"].ToString()),
                    Status = reader["Status"].ToString()
                };
            }

            reader.Close();
            DB.CloseConnection();

            return statusNarudzbe;
        }
        public static List<StatusNarudzbe> DajSveStatusNarudzbe()
        {
            List<StatusNarudzbe> statuses = new List<StatusNarudzbe>();

            string sql = "SELECT * FROM StatusNarudzbe";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                StatusNarudzbe status = new StatusNarudzbe
                {
                    IdStatusNarudzbe = int.Parse(reader["IdStatusNarudzbe"].ToString()),
                    Status = reader["Status"].ToString()
                };
                statuses.Add(status);
            }

            reader.Close();
            DB.CloseConnection();

            return statuses;
        }

        public static int GetOrderCountForMenu(int menuId)
        {
            int orderCount = 0;
            string sql = $"SELECT COUNT(*) FROM Narudzbe WHERE IdMeni = {menuId}";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                orderCount = reader.GetInt32(0);
            }

            reader.Close();
            DB.CloseConnection();

            return orderCount;
        }
        public static int GetMenuIdForOrder(int orderId)
        {
            int menuId = -1;

            string sql = $"SELECT IdMeni FROM Narudzbe WHERE IdNarudzba = {orderId}";
            try
            {
                DB.OpenConnection();
                object result = DB.GetScalar(sql);
                if (result != null && result != DBNull.Value)
                {
                    menuId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom fetchanja {orderId}: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return menuId;
        }

        public static List<Narudzbe> DajNarudzbePoJMBAG(string JMBAG)
        {
            var narudzbe = new List<Narudzbe>();

            string sql = "SELECT n.*, s.JMBAG, st.Status FROM Narudzbe n " +
                         "INNER JOIN Student s ON n.IdStudent = s.IdStudent " +
                         "LEFT JOIN StatusNarudzbe st ON n.IdStatusNarudzbe = st.IdStatusNarudzbe " +
                         $"WHERE s.JMBAG = '{JMBAG}' ORDER BY n.IdNarudzba DESC";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Narudzbe narudzba = CreateObject(reader);
                narudzbe.Add(narudzba);
            }

            reader.Close();
            DB.CloseConnection();

            return narudzbe;
        }

        private static Narudzbe CreateObject(SqlDataReader reader)
        {
            try
            {
                // Log the values read from the SqlDataReader
                Console.WriteLine("IdNarudzba: " + reader["IdNarudzba"]);
                Console.WriteLine("DatumNarudzbe: " + reader["DatumNarudzbe"]);
                Console.WriteLine("IdMeni: " + reader["IdMeni"]);
                Console.WriteLine("IdZaposlenik: " + reader["IdZaposlenik"]);
                Console.WriteLine("IdStudent: " + reader["IdStudent"]);
                Console.WriteLine("KuponCijenaMenija: " + reader["KuponCijenaMenija"]);
                Console.WriteLine("IdStatusNarudzbe: " + reader["IdStatusNarudzbe"]);

                // Parse the values with proper null checking
                int idNarudzba = reader["IdNarudzba"] != DBNull.Value ? int.Parse(reader["IdNarudzba"].ToString()) : 0;
                DateTime datumNarudzbe = reader["DatumNarudzbe"] != DBNull.Value ? DateTime.Parse(reader["DatumNarudzbe"].ToString()) : DateTime.MinValue;
                int idMeni = reader["IdMeni"] != DBNull.Value ? int.Parse(reader["IdMeni"].ToString()) : 0;
                int idZaposlenik = reader["IdZaposlenik"] != DBNull.Value ? int.Parse(reader["IdZaposlenik"].ToString()) : 0;
                int idStudent = reader["IdStudent"] != DBNull.Value ? int.Parse(reader["IdStudent"].ToString()) : 0;
                int idStatusNarudzbe = reader["IdStatusNarudzbe"] != DBNull.Value ? int.Parse(reader["IdStatusNarudzbe"].ToString()) : 0;

                float kuponCijenaMenija;
                if (reader["KuponCijenaMenija"] != DBNull.Value)
                {
                    if (!float.TryParse(reader["KuponCijenaMenija"].ToString(), out kuponCijenaMenija))
                    {
                        kuponCijenaMenija = 0.0f;
                    }
                }
                else
                {
                    kuponCijenaMenija = 0.0f;
                }

                Narudzbe narudzba = new Narudzbe
                {
                    IdNarudzba = idNarudzba,
                    DatumNarudzbe = datumNarudzbe,
                    IdMeni = idMeni,
                    IdZaposlenik = idZaposlenik,
                    IdStudent = idStudent,
                    KuponCijenaMenija = kuponCijenaMenija,
                    IdStatusNarudzbe = idStatusNarudzbe
                };

                return narudzba;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating Narudzbe object: " + ex.Message);
                throw;
            }
        }

        public static int DajSljedeceg()
        {
            string sql = "SELECT ISNULL(MAX(IdNarudzba), 0) + 1 FROM Narudzbe";

            int nextId = -1;

            try
            {
                DB.OpenConnection();

                object result = DB.GetScalar(sql);
                if (result != null && result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result);
                    Console.WriteLine($"Sljedeći slobodni ID: {nextId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom generiranja sljedece narudzbe: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return nextId;
        }

        public static int DodajMenu(Meni menu)
        {
            string sql = $"INSERT INTO Meni (CijenaMenija, IdVrstaMenija, VrijednostPoklonBodova) " +
                         $"VALUES ({menu.CijenaMenija}, {menu.IdVrstaMenija}, {menu.VrijednostPoklonBodova}); " +
                         "SELECT CAST(SCOPE_IDENTITY() AS INT);";

            int newMenuId = -1;
            try
            {
                DB.OpenConnection();
                object result = DB.GetScalar(sql);
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newMenuId = id;
                }
                foreach (Jelo jelo in menu.stavkeMenija)
                {
                    string stavka = $"INSERT INTO SkupJela(IdJelo, IdMeni) VALUES({jelo.IdJelo},{menu.IdMeni}); SELECT  CAST(SCOPE_IDENTITY() AS INT);";
                    DB.OpenConnection();
                    DB.ExecuteCommand(stavka);
                    DB.CloseConnection();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greska prilikom dodavanja nove narudzbe {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return newMenuId;
        }

        public static void UpdateOrderStatus(int orderId, int newStatusId)
        {
            string updateSql = $"UPDATE Narudzbe SET IdStatusNarudzbe = {newStatusId} WHERE IdNarudzba = {orderId}";

            DB.OpenConnection();
            DB.ExecuteCommand(updateSql);
            DB.CloseConnection();
        }

        public static int InsertOrder(Narudzbe order, int studentId)
        {
            int newOrderId = -1;
            try
            {
                DB.OpenConnection();

                if (order.KuponCijenaMenija != 0)
                {
                    string updateKuponSql = $"UPDATE Narudzbe SET KuponCijenaMenija = {order.KuponCijenaMenija.ToString("F", CultureInfo.InvariantCulture)} WHERE IdNarudzba = {order.IdNarudzba}";
                    DB.ExecuteCommand(updateKuponSql);
                }

                string formattedDate = order.DatumNarudzbe.ToString("yyyy-MM-dd HH:mm:ss");
                int idStatusNarudzbe = order.IdStatusNarudzbe != 0 ? order.IdStatusNarudzbe : 1;
                string insertSql = $"INSERT INTO Narudzbe (DatumNarudzbe, IdMeni, IdZaposlenik, IdStudent, KuponCijenaMenija, IdStatusNarudzbe) " +
                                   $"VALUES ('{formattedDate}', {order.IdMeni}, {order.IdZaposlenik}, {studentId}, {(order.KuponCijenaMenija != 0 ? order.KuponCijenaMenija.ToString("F", CultureInfo.InvariantCulture) : "NULL")}, {idStatusNarudzbe}); " +
                                   $"SELECT CAST(SCOPE_IDENTITY() AS INT)";
                newOrderId = (int)DB.GetScalar(insertSql);

                string menuSql = $"SELECT VrijednostPoklonBodova FROM Meni WHERE IdMeni = {order.IdMeni}";
                int vrijednostPoklonBodova = (int)DB.GetScalar(menuSql);

                string studentSql = $"SELECT BrojPoklonBodova, BrojKupona FROM Student WHERE IdStudent = {studentId}";
                SqlDataReader reader = DB.GetDataReader(studentSql);

                if (reader.HasRows)
                {
                    reader.Read();
                    int brojPoklonBodovaBefore = reader.GetInt32(reader.GetOrdinal("BrojPoklonBodova"));
                    int brojKuponaBefore = reader.GetInt32(reader.GetOrdinal("BrojKupona"));
                    reader.Close();

                    int totalGiftPointsBefore = brojPoklonBodovaBefore;
                    int brojPoklonBodovaAfter = brojPoklonBodovaBefore + vrijednostPoklonBodova;
                    int brojKuponaAfter = brojKuponaBefore;

                    string updateStudentSql = $"UPDATE Student SET BrojPoklonBodova = {brojPoklonBodovaAfter}, BrojKupona = {brojKuponaAfter} WHERE IdStudent = {studentId}";
                    DB.ExecuteCommand(updateStudentSql);

                    int totalGiftPointsAfter = brojPoklonBodovaAfter;

                    Console.WriteLine($"Ukupni poklon bodovi {studentId} prije narudžbe: {totalGiftPointsBefore}");
                    Console.WriteLine($"Ukupni poklon bodovi {studentId} poslije narudžbe: {totalGiftPointsAfter}");

                    int interval = totalGiftPointsAfter - totalGiftPointsBefore;
                    Console.WriteLine($"Interval između bodova: {interval}");
                }
                else
                {
                    reader.Close();
                    throw new Exception($"Student s ID {studentId} nije nadjen.");
                }

                MessageBox.Show("Narudžba uspješno unesena!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom unosa narudžbe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Greška prilikom unosa narudžbe {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return newOrderId;
        }
    }
}
