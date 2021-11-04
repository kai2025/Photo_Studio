using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photo_StudioAPI.Models;

namespace Photo_StudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SesionessController : ControllerBase
    {
        private readonly PhotoStudioDbContext _context;

        public SesionessController(PhotoStudioDbContext context)
        {
            _context = context;
        }

        // GET: api/Sesioness
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sesion>>> GetSesions()
        {
            return await _context.Sesions.ToListAsync();
        }

        // GET: api/Sesioness/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sesion>> GetSesion(int id)
        {
            var sesion = await _context.Sesions.FindAsync(id);

            if (sesion == null)
            {
                return NotFound();
            }

            return sesion;
        }

        // PUT: api/Sesioness/5
        // To protect from overposting attacks, see http://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSesion(int id, Sesion sesion)
        {
            if (id != sesion.IdSesion)
            {
                return BadRequest();
            }

            _context.Entry(sesion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SesionExists(id))
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

        // POST: api/Sesioness
        // To protect from overposting attacks, see http://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sesion>> PostSesion(Sesion sesion)
        {
            _context.Sesions.Add(sesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSesion", new { id = sesion.IdSesion }, sesion);
        }

        // DELETE: api/Sesioness/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSesion(int id)
        {
            var sesion = await _context.Sesions.FindAsync(id);
            if (sesion == null)
            {
                return NotFound();
            }

            _context.Sesions.Remove(sesion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SesionExists(int id)
        {
            return _context.Sesions.Any(e => e.IdSesion == id);
        }
    }
}
