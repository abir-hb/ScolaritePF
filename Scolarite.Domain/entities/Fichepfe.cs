﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Fichepfe
    {
        public int IdFiche { get; set; }
        public string Etat { get; set; }
        public string NomEncad { get; set; }
        public string NomEntreprise { get; set; }
        public string AdressEntreprise { get; set; }
        public int? TelephoneEntreprise { get; set; }
        public string MailEntreprise { get; set; }
        public string Descriptionsujet { get; set; }
        public string Probelematiquesujet { get; set; }
        public string Fonctionnalitesujet { get; set; }
        public string Prerequisujet { get; set; }
        public string Avis { get; set; }
        public bool? Valid { get; set; }
        public bool Validateinfo { get; set; }
        public string NomEncadEsprit { get; set; }
        public bool? Regis { get; set; }
        public bool Regectedinfo { get; set; }
        public bool Rehectedstage { get; set; }
        public bool Acorrigerstage { get; set; }
        public string Dateenvoie { get; set; }
        public string EtIdEt { get; set; }
        public string AnneeDeb { get; set; }
    }
}
