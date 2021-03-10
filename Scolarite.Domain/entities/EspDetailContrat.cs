using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspDetailContrat
    {
        public string Numord { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public byte NbHeures { get; set; }
        public string Periode { get; set; }
    }
}
