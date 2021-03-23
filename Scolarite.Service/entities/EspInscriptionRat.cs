using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspInscriptionRat
    {
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public DateTime? DateDemande { get; set; }
        public DateTime DateRat { get; set; }
        public string HeureRat { get; set; }
        public string AnneeDeb { get; set; }
        public string Etat { get; set; }
        public string CodeModule { get; set; }
        public string TypeRat { get; set; }
    }
}
