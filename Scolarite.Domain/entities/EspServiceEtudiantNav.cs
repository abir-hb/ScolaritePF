using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspServiceEtudiantNav
    {
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeService { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string Actif { get; set; }
        public string Laureat { get; set; }
        public string AnneePremInscription { get; set; }
        public string CodeDevise { get; set; }
        public string Classe { get; set; }
        public string Numcompte { get; set; }
        public bool? Etab { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
