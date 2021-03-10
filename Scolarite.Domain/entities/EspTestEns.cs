using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTestEns
    {
        public string IdEns { get; set; }
        public string TypeChoix { get; set; }
        public DateTime DateChoix { get; set; }
        public string TypeTest { get; set; }
    }
}
