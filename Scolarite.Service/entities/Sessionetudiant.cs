using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Sessionetudiant
    {
        public int Idsessionet { get; set; }
        public string Password { get; set; }
        public string Matricule { get; set; }
        public string Email { get; set; }
    }
}
