using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCertif
    {
        public string NomEt { get; set; }
        public string PrenomEt { get; set; }
        public string AdresseEt { get; set; }
        public DateTime DateMisejour { get; set; }
        public DateTime DateIns { get; set; }
        public string HeureIns { get; set; }
        public string NomJeton { get; set; }
        public string IdEt { get; set; }
        public string Classe { get; set; }
        public string CodeModule { get; set; }
        public decimal? NoteExam { get; set; }
    }
}
