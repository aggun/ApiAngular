using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private readonly Context _context;

        public PersonalController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personal>>> GetPersonal()
        {
            return await _context.Personals.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Personal>> GetPersonal(int id)
        {
            var personal = await _context.Personals.FindAsync(id);

            if (personal == null)
            {
                return NotFound();
            }

            return personal;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonal(int id, Personal personal)
        {
            if (id != personal.PersonalId)
            {
                return BadRequest();
            }

            _context.Entry(personal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        
        [HttpPost]
        public async Task<ActionResult<Personal>> PostPersonal(Personal personal)
        {
            _context.Personals.Add(personal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonal", new { id = personal.PersonalId }, personal);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonal(int id)
        {
            var personal = await _context.Personals.FindAsync(id);
            if (personal == null)
            {
                return NotFound();
            }

            _context.Personals.Remove(personal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonalExists(int id)
        {
            return _context.Personals.Any(e => e.PersonalId == id);
        }
    }
}
