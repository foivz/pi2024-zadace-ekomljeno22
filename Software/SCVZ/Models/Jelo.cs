﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Jelo
    {
        public int IdJelo { get; set; }
        public string NazivJela {  get; set; }

        public int IdVrstaJela { get; set; }

        public override string ToString()
        {
            return NazivJela;
        }
    }
}
