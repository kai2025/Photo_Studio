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
    public class EstadosSesionesController : ControllerBase
    {
        private readonly PhotoStudioDbContext _context;

        public EstadosSesionesController(PhotoStudioDbContext context)
        {
            _context = context;
        }

        // GET: api/EstadosSesiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoSesion>>> GetEstadoSesions()
        {
            return await _context.EstadoSesions.ToListAsync();
        }

        // GET: api/EstadosSesiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoSesion>> GetEstadoSesion(int id)
        {
            var estadoSesion = await _context.EstadoSesions.FindAsync(id);

            if (estadoSesion == null)
            {
                return NotFound();
            }

            return estadoSesion;
        }

        // PUT: api/EstadosSesiones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoSesion(int id, EstadoSesion estadoSesion)
        {
            if (id != estadoSesion.IdStatus)
            {
                return BadRequest();
            }

            _context.Entry(estadoSesion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoSesionExists(id))
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

        // POST: api/EstadosSesiones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadoSesion>> PostEstadoSesion(EstadoSesion estadoSesion)
        {
            _context.EstadoSesions.Add(estadoSesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoSesion", new { id = estadoSesion.IdStatus }, estadoSesion);
        }

        // DELETE: api/EstadosSesiones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadoSesion(int id)
        {
            var estadoSesion = await _context.EstadoSesions.FindAsync(id);
            if (estadoSesion == null)
            {
                return NotFound();
            }

            _context.EstadoSesions.Remove(estadoSesion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadoSesionExists(int id)
        {
            return _context.EstadoSesions.Any(e => e.IdStatus == id);
        }
    }
}
