using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Groupe
    {
        public string IdGroupe { get; set; }
        public string CodeCl { get; set; }
        public string Module { get; set; }
        public string AnneeDeb { get; set; }
        public decimal NumSemestre { get; set; }
        public string Designation { get; set; }
        public string Utilisateur { get; set; }
        public string IdProjet { get; set; }

        public virtual EspModule ModuleNavigation { get; set; }
        public virtual Projet Projet { get; set; }
    }
}
