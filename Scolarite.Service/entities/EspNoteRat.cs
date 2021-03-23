using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspNoteRat
    {
        public string AnneeDeb { get; set; }
        public string CodeModule { get; set; }
        public DateTime? DateDeroulement { get; set; }
        public string IdEt { get; set; }
        public string IdEns { get; set; }
        public string CodeCl { get; set; }
        public bool? Semestre { get; set; }
        public decimal? Note { get; set; }
        public byte? NbHeure { get; set; }
        public string Utilisateur { get; set; }
        public string Observation { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string TypeRat { get; set; }
        public string AnneeCredit { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
    }
}
