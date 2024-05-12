using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Student : Korisnik
    {
        public int BrojPoklonBodova { get; set; }
        public int BrojKupona { get; set; }
    }
}
