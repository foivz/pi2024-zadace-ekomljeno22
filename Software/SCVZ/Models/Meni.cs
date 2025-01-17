using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Meni
    {
        public int IdMeni { get; set; }
        public decimal CijenaMenija { get; set; }
        public int IdVrstaMenija { get; set; }
        public int VrijednostPoklonBodova { get; set; }
        public TimeSpan VrijemePripreme { get; set; }

        public List<Jelo> stavkeMenija { get; set; }
        public List<Recenzije> recenzijeMenija { get; set; }

        public Meni() { 
            stavkeMenija = new List<Jelo>();
            recenzijeMenija = new List<Recenzije>();
        }
    }
}
