﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Narudzba
    {
        public int IdNarudzba {  get; set; }
        public DateTime DatumNarudzbe {  get; set; }
        public int IdMeni { get; set; }
        public int IdZaposlenik { get; set; }
    }
}
