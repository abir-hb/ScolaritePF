using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class TempAli
    {
        public string Site { get; set; }
        public string Seance { get; set; }
        public string Jour { get; set; }
        public DateTime? DateRat { get; set; }
        public string Heure { get; set; }
        public string Classe { get; set; }
        public string CodeUe { get; set; }
        public string CodeModule { get; set; }
        public string Module { get; set; }
    }
}
