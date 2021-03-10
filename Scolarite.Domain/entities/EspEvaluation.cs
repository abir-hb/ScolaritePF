﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEvaluation
    {
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeModule { get; set; }
        public string CodeCl { get; set; }
        public bool NumSemestre { get; set; }
        public DateTime? DateSaisie { get; set; }
        public bool? Ev1 { get; set; }
        public bool? Ev2 { get; set; }
        public bool? Ev3 { get; set; }
        public bool? Ev4 { get; set; }
        public bool? Ev5 { get; set; }
        public string PtFort { get; set; }
        public string PtFaible { get; set; }
        public string Proposition { get; set; }
        public bool? Ev6 { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
    }
}
