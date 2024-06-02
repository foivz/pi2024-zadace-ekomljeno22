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

                // Insert into Korisnik table
                string korisnikSql = $"INSERT INTO Korisnik (Ime, Prezime, Lozinka) " +
                                     $"VALUES ('{zaposlenik.Ime}', '{zaposlenik.Prezime}', '{zaposlenik.Lozinka}')";
                DB.ExecuteCommand(korisnikSql);

                // Get the ID of the newly inserted record in Korisnik table
                string getIdSql = "SELECT SCOPE_IDENTITY()";
                int idKorisnik = Convert.ToInt32(DB.GetScalar(getIdSql));

                // Get the ID of the position (Pozicija) from the database
                int idPozicija = DajIdPozicije(zaposlenik.Pozicija);

                // Insert into Zaposlenik table
                string zaposlenikSql = $"INSERT INTO Zaposlenik (IdKorisnik, IdPozicija, KorisnickoIme) " +
                                       $"VALUES ({idKorisnik}, {idPozicija}, '{zaposlenik.KorisnickoIme}')";
                DB.ExecuteCommand(zaposlenikSql);

                Console.WriteLine($"Staff member {zaposlenik.Ime} {zaposlenik.Prezime} added successfully with ID: {idKorisnik}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the staff member: {ex.Message}");
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
