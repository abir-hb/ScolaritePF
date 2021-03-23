﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEvalClModule
    {
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string CodeCritere { get; set; }
        public byte? NbPalier1 { get; set; }
        public byte? NbPalier2 { get; set; }
        public byte? NbPalier3 { get; set; }
        public byte? NbPalier4 { get; set; }
        public byte? NbPalier5 { get; set; }
        public string IdEns { get; set; }
        public string IdEns2 { get; set; }
        public bool? NumSemestre { get; set; }
    }
}
