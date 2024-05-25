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
    public class MealRepository
    {
        public static Jelo DajJelo(string IdJelo)
        {
            Jelo jelo = null;

            string sql = "SELECT * FROM Jelo WHERE IdJelo = {IdJelo}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                jelo = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return jelo;
        }

        public static List<Jelo> DajJela()
        {
            var jela = new List<Jelo>();

            string sql = "SELECT J.*, V.NazivVrsteJela FROM Jelo J INNER JOIN VrsteJela V ON J.IdVrstaJela = V.IdVrstaJela;";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Jelo jelo = CreateObject(reader);
                jela.Add(jelo);
            }

            reader.Close();
            DB.CloseConnection();

            return jela;
        }

        private static Jelo CreateObject(SqlDataReader reader)
        {
            int idJelo = int.Parse(reader["IdJelo"].ToString());
            string nazivJela = reader["NazivJela"].ToString();
            int idVrstaJela = int.Parse(reader["IdVrstaJela"].ToString());

            var jelo = new Jelo
            {
                IdJelo = idJelo,
                NazivJela = nazivJela,
                IdVrstaJela = idVrstaJela
            };

            return jelo;
        }

        public static List<Jelo> FiltrirajPremaPredjelima(string sql)
        {
            var jela = new List<Jelo>();
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Jelo jelo = CreateObject(reader);
                jela.Add(jelo);
            }

            reader.Close();
            DB.CloseConnection();

            return jela;
        }

        public static int DajSljedeceg()
        {
            string sql = "SELECT ISNULL(MAX(IdJelo), 0) + 1 FROM Jelo";

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

        public static void DodajJelo(Jelo jelo)
        {
            string sql = $"INSERT INTO Jelo (NazivJela, IdVrstaJela) " +
             $"VALUES ('{jelo.NazivJela}', '{jelo.IdVrstaJela}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
