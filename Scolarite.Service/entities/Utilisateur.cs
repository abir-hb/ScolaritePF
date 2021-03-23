using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Utilisateur
    {
        public int Code { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string FirstName { get; set; }
        public string ChefDep { get; set; }
    }
}
