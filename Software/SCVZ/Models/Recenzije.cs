using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Recenzije
    {
        public int IdRecenzija {  get; set; }
        public decimal Ocjena { get; set; }
        public string Komentar {  get; set; }
    }
}
