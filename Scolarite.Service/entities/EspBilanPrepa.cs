﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspBilanPrepa
    {
        public decimal? BilanQ1 { get; set; }
        public string IdEt { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateMiseJour { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string AnneeDeb { get; set; }
        public decimal? BilanQ2 { get; set; }
        public decimal? BilanQ3 { get; set; }
        public decimal? BilanQ4 { get; set; }
        public decimal? BilanQ5 { get; set; }
        public decimal? BilanQ6 { get; set; }
        public decimal? BilanQ7 { get; set; }
        public decimal? BilanQ8 { get; set; }
        public decimal? BilanQ9 { get; set; }
        public decimal? BilanQ10 { get; set; }
    }
}
