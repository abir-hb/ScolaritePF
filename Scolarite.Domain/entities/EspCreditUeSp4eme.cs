using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCreditUeSp4eme
    {
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string IdEt { get; set; }
        public string CodeUe { get; set; }
        public string LibUe { get; set; }
        public decimal? Moyenne { get; set; }
    }
}
