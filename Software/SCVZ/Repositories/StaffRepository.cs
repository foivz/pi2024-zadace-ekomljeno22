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
    public class UserRepository
    {
        public static Korisnik DajKorisnika(int idKorisnik)
        {
            Korisnik korisnik = null;

            string sql = $"SELECT * FROM Korisnik WHERE IdKorisnik = {idKorisnik}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return korisnik;
        }

        public static List<Korisnik> DajKorisnike()
        {
            var korisnici = new List<Korisnik>();

            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }

            reader.Close();
            DB.CloseConnection();

            return korisnici;
        }

        private static Korisnik CreateObject(SqlDataReader reader)
        {
            int idKorisnik = int.Parse(reader["IdKorisnik"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string lozinka = reader["Lozinka"].ToString();

            var korisnik = new Korisnik
            {
                IdKorisnik = idKorisnik,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka
            };

            return korisnik;
        }

        public static void DodajKorisnika(Korisnik korisnik)
        {
            string sql = $"INSERT INTO Korisnik (IdKorisnik, Ime, Prezime, Lozinka) " +
                         $"VALUES ({korisnik.IdKorisnik}, '{korisnik.Ime}', '{korisnik.Prezime}', '{korisnik.Lozinka}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static int DajSljedeceg()
        {
            string sql = "SELECT ISNULL(MAX(IdKorisnik), 0) + 1 FROM Korisnik";

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
    }
}
