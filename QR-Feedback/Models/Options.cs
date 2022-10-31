using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QR_Feedback.Models
{
    public partial class Options
    {
        public Options()
        {
            Responses = new HashSet<Responses>();
        }

        public int OptionId { get; set; }
        public string Text { get; set; }
        public string TextGujarati { get; set; }
        public int? QuestionId { get; set; }

        public virtual Questions Question { get; set; }
        public virtual ICollection<Responses> Responses { get; set; }
    }
}
