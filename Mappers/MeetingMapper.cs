using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.DTOs;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi_ef.Mappers
{
    public static class MeetingMappers
    {
        public static Meeting ToMeeting(this MeetingDTO meetingDTO){
            return new Meeting{
                Idx = meetingDTO.Idx,
                Detail = meetingDTO.Detail,
                Meetingdatetime = meetingDTO.Meetingdatetime,
                Latitude = meetingDTO.Latitude,
                Longitude = meetingDTO.Longitude
                
            };
        }
        public static MeetingDTO ToMeetingDTO(this Meeting meeting){
            return new MeetingDTO{
                Idx = meeting.Idx,
                Detail = meeting.Detail,
                Meetingdatetime = meeting.Meetingdatetime,
                Latitude = meeting.Latitude,
                Longitude = meeting.Longitude
                
            };
        }
    }
}