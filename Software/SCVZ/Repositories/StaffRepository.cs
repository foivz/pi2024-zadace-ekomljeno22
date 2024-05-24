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
        public static Zaposlenik DajZaposlenika(string IdKorisnik)
        {
            Zaposlenik zaposlenik  = null;

            string sql = "SELECT * FROM Zaposlenik WHERE IdKorisnik = {IdKorisnik}";
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

            string sql = "SELECT K.*, P.Pozicija FROM Korisnik K INNER JOIN Zaposlenik Z ON K.IdKorisnik = Z.IdKorisnik INNER JOIN Pozicije P ON Z.IdPozicija = P.IdPozicija;";
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
            int idKorisnik = int.Parse(reader["IdKorisnik"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string pozicija = reader["Pozicija"].ToString();

            var zaposlenik = new Zaposlenik
            {
                IdKorisnik = idKorisnik,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                Pozicija = pozicija
            };

            return zaposlenik;
        }
    }
}
