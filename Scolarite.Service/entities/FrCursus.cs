using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class FrCursus
    {
        public decimal IdCursus { get; set; }
        public string LibelleCursus { get; set; }
        public string AnneeCursus { get; set; }
        public string TypeCursus { get; set; }
        public string IdEns { get; set; }
        public string FinCursus { get; set; }
    }
}
