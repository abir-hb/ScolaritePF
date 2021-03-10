using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspGpProjet
    {
        public string IdGroupeProjet { get; set; }
        public string NomGroupe { get; set; }
        public string Sujet { get; set; }
        public byte NumGroupe { get; set; }
        public string CodeCl { get; set; }
    }
}
