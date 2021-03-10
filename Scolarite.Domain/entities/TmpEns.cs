using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class TmpEns
    {
        public string EmpNom { get; set; }
        public string EmpPrenom { get; set; }
        public string EmpSituation { get; set; }
        public string EmpCivilite { get; set; }
        public string EmpNumP { get; set; }
        public string EmpDateP { get; set; }
        public string EmpDateNaiss { get; set; }
        public string EmpRecrutDate { get; set; }
        public string EchCode { get; set; }
        public string EchlCode { get; set; }
        public string DateEchelle { get; set; }
        public string DateEchelon { get; set; }
        public string DeptCode { get; set; }
        public string TypeEns { get; set; }
    }
}
