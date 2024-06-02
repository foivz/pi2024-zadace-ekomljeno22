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
    public class StaffRepository
    {
        public static Zaposlenik DajZaposlenikaByUsername(string korisnickoIme)
            {
                Zaposlenik zaposlenik = null;

            string sql = $"SELECT z.*, k.Ime, k.Prezime, k.Lozinka, p.Pozicija FROM Zaposlenik z JOIN Korisnik k ON z.IdKorisnik = k.IdKorisnik JOIN Pozicije p ON z.IdPozicija = p.IdPozicija WHERE KorisnickoIme = '{korisnickoIme}'";


            DB.OpenConnection();

                var reader = DB.GetDataReader(sql);

                if (reader.HasRows)
                {
                    reader.Read();
                    zaposlenik = CreateObject(reader);
                    reader.Close();
                }
                DB.CloseConnection();
                return zaposlenik;
            }

        public static List<Zaposlenik> DajZaposlenike()
        {
            var zaposlenici = new List<Zaposlenik>();

            string sql = @"SELECT z.*, k.Ime, k.Prezime, k.Lozinka, p.Pozicija
                   FROM Zaposlenik z
                   JOIN Korisnik k ON z.IdKorisnik = k.IdKorisnik
                   JOIN Pozicije p ON z.IdPozicija = p.IdPozicija";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zaposlenik zaposlenik = CreateObject(reader);
                zaposlenici.Add(zaposlenik);
            }

            reader.Close();
            DB.CloseConnection();

            return zaposlenici;
        }

        public static Zaposlenik GetRandomBlagajnik()
        {
            Zaposlenik zaposlenik = null;

            string sql = @"SELECT TOP 1 z.IdZaposlenik, k.Ime, k.Prezime, k.Lozinka, z.KorisnickoIme, p.Pozicija FROM Zaposlenik z
                            JOIN Korisnik k ON z.IdKorisnik = k.IdKorisnik JOIN Pozicije p ON z.IdPozicija = p.IdPozicija
                            WHERE z.IdPozicija = '2' ORDER BY NEWID()";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int idZaposlenik = int.Parse(reader["IdZaposlenik"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string pozicija = reader["Pozicija"].ToString();
            string korisnickoIme = reader["KorisnickoIme"].ToString();

            var zaposlenik = new Zaposlenik
            {
                IdZaposlenik = idZaposlenik,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                Pozicija = pozicija,
                KorisnickoIme = korisnickoIme
            };

            return zaposlenik;
        }

        public static Zaposlenik GetRandomEmployee()
        {
            List<Zaposlenik> employees = DajZaposlenike();
            Random rand = new Random();
            int index = rand.Next(employees.Count);
            return employees[index];
        }
        public static void DeleteZaposlenik(Zaposlenik zaposlenik)
        {
            string zaposlenikSql = $"DELETE FROM Zaposlenik WHERE IdZaposlenik = {zaposlenik.IdZaposlenik}";
            string korisnikSql = $"DELETE FROM Korisnik WHERE IdKorisnik = {zaposlenik.IdKorisnik}";

            try
            {
                DB.OpenConnection();

                DB.ExecuteCommand(zaposlenikSql);
                DB.ExecuteCommand(korisnikSql);

                DB.CloseConnection();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                DB.CloseConnection();
            }
        }
    }
}
