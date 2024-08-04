using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.Data;
using dotnet_webapi_ef.Mappers;
using dotnet_webapi_ef.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi_ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripController : ControllerBase
    {
        // Attribute context is private and readonly
        // _name => only use in this class => this.xxxx
        private readonly ApplicationDBContext _context;
        public TripController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll(){
             var trips = _context.Trips
             .Include(t => t.Destination)
             .Select(t => t.ToTripDTO());
            return Ok(trips);
        }
        
        //Get http://localjkghj/api/trip/{id}
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id){
            var trip = _context.Trips.Include(t => t.Destination)
            .Where(t => t.Idx == id).FirstOrDefault();
            if(trip == null){
                return NotFound();
            }
            return Ok(trip);
        }
    }
   
}