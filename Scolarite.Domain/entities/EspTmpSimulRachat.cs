using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTmpSimulRachat
    {
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public decimal? MgSpAvRach { get; set; }
        public decimal? MgSpApRach { get; set; }
    }
}
