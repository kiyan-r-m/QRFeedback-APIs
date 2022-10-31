using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QR_Feedback.Models
{
    public partial class Responses
    {
        public int ResponseId { get; set; }
        public int? QuestionId { get; set; }
        public int? OptionId { get; set; }
        public int? LogId { get; set; }
        public int? StationId { get; set; }

        public virtual Userlogs Log { get; set; }
        public virtual Options Option { get; set; }
        public virtual Questions Question { get; set; }
        public virtual Stations Station { get; set; }
    }
}
