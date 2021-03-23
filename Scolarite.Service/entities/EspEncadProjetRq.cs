using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEncadProjetRq
    {
        public string IdEncadrement { get; set; }
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string Type { get; set; }
        public decimal? Semestre { get; set; }
        public DateTime? DateSeance { get; set; }
        public string Observation { get; set; }
        public string NiveauFr { get; set; }
        public string RqNiveauFr { get; set; }
        public string NiveauAng { get; set; }
        public string RqNiveauAng { get; set; }
        public decimal? AvencementTech { get; set; }
        public string RqTechnique { get; set; }
        public string ConformiteCc { get; set; }
        public string RqCc { get; set; }
        public string TacheAFaire { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string Absent { get; set; }
        public string IdGroupe { get; set; }
        public DateTime? DateProchainRdv { get; set; }
        public string IdEns { get; set; }
    }
}
