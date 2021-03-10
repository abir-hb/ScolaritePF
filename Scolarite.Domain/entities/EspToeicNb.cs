using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspToeicNb
    {
        public DateTime? Datetest { get; set; }
        public decimal? Nbmax { get; set; }
        public decimal? NbCondidatsFr { get; set; }
        public decimal? NbCondidatsAng { get; set; }
    }
}
