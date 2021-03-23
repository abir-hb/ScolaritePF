using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class TempCreditTic
    {
        public string Pole { get; set; }
        public string Jour { get; set; }
        public DateTime? DateRat { get; set; }
        public string HeureRat { get; set; }
        public string CodeModule { get; set; }
        public string Designation { get; set; }
    }
}
