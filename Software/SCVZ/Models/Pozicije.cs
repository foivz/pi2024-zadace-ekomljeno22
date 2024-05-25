using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Pozicije
    {
        public int IdPozicija { get; set; }
        public string Pozicija { get; set; }

        public override string ToString()
        {
            return Pozicija;
        }
    }
}
