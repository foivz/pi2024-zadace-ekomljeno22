using DBLayer;
using SCVZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<Recenzije> GetRatingsForMenu(int menuId)
        {
            List<Recenzije> ratings = new List<Recenzije>();

            string sql = $"SELECT * FROM Recenzije WHERE IdRecenzija IN (SELECT IdRecenzija FROM SkupRecenzija WHERE IdMeni = {menuId})";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                ratings.Add(new Recenzije
                {
                    IdRecenzija = Convert.ToInt32(reader["IdRecenzija"]),
                    Ocjena = Convert.ToDecimal(reader["Ocjena"]),
                    Komentar = reader["Komentar"].ToString()
                });
            }
            DB.CloseConnection();   
            reader.Close();
            return ratings;
        }
        public static Recenzije DajRecenzijuZaStudenta(int idStudent)
        {
            Recenzije recenzija = null;

            string sql = $"SELECT r.* FROM Recenzije r INNER JOIN SkupRecenzija sr ON r.IdRecenzija = sr.IdRecenzija WHERE sr.IdStudent = {idStudent}";
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


        public static Recenzije DajRecenzijuZaMeni(int menuId, int studentId)
        {
            Recenzije recenzija = null;

            string sql = $"SELECT r.* FROM Recenzije r " +
                         $"INNER JOIN SkupRecenzija sr ON r.IdRecenzija = sr.IdRecenzija " +
                         $"WHERE sr.IdStudent = {studentId} AND sr.IdMeni = {menuId}";

            try
            {

                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);

                if (reader.HasRows)
                {
                    reader.Read();
                    recenzija = CreateObject(reader);
                }
                else
                {
                    Console.WriteLine("Debug: Nije fetchan nijedan red.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return recenzija;
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

        public static bool MeniOcjenjen(int studentId, int meniId)
        {
            string sql = $"SELECT COUNT(*) FROM SkupRecenzija WHERE IdStudent = {studentId} AND IdMeni = {meniId}";

            try
            {
                DB.OpenConnection();
                int count = (int)DB.GetScalar(sql);
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom provjere je li student ocijenio Meni: {ex.Message}");
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
                    Console.WriteLine($"Sljedeći dostupni ID: {nextId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom dohvaćanja sljedećeg ID-a: {ex.Message}");
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
                Console.WriteLine($"Greška prilikom dodavanja recenzije: {ex.Message}");
                throw;
            }
            finally
            {
                DB.CloseConnection();
            }

            return newRecenzijaId;
        }

        public static void DodajSkupRecenzija(int meniId, int newRecenzijaId, int studentId)
        {

            string recenzijaSql = $"INSERT INTO SkupRecenzija(IdSkupRecenzija, IdRecenzija, IdMeni, IdStudent) " +
                                  $"VALUES({newRecenzijaId}, {newRecenzijaId}, {meniId}, {studentId})";

            DB.OpenConnection();
            DB.ExecuteCommand(recenzijaSql);
            DB.CloseConnection();
        }

    }
}
