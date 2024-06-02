using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ.Models
{
    public static class ConversionManager
    {
        public static int ConversionRate { get; set; } = 300;

        public static void ConvertPoklonBodoviToKupons(Student student)
        {
            int conversionRate = ConversionRate;

            if (student.BrojPoklonBodova >= conversionRate)
            {
                int kuponsToAward = student.BrojPoklonBodova / conversionRate;
                student.BrojKupona += kuponsToAward;
                student.BrojPoklonBodova %= conversionRate;

                // Update the Student table with new values
                string updateSql = $"UPDATE Student SET BrojKupona = {student.BrojKupona}, BrojPoklonBodova = {student.BrojPoklonBodova} WHERE IdStudent = {student.IdStudent}";

                try
                {
                    DB.OpenConnection();
                    DB.ExecuteCommand(updateSql);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while updating the student table: {ex.Message}");
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
        }
    }


}
