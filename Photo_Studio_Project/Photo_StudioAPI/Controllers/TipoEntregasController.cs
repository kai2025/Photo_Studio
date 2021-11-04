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
    public class TipoEntregasController : ControllerBase
    {
        private readonly PhotoStudioDbContext _context;

        public TipoEntregasController(PhotoStudioDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoEntregas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEntrega>>> GetTipoEntregas()
        {
            return await _context.TipoEntregas.ToListAsync();
        }

        // GET: api/TipoEntregas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoEntrega>> GetTipoEntrega(int id)
        {
            var tipoEntrega = await _context.TipoEntregas.FindAsync(id);

            if (tipoEntrega == null)
            {
                return NotFound();
            }

            return tipoEntrega;
        }

        // PUT: api/TipoEntregas/5
        // To protect from overposting attacks, see http://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoEntrega(int id, TipoEntrega tipoEntrega)
        {
            if (id != tipoEntrega.IdEntrega)
            {
                return BadRequest();
            }

            _context.Entry(tipoEntrega).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoEntregaExists(id))
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

        // POST: api/TipoEntregas
        // To protect from overposting attacks, see http://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoEntrega>> PostTipoEntrega(TipoEntrega tipoEntrega)
        {
            _context.TipoEntregas.Add(tipoEntrega);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoEntrega", new { id = tipoEntrega.IdEntrega }, tipoEntrega);
        }

        // DELETE: api/TipoEntregas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoEntrega(int id)
        {
            var tipoEntrega = await _context.TipoEntregas.FindAsync(id);
            if (tipoEntrega == null)
            {
                return NotFound();
            }

            _context.TipoEntregas.Remove(tipoEntrega);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoEntregaExists(int id)
        {
            return _context.TipoEntregas.Any(e => e.IdEntrega == id);
        }
    }
}
