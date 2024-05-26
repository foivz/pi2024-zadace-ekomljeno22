using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Korisnik
    {
        public int IdKorisnik { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public bool CheckPassword(string lozinka)
        {
            return Lozinka == lozinka;
        }

    }
}
