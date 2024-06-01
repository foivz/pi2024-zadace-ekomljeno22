using DBLayer;
using SCVZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SCVZ.Repositories
{
    public class MealTypeRepository
    {
        public static VrsteJela DajVrstaJela(int idVrstaJela)
        {
            VrsteJela vrsteJela = null;

            string sql = $"SELECT * FROM VrsteJela WHERE IdVrstaJela = {idVrstaJela}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                vrsteJela = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vrsteJela;
        }

        public static List<VrsteJela> DajVrsteJela()
        {
            var vrsteJelaList = new List<VrsteJela>();

            string sql = "SELECT * FROM VrsteJela";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VrsteJela vrsteJela = CreateObject(reader);
                vrsteJelaList.Add(vrsteJela);
            }

            reader.Close();
            DB.CloseConnection();

            return vrsteJelaList;
        }
        public static List<VrsteJela> GetVrsteJelaForJelo(int idVrstaJela)
        {
            List<VrsteJela> vrsteJelaList = new List<VrsteJela>();

            string sql = $"SELECT * FROM VrsteJela WHERE IdVrstaJela = {idVrstaJela}";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VrsteJela vrstaJela = new VrsteJela
                {
                    IdVrstaJela = Convert.ToInt32(reader["IdVrstaJela"]),
                    NazivVrsteJela = reader["NazivVrsteJela"].ToString()
                };
                vrsteJelaList.Add(vrstaJela);
            }

            reader.Close();
            DB.CloseConnection();

            return vrsteJelaList;
        }



        private static VrsteJela CreateObject(SqlDataReader reader)
        {
            int idVrstaJela = int.Parse(reader["IdVrstaJela"].ToString());
            string nazivVrsteJela = reader["NazivVrsteJela"].ToString();

            var vrstaJela = new VrsteJela
            {
                IdVrstaJela = idVrstaJela,
                NazivVrsteJela = nazivVrsteJela,
            };

            return vrstaJela;
        }
    }
}
