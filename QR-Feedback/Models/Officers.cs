using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QR_Feedback.Models
{
    public partial class Officers
    {
        public int OfficerId { get; set; }
        public string OfficerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? StationId { get; set; }

        public virtual Stations Station { get; set; }
    }
}
