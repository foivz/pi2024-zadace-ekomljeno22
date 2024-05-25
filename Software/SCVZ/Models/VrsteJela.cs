using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class VrsteJela
    {
        public int IdVrstaJela { get; set; }
        public string NazivVrsteJela { get; set; }

        public override string ToString()
        {
            return NazivVrsteJela;
        }
    }
}
