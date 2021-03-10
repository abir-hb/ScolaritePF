using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTraceImpPiece
    {
        public string AnneeDeb { get; set; }
        public int NumImp { get; set; }
        public DateTime? DateImp { get; set; }
        public string TypePiece { get; set; }
        public string UserImp { get; set; }
        public string MachineImp { get; set; }
        public string IpImp { get; set; }
        public string IdEt { get; set; }
    }
}
