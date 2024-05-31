using DBLayer;
using SCVZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string sql = $"SELECT * FROM Narudzbe";
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
                Console.WriteLine($"An error occurred while retrieving the menu ID for order {orderId}: {ex.Message}");
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

            string sql = $"SELECT n.* FROM Narudzbe n INNER JOIN Student s ON n.IdStudent = s.IdStudent WHERE s.JMBAG = {JMBAG}";
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
            int idNarudzba = int.Parse(reader["IdNarudzba"].ToString());
            DateTime datumNarudzbe = DateTime.Parse(reader["DatumNarudzbe"].ToString());
            int idMeni = int.Parse(reader["IdMeni"].ToString());
            int idZaposlenik = int.Parse(reader["IdZaposlenik"].ToString());
            int idStudent = int.Parse(reader["IdStudent"].ToString());

            Narudzbe narudzba = new Narudzbe
            {
                IdNarudzba = idNarudzba,
                DatumNarudzbe = datumNarudzbe,
                IdMeni = idMeni,
                IdZaposlenik = idZaposlenik,
                IdStudent = idStudent,
            };

            return narudzba;
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
                    Console.WriteLine($"Next available ID: {nextId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving the next available ID: {ex.Message}");
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
                Console.WriteLine($"An error occurred while adding the menu: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return newMenuId;
        }
        public static int InsertOrder(Narudzbe order, int studentId)
        {
            string formattedDate = order.DatumNarudzbe.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $"INSERT INTO Narudzbe (DatumNarudzbe, IdMeni, IdZaposlenik, IdStudent) " +
                         $"VALUES ('{formattedDate}', {order.IdMeni}, {order.IdZaposlenik}, {studentId}); " +
                         $"SELECT CAST(SCOPE_IDENTITY() AS INT)";

            int newOrderId = -1;
            try
            {
                DB.OpenConnection();
                newOrderId = (int)DB.GetScalar(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while inserting the order: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return newOrderId;
        }
    }
}
