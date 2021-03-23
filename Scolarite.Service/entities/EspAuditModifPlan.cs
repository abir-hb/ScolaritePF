using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditModifPlan
    {
        public DateTime DateModif { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string Username { get; set; }
        public string NomMachine { get; set; }
        public string IpMachine { get; set; }
        public string CodeUe { get; set; }
        public string NewCodeUe { get; set; }
        public decimal? Coef { get; set; }
        public decimal? NewCoef { get; set; }
        public string ExisteCc { get; set; }
        public string NewExisteCc { get; set; }
        public string ExisteTp { get; set; }
        public string NewExisteTp { get; set; }
        public string IdEns { get; set; }
        public string NewIdEns { get; set; }
        public string IdEns2 { get; set; }
        public string NewIdEns2 { get; set; }
        public string IdEns3 { get; set; }
        public string NewIdEns3 { get; set; }
        public byte? NbEcts { get; set; }
        public byte? NewNbEcts { get; set; }
        public string TypeEpreuve { get; set; }
        public string NewTypeEpreuve { get; set; }
        public string TypeEpreuveSr { get; set; }
        public string NewTypeEpreuveSr { get; set; }
        public decimal? NbHeures { get; set; }
        public decimal? NewNbHeures { get; set; }
    }
}
