using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Pbcatvld
    {
        public string PbvName { get; set; }
        public string PbvVald { get; set; }
        public decimal? PbvType { get; set; }
        public decimal? PbvCntr { get; set; }
        public string PbvMsg { get; set; }
    }
}
