using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspDsExam
    {
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string AProgrammer { get; set; }
        public string TypeExam { get; set; }
        public bool? NumSemestre { get; set; }
        public bool? NumPeriode { get; set; }
        public string AnneeDeb { get; set; }
        public string DsExam { get; set; }
        public byte NumSeance { get; set; }
        public string Site { get; set; }
        public string DateSaisie { get; set; }
    }
}
