﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Batalha
    {
        public int Id { get; set; }
        public string NomeBatalha { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public List<HeroiBatalha> Batalhas { get; set; } 
    }
}