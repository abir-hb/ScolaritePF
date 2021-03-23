using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspDept
    {
        public string CodeDept { get; set; }
        public string LibelleDept { get; set; }
        public DateTime? DateCr { get; set; }
        public DateTime? DateDernierModif { get; set; }
        public string CodeTrie { get; set; }
    }
}
