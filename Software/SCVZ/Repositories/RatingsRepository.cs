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
    internal class RatingsRepository
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

        private static Recenzije CreateObject(SqlDataReader reader)
        {
            int idRecenzija = int.Parse(reader["IdRecenzija"].ToString());
            decimal ocjena = decimal.Parse(reader["Ocjena"].ToString());
            string komentar = reader["Komentar"].ToString();

            var recenzija = new Recenzije
            {
                IdRecenzija = idRecenzija,
                Ocjena = ocjena,
                Komentar = komentar
            };

            return recenzija;
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

        public static void DodajRecenziju(Recenzije recenzija)
        {
            string sql = $"INSERT INTO Recenzije (Ocjena, Komentar) " +
             $"VALUES ('{recenzija.Ocjena}', '{recenzija.Komentar}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
