using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspJournalOpRubrique
    {
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public string CodeRub { get; set; }
        public DateTime? DateOp { get; set; }
        public string TypeOp { get; set; }
        public decimal? OldValue { get; set; }
        public decimal? NewValue { get; set; }
        public string Utilisateur { get; set; }
    }
}
