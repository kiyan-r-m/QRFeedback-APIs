using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QR_Feedback.Models
{
    public partial class Stations
    {
        public int PoliceStationId { get; set; }
        public string SubDivision { get; set; }
        public string Area { get; set; }
        public string District { get; set; }
    }
}
