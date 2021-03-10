using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class HistoriquePaiement
    {
        public string IdEt { get; set; }
        public string Username { get; set; }
        public string Amount { get; set; }
        public string AnneeDeb { get; set; }
        public decimal Ordernumber { get; set; }
        public string Returnurl { get; set; }
        public string Currency { get; set; }
        public string Password { get; set; }
        public string Etat { get; set; }
        public DateTime? DatePaiement { get; set; }
        public string Orderid { get; set; }
    }
}
