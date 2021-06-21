using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scolarite.Domain.entities
{
    public partial class EspEnseignant
    {
        public EspEnseignant()
        {
            EspModulePanierClasseSaiso = new HashSet<EspModulePanierClasseSaiso>();
        }
        [Required(ErrorMessage = "le champs Code est obligatoire")]

        public string IdEns { get; set; }
        public decimal? Cin { get; set; }
        public string CnssEns { get; set; }
        public string CodeGradeActuel { get; set; }
        public string CodeGradeEntree { get; set; }
        public DateTime? DateModifyJwtPwd { get; set; }
        public DateTime? DateRec { get; set; }
        public string Etat { get; set; }
        public string EtatCivilEns { get; set; }
        public string LibGradeActuelle { get; set; }
        public string LibGradeEntree { get; set; }
        public string MailEns { get; set; }
        public string Niveau { get; set; }
        public string NomEns { get; set; }
        public string PrenomEns { get; set; }
        public string PwdEns { get; set; }
        public string PwdInit { get; set; }
        public string PwdJwtEnseignant { get; set; }
        public string SexeEns { get; set; }
        public string Tel { get; set; }
        public string TypeEns { get; set; }
        public decimal? NbHeureEns { get; set; }
        public decimal? ChargeEns { get; set; }

        public virtual ICollection<EspModulePanierClasseSaiso> EspModulePanierClasseSaiso { get; set; }
    }
}
