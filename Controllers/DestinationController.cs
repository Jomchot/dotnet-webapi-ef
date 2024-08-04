using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.Data;
using dotnet_webapi_ef.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi_ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinationController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public DestinationController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll(){
            var destination = _context.Destinations
            .Select(d => d.ToDestinationDTO());
            return Ok(destination);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id){
            var destination = _context.Destinations.Find(id);
            if(destination == null){
                return NotFound();
            }
            return Ok(destination);
        }

    }
}