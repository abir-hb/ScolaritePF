using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspFiliere
    {
        public EspFiliere()
        {
            EspUe = new HashSet<EspUe>();
        }

        public string CodeFiliere { get; set; }
        public string LibFiliere { get; set; }

        public virtual ICollection<EspUe> EspUe { get; set; }
    }
}
