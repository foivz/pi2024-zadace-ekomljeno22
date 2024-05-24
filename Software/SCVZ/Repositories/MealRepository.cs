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

            string sql = "SELECT J.*, V.VrstaJela FROM Jelo J INNER JOIN VrstaJela V ON J.IdVrstaJela = V.IdVrstaJela;";
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
            string opisJela = reader["OpisJela"].ToString();
            string idVrstaJela = reader["IdVrstaJela"].ToString();

            var jelo = new Jelo
            {
                IdJelo = idJelo,
                NazivJela = nazivJela,
                OpisJela = opisJela,
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

    }
}
