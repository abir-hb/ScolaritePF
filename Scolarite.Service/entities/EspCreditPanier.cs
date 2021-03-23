using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCreditPanier
    {
        public string AnneeDeb { get; set; }
        public bool? Semestre { get; set; }
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public string NumPanier { get; set; }
        public string LibPanier { get; set; }
        public string TypeCredit { get; set; }
        public string EtatCredit { get; set; }
        public DateTime? DateValidation { get; set; }
        public string Utilisateur { get; set; }
        public bool NiveauEtCredit { get; set; }
    }
}
