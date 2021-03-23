using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSeanceExamen
    {
        public byte NumSeance { get; set; }
        public string AnneeDeb { get; set; }
        public string DateSeance { get; set; }
        public bool? Semestre { get; set; }
        public byte? NumJours { get; set; }
        public string Jours { get; set; }
        public string HeureDebut { get; set; }
        public string Duree { get; set; }
        public string Site { get; set; }
        public string Periode { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string NivEtude { get; set; }
    }
}
