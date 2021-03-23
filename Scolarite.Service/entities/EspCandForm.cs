using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCandForm
    {
        public EspCandForm()
        {
            FormRate = new HashSet<FormRate>();
        }

        public decimal Idfromation { get; set; }
        public string IdEns { get; set; }
        public string Pesence { get; set; }
        public string Etatins { get; set; }
        public DateTime? Datemaj { get; set; }

        public virtual ICollection<FormRate> FormRate { get; set; }
    }
}
