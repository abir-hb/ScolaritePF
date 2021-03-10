using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspJournalRglt
    {
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string IdEt { get; set; }
        public DateTime DateLimRglt { get; set; }
        public DateTime DateOp { get; set; }
        public string Utilisateur { get; set; }
        public string ValeurInit { get; set; }
        public string ValeurFinal { get; set; }
        public string AdresseIp { get; set; }
        public string Machine { get; set; }
    }
}
