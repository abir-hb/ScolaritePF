using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSession
    {
        public int IdAdmin { get; set; }
        public int Type { get; set; }
        public string Pwd { get; set; }
        public string Lgn { get; set; }
        public string EspensIdEns { get; set; }
    }
}
