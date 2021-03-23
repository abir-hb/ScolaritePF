using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAssRubEtIns
    {
        public string CodeRub { get; set; }
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public DateTime DateOp { get; set; }
        public DateTime? DateLastModif { get; set; }
        public decimal? MontantOp { get; set; }
        public string UserName { get; set; }
        public string ModeRglt { get; set; }
        public string NumPiece { get; set; }
        public DateTime? DatePiece { get; set; }
        public string Banque { get; set; }
        public int? NumRecu { get; set; }
        public string Objet { get; set; }
    }
}
