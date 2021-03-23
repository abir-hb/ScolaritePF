using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspUp
    {
        public EspUp()
        {
            EspModule = new HashSet<EspModule>();
        }

        public string Up { get; set; }
        public string Designantion { get; set; }
        public string CodeDept { get; set; }

        public virtual ICollection<EspModule> EspModule { get; set; }
    }
}
