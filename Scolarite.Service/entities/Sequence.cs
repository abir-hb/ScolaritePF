using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Sequence
    {
        public string SeqName { get; set; }
        public decimal? SeqCount { get; set; }
    }
}
