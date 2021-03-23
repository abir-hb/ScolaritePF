using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspGoogleMeet
    {
        public string DateMeet { get; set; }
        public string CodeMeet { get; set; }
        public string OrganizerMail { get; set; }
        public string ParticipantName { get; set; }
    }
}
