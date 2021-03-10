using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class TypeMvt
    {
        public string TypeMvt1 { get; set; }
        public string LibelleType { get; set; }
        public DateTime? DateLastMvt { get; set; }
        public string CompteurAuto { get; set; }
        public int? NumAuto { get; set; }
        public byte? TailleCompteur { get; set; }
        public byte? CodePrix { get; set; }
        public string Designation { get; set; }
        public string Signe { get; set; }
    }
}
