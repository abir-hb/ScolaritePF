using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Commentaire
    {
        public int IdCommentaire { get; set; }
        public string CommentaireText { get; set; }
        public int Absence { get; set; }
        public string EtdIdEt { get; set; }
    }
}
