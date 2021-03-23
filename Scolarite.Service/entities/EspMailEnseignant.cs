using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspMailEnseignant
    {
        public decimal Id { get; set; }
        public string NomEns { get; set; }
        public string MailEns { get; set; }
    }
}
