using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Resume
    {
        public string DateParticipation { get; set; }
        public string StudentIdEt { get; set; }
        public int Id { get; set; }
        public string Result { get; set; }
        public string Unity { get; set; }
        public int? CriterionCodecrt { get; set; }
        public bool? FinalValidation { get; set; }
    }
}
