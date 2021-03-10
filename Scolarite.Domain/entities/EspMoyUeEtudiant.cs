using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspMoyUeEtudiant
    {
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public string CodeUe { get; set; }
        public string CodeCl { get; set; }
        public bool? NiveauAcces { get; set; }
        public decimal? NbEcts { get; set; }
        public string TypeMoy { get; set; }
        public decimal? Moyenne { get; set; }
        public string Utilisateur { get; set; }
        public decimal? MoyUeSavedP { get; set; }

        public virtual EspUe EspUe { get; set; }
    }
}
