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
    public class MenuTypeRepository
    {
        public static VrstaMenija DajVrstuMenija(int idVrstaMenija)
        {
            VrstaMenija vrstaMenija = null;

            string sql = $"SELECT * FROM VrstaMenija WHERE IdVrstaMenija = {idVrstaMenija}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                vrstaMenija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vrstaMenija;
        }

        public static List<VrstaMenija> GetMenuTypesForMenu(int menuId)
        {
            List<VrstaMenija> menuTypes = new List<VrstaMenija>();

            string sql = $"SELECT * FROM VrstaMenija WHERE IdVrstaMenija IN (SELECT IdVrstaMenija FROM Meni WHERE IdMeni = {menuId})";

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VrstaMenija menuType = new VrstaMenija
                {
                    IdVrstaMenija = Convert.ToInt32(reader["IdVrstaMenija"]),
                    NazivVrstaMenija = reader["NazivVrstaMenija"].ToString()
                };
                menuTypes.Add(menuType);
            }

            reader.Close();
            DB.CloseConnection();

            return menuTypes;
        }
        public static List<VrstaMenija> DajVrsteMenija()
        {
            var vrsteMenijaList = new List<VrstaMenija>();

            string sql = "SELECT * FROM VrstaMenija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VrstaMenija vrstaMenija = CreateObject(reader);
                vrsteMenijaList.Add(vrstaMenija);
            }

            reader.Close();
            DB.CloseConnection();

            return vrsteMenijaList;
        }

        private static VrstaMenija CreateObject(SqlDataReader reader)
        {
            int idVrstaMenija = int.Parse(reader["IdVrstaMenija"].ToString());
            string nazivVrstaMenija = reader["NazivVrstaMenija"].ToString();

            var vrstaMenijaObj = new VrstaMenija
            {
                IdVrstaMenija = idVrstaMenija,
                NazivVrstaMenija = nazivVrstaMenija
            };

            return vrstaMenijaObj;
        }

    }
}
