using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Noteseminaire
    {
        public int Idnote { get; set; }
        public decimal Note { get; set; }
        public decimal Notecontrole { get; set; }
        public int? SeminaireIdseminaire { get; set; }
        public string EtudiantIdEt { get; set; }

        public virtual Seminaire SeminaireIdseminaireNavigation { get; set; }
    }
}
