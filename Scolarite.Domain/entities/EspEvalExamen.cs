using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEvalExamen
    {
        public string CodeModule { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string AnneeDeb { get; set; }
        public string Explication { get; set; }
        public string ModeEval { get; set; }
        public string QuotaExam { get; set; }
        public string IdUser { get; set; }
        public string TypeExam { get; set; }
        public string QuotaTp { get; set; }
        public string QuotaDs { get; set; }
        public string QuotaQcm { get; set; }
        public string QuotaTest { get; set; }
        public string TypeDs { get; set; }
    }
}
