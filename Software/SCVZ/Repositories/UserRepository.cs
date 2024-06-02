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
        public static void DodajZaposlenika(Zaposlenik zaposlenik)
        {
            try
            {
                DB.OpenConnection();
                string korisnikSql = $"INSERT INTO Korisnik (Ime, Prezime, Lozinka) " +
                                     $"VALUES ('{zaposlenik.Ime}', '{zaposlenik.Prezime}', '{zaposlenik.Lozinka}')";
                DB.ExecuteCommand(korisnikSql);

                string getIdSql = "SELECT SCOPE_IDENTITY()";
                int idKorisnik = Convert.ToInt32(DB.GetScalar(getIdSql));

                int idPozicija = DajIdPozicije(zaposlenik.Pozicija);

                string zaposlenikSql = $"INSERT INTO Zaposlenik (IdKorisnik, IdPozicija, KorisnickoIme) " +
                                       $"VALUES ({idKorisnik}, {idPozicija}, '{zaposlenik.KorisnickoIme}')";
                DB.ExecuteCommand(zaposlenikSql);

                Console.WriteLine($"Zaposlenik {zaposlenik.Ime} {zaposlenik.Prezime} uspješno dodan s ID: {idKorisnik}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom unosa Zaposlenika: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        private static int DajIdPozicije(string pozicija)
        {
            string getIdPozicijaSql = $"SELECT IdPozicija FROM Pozicije WHERE Pozicija = '{pozicija}'";
            return Convert.ToInt32(DB.GetScalar(getIdPozicijaSql));
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
                    Console.WriteLine($"Sljedeći dostupan ID: {nextId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom dohvaćanja ID-a: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return nextId;
        }
    }
}
