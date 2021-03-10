using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEtudiantNoteGroupe
    {
        public string IdGroupeProjet { get; set; }
        public string IdEt { get; set; }
        public byte NoteEt { get; set; }
        public string IdEns { get; set; }
        public string Remarque { get; set; }
        public string AbsEt { get; set; }
        public DateTime? DateEval { get; set; }
    }
}
