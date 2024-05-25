using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Zaposlenik : Korisnik
    {
        public int IdZaposlenik {  get; set; }
        public string Pozicija {  get; set; }
    }
}
