using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Appuser
    {
        public string Loginname { get; set; }
        public string Loginnameuppercase { get; set; }
        public string Password { get; set; }
    }
}
