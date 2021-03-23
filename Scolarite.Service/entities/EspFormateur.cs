using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspFormateur
    {
        public decimal Id { get; set; }
        public string IdEns { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Autreinformation { get; set; }
        public decimal Idformation { get; set; }

        public virtual EspFormation IdformationNavigation { get; set; }
    }
}
