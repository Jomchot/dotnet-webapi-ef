using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi_ef.DTOs
{
    public class MeetingDTO
    {
 
        public int Idx { get; set; }
        public string Detail { get; set; } = null!;
        public string Meetingdatetime { get; set; } = null!;
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}