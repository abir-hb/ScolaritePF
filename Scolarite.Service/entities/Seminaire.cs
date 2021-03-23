﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Seminaire
    {
        public Seminaire()
        {
            EspEtudiantSeminaire = new HashSet<EspEtudiantSeminaire>();
            Noteseminaire = new HashSet<Noteseminaire>();
        }

        public int Idseminaire { get; set; }
        public DateTime? Datefin { get; set; }
        public string Libelle { get; set; }
        public string Enseignant { get; set; }
        public DateTime? Dateseminaire { get; set; }
        public DateTime? Dateexamen { get; set; }
        public string Salle { get; set; }
        public string Heuredebut { get; set; }
        public string Heurefin { get; set; }

        public virtual ICollection<EspEtudiantSeminaire> EspEtudiantSeminaire { get; set; }
        public virtual ICollection<Noteseminaire> Noteseminaire { get; set; }
    }
}
