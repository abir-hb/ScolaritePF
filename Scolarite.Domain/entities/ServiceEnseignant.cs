using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class ServiceEnseignant
    {
        public string IdSerEn { get; set; }
        public DateTime? DateSer { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public string NomSer { get; set; }
        public string IdEns { get; set; }
        public string NatureSer { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateFinSer { get; set; }
        public string ConfirmerCup { get; set; }
        public string ConfirmerChef { get; set; }
    }
}
