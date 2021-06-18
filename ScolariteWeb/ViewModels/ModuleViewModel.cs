using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.ViewModels
{
    public class ModuleViewModel
    {
        public EspModule Module { get; set; }
        public IEnumerable<EspModule> Modules { get; set; }
    }
}
