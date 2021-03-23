﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspJournalNote
    {
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public bool? Semestre { get; set; }
        public string IdEt { get; set; }
        public string TypeOp { get; set; }
        public DateTime? DateOp { get; set; }
        public string Utilisateur { get; set; }
        public decimal? OldNoteCc { get; set; }
        public decimal? NewNoteCc { get; set; }
        public decimal? OldNoteTp { get; set; }
        public decimal? NewNoteTp { get; set; }
        public decimal? OldNoteExam { get; set; }
        public decimal? NewNoteExam { get; set; }
        public string IpAddress { get; set; }
        public string NomMachine { get; set; }
        public string TypeNote { get; set; }
    }
}
