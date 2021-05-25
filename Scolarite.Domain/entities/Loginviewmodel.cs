using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Loginviewmodel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Rememberme { get; set; }
    }
}
