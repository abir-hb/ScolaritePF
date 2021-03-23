using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspConvocation
    {
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public DateTime? DateConvocation { get; set; }
        public string MotifConvocation { get; set; }
        public string ModeConvocation { get; set; }
        public string ReponseEt { get; set; }
        public DateTime? DateReception { get; set; }
        public string ConvocationParent { get; set; }
        public string Observation { get; set; }
        public string CodeCl { get; set; }
        public string Generation { get; set; }
        public DateTime? DateEnvoiMailTel { get; set; }
        public DateTime DateGeneration { get; set; }
        public string MoisGen { get; set; }
        public decimal? Moyenne { get; set; }
        public byte? NbMinJour { get; set; }
        public byte? NbMinSeance { get; set; }
    }
}
