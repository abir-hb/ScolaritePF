using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspReclamation
    {
        public string IdEt { get; set; }
        public DateTime DateReclamation { get; set; }
        public string CodeModule { get; set; }
        public DateTime? DateAbsence { get; set; }
        public string Etat { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string TextReclamation { get; set; }
        public string TypeReclamation { get; set; }
        public bool? NumSeance { get; set; }
    }
}
