using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_webapi_ef.DTOs.destination
{
    public class DestinationDTO
    {
        
        public int Idx { get; set; }
        public string Zone { get; set; } = null!;
        // public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}