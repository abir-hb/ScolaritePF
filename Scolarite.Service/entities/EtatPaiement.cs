using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EtatPaiement
    {
        public string IdEt { get; set; }
        public string Expiration { get; set; }
        public string Cardholdername { get; set; }
        public string Depositamount { get; set; }
        public string Currency { get; set; }
        public string Authcode { get; set; }
        public string Errorcode { get; set; }
        public string Errormessage { get; set; }
        public string Orderstatus { get; set; }
        public string Ordernumber { get; set; }
        public string Pan { get; set; }
        public string Amount { get; set; }
        public string Ip { get; set; }
        public string AnneeDeb { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
