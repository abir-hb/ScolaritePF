﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEncadrement
    {
        public string IdProjet { get; set; }
        public string AnneeDeb { get; set; }
        public string TypeProjet { get; set; }
        public string IdEt { get; set; }
        public string IdEns { get; set; }
        public string CodeCl { get; set; }
        public DateTime DateEnc { get; set; }
        public string HeureDeb { get; set; }
        public string HeureFin { get; set; }
        public DateTime? Duree { get; set; }
        public byte? AvTech { get; set; }
        public string AvAng { get; set; }
        public string AvFr { get; set; }
        public byte? AvRapport { get; set; }
        public byte? AvCc { get; set; }
        public string Comportement { get; set; }
        public string RemarqueObs { get; set; }
        public string TravauxDemande { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string ObsTech { get; set; }
        public string ObsAnglais { get; set; }
        public string ObsCc { get; set; }
        public string ObsFrancais { get; set; }
        public string ObsRapport { get; set; }
        public DateTime? DateProchainEncad { get; set; }
        public string HeureProchain { get; set; }
    }
}
