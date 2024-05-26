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
        public static Zaposlenik DajZaposlenika(int idZaposlenik)
        {
            Zaposlenik zaposlenik = null;

            string sql = $"SELECT * FROM Zaposlenik WHERE IdZaposlenik = {idZaposlenik}";
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

    }
}
