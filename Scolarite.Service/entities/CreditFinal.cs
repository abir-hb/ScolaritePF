using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class CreditFinal
    {
        public string IdEt { get; set; }
        public string Nom { get; set; }
        public string ClasseActuelle { get; set; }
        public string AnneeDeb { get; set; }
        public string ClasseCredit { get; set; }
        public string CodeUe { get; set; }
        public string LibUe { get; set; }
        public decimal? MoyUe { get; set; }
        public string CodeModule { get; set; }
        public string Designation { get; set; }
        public decimal? Note { get; set; }
        public string Anglais { get; set; }
        public string FrançAis { get; set; }
        public string AdresseMailEsp { get; set; }
    }
}
