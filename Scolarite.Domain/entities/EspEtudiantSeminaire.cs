using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEtudiantSeminaire
    {
        public int SeminaireIdseminaire { get; set; }
        public string EtdsIdEt { get; set; }

        public virtual Seminaire SeminaireIdseminaireNavigation { get; set; }
    }
}
