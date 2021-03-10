﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSuiviProjetIndiv
    {
        public string IdGroupe { get; set; }
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public DateTime DateSuivi { get; set; }
        public string HeureDeb { get; set; }
        public string HeureFin { get; set; }
        public decimal? NoteComm { get; set; }
        public decimal? NoteTechnique { get; set; }
        public decimal? NoteRedaction { get; set; }
        public decimal? NoteMotivation { get; set; }
        public string Absent { get; set; }
        public string Observation { get; set; }

        public virtual EspAffGroupEtudiant EspAffGroupEtudiant { get; set; }
    }
}
