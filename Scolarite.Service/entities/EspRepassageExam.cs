using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspRepassageExam
    {
        public string IdEt { get; set; }
        public string CodeModule { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string Motif { get; set; }
        public string DescriptionAbs { get; set; }
        public string AnneeDeb { get; set; }
        public string Etat { get; set; }
        public string DateExamen { get; set; }
        public string CodeCl { get; set; }
        public string CodeUe { get; set; }
        public string Observation { get; set; }
        public string RepondreDemande { get; set; }
        public string Reponse1 { get; set; }
        public string Reponse2 { get; set; }
        public string Reponse3 { get; set; }
        public string Salle { get; set; }
        public string Heure { get; set; }
    }
}
