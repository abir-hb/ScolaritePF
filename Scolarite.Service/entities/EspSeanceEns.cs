﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSeanceEns
    {
        public string IdEns { get; set; }
        public string CodeModule { get; set; }
        public DateTime DateSeance { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public bool Semestre { get; set; }
        public bool? NumSeance { get; set; }
        public byte? NbSeance { get; set; }
        public string Realisation { get; set; }
        public string CodeMotif { get; set; }
        public byte? HeureEntree { get; set; }
        public int? MinuteEntree { get; set; }
        public int? HeureSortie { get; set; }
        public int? MinuteSortie { get; set; }
        public string Observation { get; set; }
        public string Utilisateur { get; set; }
        public int? NbMinPause { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
    }
}
