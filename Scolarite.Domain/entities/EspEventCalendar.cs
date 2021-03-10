using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEventCalendar
    {
        public string IdEvent { get; set; }
        public string Attachments { get; set; }
        public string Attendees { get; set; }
        public string ConferenceData { get; set; }
        public string Creator { get; set; }
        public string DateCreated { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string DateUpdated { get; set; }
        public string Description { get; set; }
        public string Etag { get; set; }
        public string HangoutLink { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
    }
}
