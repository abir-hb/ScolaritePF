using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTempEx4
    {
        public string CodeModule { get; set; }
        public string Jour { get; set; }
        public string CodeUe { get; set; }
        public string Site { get; set; }
        public string Heure { get; set; }
        public string Cours { get; set; }
        public string CodeCl { get; set; }
        public string Type { get; set; }
        public DateTime? DateEx { get; set; }
    }
}
