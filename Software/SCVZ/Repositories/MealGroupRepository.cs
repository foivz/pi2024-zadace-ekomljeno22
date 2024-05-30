using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using SCVZ.Models;

namespace SCVZ.Repositories
{
    public class MealGroupRepository
    {
        public static List<SkupJela> DajSkupoveJelaZaMenu(int idMeni)
        {
            var skupoviJela = new List<SkupJela>();

            string sql = $"SELECT * FROM SkupJela WHERE IdMeni = {idMeni}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                SkupJela skupJela = CreateObject(reader);
                skupoviJela.Add(skupJela);
            }

            reader.Close();
            DB.CloseConnection();

            return skupoviJela;
        }

        private static SkupJela CreateObject(SqlDataReader reader)
        {
            int idSkupJela = int.Parse(reader["IdSkupJela"].ToString());
            int idMeni = int.Parse(reader["IdMeni"].ToString());
            // Other properties if needed

            var skupJela = new SkupJela
            {
                IdSkupJela = idSkupJela,
                IdMeni = idMeni
                // Other properties
            };

            return skupJela;
        }

        public static void DodajSkupJela(SkupJela skupJela)
        {
            try
            {
                // Ensure that IdMeni is valid
                if (skupJela.IdMeni <= 0)
                {
                    Console.WriteLine("Invalid IdMeni for SkupJela.");
                    return;
                }

                // Construct the SQL query
                string sql = $"INSERT INTO SkupJela (IdMeni, IdJelo) VALUES ({skupJela.IdMeni}, {skupJela.IdJelo})";

                // Open database connection and execute the command
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                Console.WriteLine("SkupJela added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the SkupJela: {ex.Message}");
            }
            finally
            {
                // Close the database connection
                DB.CloseConnection();
            }
        }

    }
}

