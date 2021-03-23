using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAbsenceList
    {
        public decimal Id { get; set; }
        public DateTime? Dt { get; set; }
        public string Idprof { get; set; }
        public string Idclasse { get; set; }
        public string Idcreneau { get; set; }
        public string Idmodule { get; set; }
        public string Idagent { get; set; }
        public string Semestre { get; set; }
        public string AnneeDeb { get; set; }
    }
}
