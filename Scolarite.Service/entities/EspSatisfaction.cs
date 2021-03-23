using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSatisfaction
    {
        public int Codecrt { get; set; }
        public string CodeModule { get; set; }
        public int CodeNom { get; set; }
        public string IdEt { get; set; }
        public string NonSatisfait { get; set; }
        public string Ordinaire { get; set; }
        public string PriorityEns { get; set; }
        public string Satisfait { get; set; }
        public string AmeliorateStudy { get; set; }
        public string DateSurvey { get; set; }
        public string ExpressOpinion { get; set; }
        public string PriorityCoach { get; set; }
        public string Unity { get; set; }
    }
}
