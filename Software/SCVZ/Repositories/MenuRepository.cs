using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using DBLayer;
using SCVZ.Models;

namespace SCVZ.Repositories
{
    public class MenuRepository
    {
        public static Meni DajMeni(int idMeni)
        {
            Meni menu = null;

            string sql = $"SELECT * FROM Meni WHERE IdMeni = {idMeni}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                menu = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return menu;
        }

        public static List<Meni> DajMenije()
        {
            var meniji = new List<Meni>();

            string sql = "SELECT * FROM Meni";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Meni menu = CreateObject(reader);
                meniji.Add(menu);
            }

            reader.Close();
            DB.CloseConnection();

            return meniji;
        }

        private static Meni CreateObject(SqlDataReader reader)
        {
            int idMeni = int.Parse(reader["IdMeni"].ToString());
            decimal cijenaMenija = decimal.Parse(reader["CijenaMenija"].ToString());
            int idVrstaMenija = int.Parse(reader["IdVrstaMenija"].ToString());
            int vrijednostPoklonBodova = int.Parse(reader["VrijednostPoklonBodova"].ToString());

            
            string sql = $"SELECT * FROM SkupJela WHERE IdMeni={idMeni}";
           DB.OpenConnection();
            var stavke=DB.GetDataReader(sql);

            var menu = new Meni
            {
                IdMeni = idMeni,
                CijenaMenija = cijenaMenija,
                IdVrstaMenija = idVrstaMenija,
                VrijednostPoklonBodova = vrijednostPoklonBodova
            };
            while (stavke.Read()) {
                Debug.WriteLine(stavke[1].ToString());
               
                menu.stavkeMenija.Add(MealRepository.DajJelo(stavke[1].ToString()));
            }
            
            foreach(var jelo in menu.stavkeMenija)
            {
                Debug.Write(jelo.NazivJela);
            }
            DB.CloseConnection();
            return menu;
        }
        public static int DajSljedeceg()
        {
            string sql = "SELECT ISNULL(MAX(IdMeni), 0) + 1 FROM Meni";

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
    }
}
