﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEncadrementGp
    {
        public string IdProjet { get; set; }
        public string AnneeDeb { get; set; }
        public string TypeProjet { get; set; }
        public string IdEns { get; set; }
        public string CodeCl { get; set; }
        public DateTime? DateEnc { get; set; }
        public DateTime? HeureDeb { get; set; }
        public DateTime? HeureFin { get; set; }
        public DateTime? Duree { get; set; }
        public byte? AvTech { get; set; }
        public byte? AvAng { get; set; }
        public byte? AvFr { get; set; }
        public byte? AvRapport { get; set; }
        public byte? AvCc { get; set; }
        public string Comportement { get; set; }
        public string RemarqueObs { get; set; }
        public string TravauxDemande { get; set; }
        public byte? NoteGroupe { get; set; }
        public string IdGroupeProjet { get; set; }
    }
}
