using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTraceCorrectNumcpt
    {
        public string IdEt { get; set; }
        public DateTime DateCorrect { get; set; }
        public string TypeCorrect { get; set; }
        public string OldNumcpt { get; set; }
        public string NewNumcpt { get; set; }
    }
}
