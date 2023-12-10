using Entities.Data_Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data.Entity;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly Context _context;

        public DoctorController(Context context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Doctor>> GetAll() => await _context.Doctors.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(Doctor), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByID(int id)
        { 
            var doctor = await _context.Doctors.FindAsync(id);
            return doctor == null ? NotFound() : Ok(doctor);
        }
        
    }
}
