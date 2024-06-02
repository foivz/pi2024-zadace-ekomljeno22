using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ.Models
{
    public class Student : Korisnik
    {
        public int IdStudent { get; set; }
        public string JMBAG { get; set; }
        public int BrojPoklonBodova { get; set; }
        public int BrojKupona { get; set; }
    }
}
