using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.DTOs.destination;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi_ef.Mappers
{
    public static class DestinationMapper
    {
        public static DestinationDTO ToDestinationDTO(this Destination destination){
            return new DestinationDTO{
                Idx = destination.Idx,
                Zone = destination.Zone
            };
        }
    }
}