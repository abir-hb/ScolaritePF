using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Quitus
    {
        public int Idquitus { get; set; }
        public string Encadeur { get; set; }
        public string Comite { get; set; }
        public string Etatfinancier { get; set; }
        public string Credit { get; set; }
        public string Depotrapport { get; set; }
        public string EtdIdEt { get; set; }
    }
}
