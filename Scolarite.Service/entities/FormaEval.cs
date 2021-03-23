using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class FormaEval
    {
        public FormaEval()
        {
            FormRate = new HashSet<FormRate>();
        }

        public decimal Id { get; set; }
        public string Critere { get; set; }
        public string Indicateur { get; set; }
        public decimal Visible { get; set; }
        public decimal Typeeval { get; set; }

        public virtual ICollection<FormRate> FormRate { get; set; }
    }
}
