using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAbsNotTransSite
    {
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public string DateSeance { get; set; }
        public bool? NumSeance { get; set; }
        public string CodeModule { get; set; }
        public string JustifNotTransf { get; set; }
        public string Transferrred { get; set; }
        public DateTime? DateTransf { get; set; }
    }
}
