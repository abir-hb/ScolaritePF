﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspProjetNew
    {
        public string AnneeDeb { get; set; }
        public string IdProjet { get; set; }
        public string NomProjet { get; set; }
        public string CodeModule { get; set; }
        public string TypeProjet { get; set; }
        public string DescriptionProjet { get; set; }
        public string Technologies { get; set; }
        public string Methodologie { get; set; }
        public bool? NiveauEtudiant { get; set; }
        public byte? Duree { get; set; }
        public bool? Semestre { get; set; }
        public bool? Periode { get; set; }
        public string IdGroupeProjet { get; set; }
        public string CodeCl { get; set; }
    }
}
