﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEnteteAbsence
    {
        public string CodeModule { get; set; }
        public string AnneeDeb { get; set; }
        public bool? Semestre { get; set; }
        public string CodeCl { get; set; }
        public decimal NumSeance { get; set; }
        public DateTime DateSeance { get; set; }
        public string IdEns { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateLastModif { get; set; }
        public string Utilisateur { get; set; }
        public decimal? NewSemestre { get; set; }
    }
}
