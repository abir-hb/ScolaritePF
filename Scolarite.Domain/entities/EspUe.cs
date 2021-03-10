using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspUe
    {
        public EspUe()
        {
            EspModule = new HashSet<EspModule>();
            EspMoyUeEtudiant = new HashSet<EspMoyUeEtudiant>();
        }

        public string CodeUe { get; set; }
        public string LibUe { get; set; }
        public string CodeFiliere { get; set; }
        public decimal? NbEcts { get; set; }
        public byte? ChargeH { get; set; }
        public string TypeUe { get; set; }
        public string AnneeDeb { get; set; }
        public string NatureUe { get; set; }

        public virtual EspFiliere CodeFiliereNavigation { get; set; }
        public virtual ICollection<EspModule> EspModule { get; set; }
        public virtual ICollection<EspMoyUeEtudiant> EspMoyUeEtudiant { get; set; }
    }
}
