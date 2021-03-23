using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspGroupeProjet
    {
        public string IdGroupe { get; set; }
        public string IdProjet { get; set; }
        public string NomGroupe { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }

        public virtual Classe CodeClNavigation { get; set; }
        public virtual EspProjet IdProjetNavigation { get; set; }
    }
}
