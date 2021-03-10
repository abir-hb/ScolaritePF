using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class FormRate
    {
        public decimal Idformation { get; set; }
        public string IdEns { get; set; }
        public decimal IdQuestion { get; set; }
        public decimal? Rate { get; set; }
        public string Ratetext { get; set; }

        public virtual EspCandForm Id { get; set; }
        public virtual FormaEval IdQuestionNavigation { get; set; }
    }
}
