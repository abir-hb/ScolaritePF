using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspJournalInscription
    {
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string IdEt { get; set; }
        public string NomColonne { get; set; }
        public string TypeOp { get; set; }
        public DateTime DateOp { get; set; }
        public string Utilisateur { get; set; }
        public string ValeurInit { get; set; }
        public string ValeurFinal { get; set; }
        public string AdresseIp { get; set; }
        public string Machine { get; set; }
    }
}
