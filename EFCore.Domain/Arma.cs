﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Arma
    {
        public int Id { get; set; }
        public string ArmaNome { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }

    }
}
