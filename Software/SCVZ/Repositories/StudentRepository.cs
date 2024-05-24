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
    public class StudentRepository
    {
        public static Student DajStudenta(string IdKorisnik)
        {
            Student student = null;

            string sql = "SELECT * FROM Student WHERE IdKorisnik = {IdKorisnik}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return student;
        }

        public static List<Student> DajStudente()
        {
            var studenti = new List<Student>();

            string sql = "SELECT * FROM Student WHERE IdKorisnik = {IdKorisnik}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                studenti.Add(student);
            }

            reader.Close();
            DB.CloseConnection();

            return studenti;
        }

        private static Student CreateObject(SqlDataReader reader)
        {
            int idKorisnik = int.Parse(reader["IdKorisnik"].ToString());
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string pozicija = reader["Pozicija"].ToString();
            int brojPoklonBodova = int.Parse(reader["BrojPoklonBodova"].ToString());
            int brojKupona = int.Parse(reader["BrojKupona"].ToString());

            var student = new Student
            {
                IdKorisnik = idKorisnik,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                BrojPoklonBodova = brojPoklonBodova,
                BrojKupona = brojKupona
    };

            return student;
        }
    }
}
