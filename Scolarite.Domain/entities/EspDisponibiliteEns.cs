using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspDisponibiliteEns
    {
        public string IdDispo { get; set; }
        public string IdEns { get; set; }
        public decimal? SeanceD { get; set; }
        public decimal? SeanceF { get; set; }
        public DateTime? Jours { get; set; }
        public string AnneeDeb { get; set; }
        public string Disponible { get; set; }
    }
}
