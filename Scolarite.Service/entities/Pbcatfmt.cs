using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Pbcatfmt
    {
        public string PbfName { get; set; }
        public string PbfFrmt { get; set; }
        public decimal PbfType { get; set; }
        public decimal? PbfCntr { get; set; }
    }
}
