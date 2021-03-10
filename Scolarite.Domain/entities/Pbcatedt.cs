using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Pbcatedt
    {
        public string PbeName { get; set; }
        public string PbeEdit { get; set; }
        public decimal? PbeType { get; set; }
        public decimal? PbeCntr { get; set; }
        public decimal? PbeSeqn { get; set; }
        public decimal? PbeFlag { get; set; }
        public string PbeWork { get; set; }
    }
}
