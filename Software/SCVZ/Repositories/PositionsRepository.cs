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
    public class PositionsRepository
    {
        public static Pozicije DajPozicije(int idPozicija)
        {
            Pozicije pozicije = null;

            string sql = $"SELECT * FROM Pozicije WHERE IdPozicija = {idPozicija}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                pozicije = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return pozicije;
        }

        public static List<Pozicije> DajPozicije()
        {
            var pozicijeList = new List<Pozicije>();

            string sql = "SELECT * FROM Pozicije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Pozicije pozicije = CreateObject(reader);
                pozicijeList.Add(pozicije);
            }

            reader.Close();
            DB.CloseConnection();

            return pozicijeList;
        }

        private static Pozicije CreateObject(SqlDataReader reader)
        {
            int idPozicija = int.Parse(reader["IdPozicija"].ToString());
            string pozicija = reader["Pozicija"].ToString();

            var pozicije = new Pozicije
            {
                IdPozicija = idPozicija,
                Pozicija = pozicija,
            };

            return pozicije;
        }
    }
}
