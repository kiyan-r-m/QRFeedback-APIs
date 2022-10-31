using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QR_Feedback.Models
{
    public partial class Userlogs
    {
        public Userlogs()
        {
            Responses = new HashSet<Responses>();
        }

        public int LogId { get; set; }
        public string Email { get; set; }
        public byte[] Timestamp { get; set; }
        public int? IsSubmitted { get; set; }
        public int? PoliceStationId { get; set; }

        public virtual Stations PoliceStation { get; set; }
        public virtual ICollection<Responses> Responses { get; set; }
    }
}
