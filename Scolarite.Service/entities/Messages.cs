using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Messages
    {
        public string Msgid { get; set; }
        public string Msgtitle { get; set; }
        public string Msgtext { get; set; }
        public string Msgicon { get; set; }
        public string Msgbutton { get; set; }
        public decimal Msgdefaultbutton { get; set; }
        public decimal Msgseverity { get; set; }
        public string Msgprint { get; set; }
        public string Msguserinput { get; set; }
    }
}
