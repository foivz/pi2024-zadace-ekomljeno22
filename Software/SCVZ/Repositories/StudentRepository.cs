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
            IdKorisnik = 2.ToString();
            string sql = $"SELECT s.*, k.Ime, k.Prezime, k.Lozinka FROM Student s JOIN Korisnik k ON s.IdKorisnik = k.IdKorisnik WHERE k.IdKorisnik = '{IdKorisnik}'";
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

        public static Student DajStudentaByJMBAG(string jmbag)
        {
            Student student = null;

            string sql = $"SELECT s.*, k.Ime, k.Prezime, k.Lozinka FROM Student s JOIN Korisnik k ON s.IdKorisnik = k.IdKorisnik WHERE s.JMBAG = '{jmbag}'";
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

        private int GetStudentIdByJMBAG(string jmbag)
        {
            int studentId = 0;
            try
            {
                // Fetch student details by JMBAG
                Student student = StudentRepository.DajStudentaByJMBAG(jmbag);
                if (student != null)
                {
                    studentId = student.IdStudent;
                }
            }
            catch (Exception ex)
            {
                // Handle exception, log error, etc.
                Console.WriteLine($"An error occurred while retrieving student details: {ex.Message}");
            }
            return studentId;
        }

        public static List<Student> DajStudente()
        {
            var studenti = new List<Student>();

            string sql = $"SELECT * FROM Student";
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
            int idStudent = int.Parse(reader["IdStudent"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            
            string lozinka = reader["Lozinka"].ToString();
            string jmbag = reader["JMBAG"].ToString();
            int brojPoklonBodova = int.Parse(reader["BrojPoklonBodova"].ToString());
            int brojKupona = int.Parse(reader["BrojKupona"].ToString());

            var student = new Student
            {
                IdStudent = idStudent,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                JMBAG = jmbag,
                BrojPoklonBodova = brojPoklonBodova,
                BrojKupona = brojKupona,
            };

            return student;
        }

        public static List<string> GetAllJMBAGs()
        {
            var jmbags = new List<string>();

            string sql = "SELECT JMBAG FROM Student";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                jmbags.Add(reader["JMBAG"].ToString());
            }

            reader.Close();
            DB.CloseConnection();

            return jmbags;
        }

        public static Student GetRandomStudent()
        {
            var jmbags = GetAllJMBAGs();
            if (jmbags.Count == 0)
            {
                return null; // or throw an exception if no students are found
            }

            var random = new Random();
            string randomJMBAG = jmbags[random.Next(jmbags.Count)];

            return DajStudentaByJMBAG(randomJMBAG);
        }
    }
}
