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

        public static void CalculateGiftPointsForStudent(int studentId)
        {
            try
            {
                DB.OpenConnection();

                // Fetch all orders for the student
                string ordersSql = $"SELECT * FROM Narudzbe WHERE IdStudent = {studentId}";
                SqlDataReader ordersReader = DB.GetDataReader(ordersSql);

                int totalBrojPoklonBodova = 0;
                int totalBrojKupona = 0;

                while (ordersReader.Read())
                {
                    int brojPoklonBodova = (int)ordersReader["BrojPoklonBodova"];
                    int brojKupona = (int)ordersReader["BrojKupona"];

                    totalBrojPoklonBodova += brojPoklonBodova;
                    totalBrojKupona += brojKupona;
                }

                ordersReader.Close();

                Console.WriteLine($"Total BrojPoklonBodova for student {studentId}: {totalBrojPoklonBodova}");
                Console.WriteLine($"Total BrojKupona for student {studentId}: {totalBrojKupona}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while calculating gift points for student {studentId}: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public static List<Meni> GetMenusSortedByRating()
        {
            var menus = new List<Meni>();
            string sql = @"SELECT M.*, AvgRatings.AvgRating
                   FROM Meni M
                   INNER JOIN (
                       SELECT SR.IdMeni, AVG(R.Ocjena) AS AvgRating
                       FROM SkupRecenzija SR
                       INNER JOIN Recenzije R ON SR.IdRecenzija = R.IdRecenzija
                       GROUP BY SR.IdMeni
                   ) AvgRatings ON M.IdMeni = AvgRatings.IdMeni
                   ORDER BY AvgRatings.AvgRating DESC;";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Meni menu = CreateObject(reader);
                menus.Add(menu);
            }
            reader.Close();
            DB.CloseConnection();
            return menus;
        }

        public static List<Meni> GetMenusSortedByPreparationTime()
        {
            var menus = new List<Meni>();
            string sql = @"SELECT M.*
                   FROM Meni M
                   ORDER BY M.VrijemePripreme ASC;";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Meni menu = CreateObject(reader);
                menus.Add(menu);
            }
            reader.Close();
            DB.CloseConnection();
            return menus;
        }


        public static Meni GetMenuForOrder(int orderId)
        {
            Meni menu = null;
            string sql = $"SELECT * FROM Meni WHERE IdMeni = (SELECT IdMeni FROM Narudzbe WHERE IdNarudzba = {orderId})";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();

                menu = MenuRepository.CreateObject(reader);

                reader.Close();
            }
            DB.CloseConnection();
            return menu;
        }

        private static Meni CreateObject(SqlDataReader reader)
        {
            int idMeni = int.Parse(reader["IdMeni"].ToString());
            decimal cijenaMenija = decimal.Parse(reader["CijenaMenija"].ToString());
            int idVrstaMenija = int.Parse(reader["IdVrstaMenija"].ToString());
            int vrijednostPoklonBodova = int.Parse(reader["VrijednostPoklonBodova"].ToString());
            string vrijemePripremeString = reader["VrijemePripreme"].ToString();

            TimeSpan vrijemePripreme = ParseTimeSpan(vrijemePripremeString);

            string sql = $"SELECT * FROM SkupJela WHERE IdMeni={idMeni}";
            DB.OpenConnection();
            var stavke = DB.GetDataReader(sql);

            var menu = new Meni
            {
                IdMeni = idMeni,
                CijenaMenija = cijenaMenija,
                IdVrstaMenija = idVrstaMenija,
                VrijednostPoklonBodova = vrijednostPoklonBodova,
                VrijemePripreme = vrijemePripreme
            };

            while (stavke.Read())
            {
                Debug.WriteLine(stavke[1].ToString());
                menu.stavkeMenija.Add(MealRepository.DajJelo(stavke[1].ToString()));
            }

            DB.CloseConnection();

            sql = $"SELECT r.* FROM Recenzije r JOIN SkupRecenzija sr ON r.IdRecenzija = sr.IdRecenzija WHERE sr.IdMeni = {idMeni}";
            DB.OpenConnection();
            var recenzijeReader = DB.GetDataReader(sql);
            while (recenzijeReader.Read())
            {
                Recenzije recenzija = RatingsRepository.CreateObject(recenzijeReader);
                menu.recenzijeMenija.Add(recenzija);
            }
            DB.CloseConnection();

            return menu;
        }

        public static TimeSpan ParseTimeSpan(string timeString)
        {
            try
            {
                string[] timeComponents = timeString.Split(':');

                if (timeComponents.Length != 3)
                {
                    throw new FormatException("Invalid time format. Time string must be in HH:MM:SS format.");
                }
                int hours, minutes, seconds;
                if (!int.TryParse(timeComponents[0], out hours) ||
                    !int.TryParse(timeComponents[1], out minutes) ||
                    !int.TryParse(timeComponents[2], out seconds))
                {
                    throw new FormatException("Invalid time format. Time string must contain numeric values.");
                }

                return new TimeSpan(hours, minutes, seconds);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error parsing time string: {ex.Message}");
                throw;
            }
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
            string timeString = menu.VrijemePripreme.ToString(@"hh\:mm\:ss");

            string sql = $"INSERT INTO Meni (CijenaMenija, IdVrstaMenija, VrijednostPoklonBodova, VrijemePripreme) " +
                         $"VALUES ({menu.CijenaMenija}, {menu.IdVrstaMenija}, {menu.VrijednostPoklonBodova}, '{timeString}'); " +
                         "SELECT CAST(SCOPE_IDENTITY() AS INT);";

            int newMenuId = -1;
            try
            {
                DB.OpenConnection();
                object result = DB.GetScalar(sql);
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    newMenuId = id;
                    menu.IdMeni = id;
                }

                foreach (Jelo jelo in menu.stavkeMenija)
                {
                    string stavka = $"INSERT INTO SkupJela(IdJelo, IdMeni) VALUES({jelo.IdJelo}, {menu.IdMeni});";
                    DB.ExecuteCommand(stavka);
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
