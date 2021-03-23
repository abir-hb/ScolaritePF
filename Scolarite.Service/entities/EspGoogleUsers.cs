using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspGoogleUsers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string OrgUnitPath { get; set; }
        public string Status { get; set; }
        public string FullName { get; set; }
    }
}
