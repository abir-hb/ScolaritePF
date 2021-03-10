using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspOption
    {
        public string CodeOption { get; set; }
        public string LibOption { get; set; }
        public string AnneeDeb { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
