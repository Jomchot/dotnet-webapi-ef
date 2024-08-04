using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.Data;
using dotnet_webapi_ef.DTOs;
using dotnet_webapi_ef.Mappers;
using dotnet_webapi_ef.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi_ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MettingController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public MettingController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var meettings = _context.Meetings;
            return Ok(meettings);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var meetting = _context.Meetings.Find(id);
            return Ok(meetting);
        }
        [HttpPost]
        public IActionResult InsertMeeting([FromBody] MeetingDTO meetingDTO)
        {
            var meeting = meetingDTO.ToMeeting();
            _context.Meetings.Add(meeting);
            int affect = _context.SaveChanges();
            if (affect > 0)
            {
                return CreatedAtAction(nameof(GetById), new { id = meeting.Idx }, meetingDTO);
            }
            return StatusCode(400);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMeeting([FromRoute] int id)
        {
            Meeting meeting = _context.Meetings.Find(id);
            if (meeting != null)
            {
                _context.Meetings.Remove(meeting);
                int affect = _context.SaveChanges();
                if (affect > 0)
                {
                    return Ok();
                }
            }
            return StatusCode(400);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMeeting([FromRoute] int id, [FromBody] MeetingDTO meetingDTO)
        {
            Meeting meeting = _context.Meetings.Find(id);
            if (meeting != null)
            {
                meeting.Detail = meetingDTO.Detail;
                meeting.Meetingdatetime = meetingDTO.Meetingdatetime;
                meeting.Latitude = meetingDTO.Latitude;
                meeting.Longitude = meetingDTO.Longitude;
                
                _context.Meetings.Update(meeting);
                int affect = _context.SaveChanges();
                if (affect > 0)
                {
                    return Accepted(meeting.ToMeetingDTO());
                }
            }
            return StatusCode(400);
        }
    }

}
