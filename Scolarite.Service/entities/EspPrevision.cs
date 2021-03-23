﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspPrevision
    {
        public string AnneeDeb { get; set; }
        public string CategorieClasse { get; set; }
        public bool NiveauAcces { get; set; }
        public int? EffectifPrevue { get; set; }
        public int? EffectifReel { get; set; }
        public DateTime? DateLastModif { get; set; }
        public byte? NbClasse { get; set; }
        public string CodeSpecialite { get; set; }
        public decimal? ScoreMinAdmis { get; set; }
        public byte? NbEtudiantVentile { get; set; }
        public decimal? ScoreRejet { get; set; }
        public byte? NbEtudiantRejet { get; set; }
        public decimal? ScoreMinS2 { get; set; }
        public byte? NbEtudiantS2 { get; set; }
    }
}
