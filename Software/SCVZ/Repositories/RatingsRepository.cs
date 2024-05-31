using DBLayer;
using SCVZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Repositories
{
    public class RatingsRepository
    {
        public static Recenzije DajRecenziju(string IdRecenzija)
        {
            Recenzije recenzija = null;

            string sql = $"SELECT * FROM Recenzije WHERE IdRecenzija = {IdRecenzija}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                recenzija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return recenzija;
        }

        public static List<Recenzije> DajRecenzije()
        {
            var recenzije = new List<Recenzije>();

            string sql = $"SELECT * FROM Recenzije;";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Recenzije recenzija = CreateObject(reader);
                recenzije.Add(recenzija);
            }

            reader.Close();
            DB.CloseConnection();

            return recenzije;
        }

        public static int DajSljedecegSkup()
        {
            string sql = "SELECT ISNULL(MAX(IdSkupRecenzija), 0) + 1 FROM SkupRecenzija";

            int nextId = -1;

            try
            {
                DB.OpenConnection();

                object result = DB.GetScalar(sql);
                if (result != null && result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result);
                    Console.WriteLine($"Next available SkupRecenzija ID: {nextId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving the next available SkupRecenzija ID: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return nextId;
        }


        public static Recenzije CreateObject(SqlDataReader reader)
        {
            int idRecenzija = int.Parse(reader["IdRecenzija"].ToString());
            decimal ocjena = decimal.Parse(reader["Ocjena"].ToString());
            string komentar = reader["Komentar"].ToString();

            return new Recenzije
            {
                IdRecenzija = idRecenzija,
                Ocjena = ocjena,
                Komentar = komentar
            };
        }

        public static bool HasStudentRatedMenu(int studentId, int orderId)
        {
            string sql = $"SELECT COUNT(*) FROM SkupRecenzija WHERE IdStudent = {studentId} AND IdMeni = (SELECT IdMeni FROM Narudzbe WHERE IdNarudzba = {orderId})";

            try
            {
                DB.OpenConnection();
                int count = (int)DB.GetScalar(sql);
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while checking if the student has rated the menu: {ex.Message}");
                return false;
            }
            finally
            {
                DB.CloseConnection();
            }
        }


        public static int DajSljedeceg()
        {
            string sql = "SELECT ISNULL(MAX(IdRecenzija), 0) + 1 FROM Recenzije";

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

        public static int DajSljedecegSKup()
        {
            string sql = "SELECT ISNULL(MAX(IdSkupRecenzija), 0) + 1 FROM SkupRecenzija";

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

        public static int DodajRecenziju(Recenzije recenzija)
        {
            int newRecenzijaId = DajSljedeceg();

            string sql = $"INSERT INTO Recenzije (Ocjena, Komentar) " +
                         $"VALUES ('{recenzija.Ocjena}', '{recenzija.Komentar}'); " +
                         "SELECT CAST(SCOPE_IDENTITY() AS INT);";
            try
            {
                DB.OpenConnection();
                object result = DB.GetScalar(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the recenzija: {ex.Message}");
                throw;
            }
            finally
            {
                DB.CloseConnection();
            }

            return newRecenzijaId;
        }
    }
}
