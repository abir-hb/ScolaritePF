using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Comite
    {
        public int IdGrp { get; set; }
        public string Salle { get; set; }
        public string Nom { get; set; }
        public string Dateethour { get; set; }
        public string NomSpecialite { get; set; }
    }
}
