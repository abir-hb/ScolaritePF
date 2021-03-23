using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCompteur
    {
        public string CodeCpt { get; set; }
        public string AnneeCpt { get; set; }
        public string DesignationCpt { get; set; }
        public string AutoCpt { get; set; }
        public int? NumAuto { get; set; }
        public byte? TailleCpt { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? DateLastModif { get; set; }
    }
}
