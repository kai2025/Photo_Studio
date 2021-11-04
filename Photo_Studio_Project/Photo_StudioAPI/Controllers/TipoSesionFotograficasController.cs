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
    public class TipoSesionFotograficasController : ControllerBase
    {
        private readonly PhotoStudioDbContext _context;

        public TipoSesionFotograficasController(PhotoStudioDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoSesionFotograficas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoSesionFotografica>>> GetTipoSesionFotograficas()
        {
            return await _context.TipoSesionFotograficas.ToListAsync();
        }

        // GET: api/TipoSesionFotograficas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoSesionFotografica>> GetTipoSesionFotografica(int id)
        {
            var tipoSesionFotografica = await _context.TipoSesionFotograficas.FindAsync(id);

            if (tipoSesionFotografica == null)
            {
                return NotFound();
            }

            return tipoSesionFotografica;
        }

        // PUT: api/TipoSesionFotograficas/5
        // To protect from overposting attacks, see http://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoSesionFotografica(int id, TipoSesionFotografica tipoSesionFotografica)
        {
            if (id != tipoSesionFotografica.IdTipo)
            {
                return BadRequest();
            }

            _context.Entry(tipoSesionFotografica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoSesionFotograficaExists(id))
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

        // POST: api/TipoSesionFotograficas
        // To protect from overposting attacks, see http://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoSesionFotografica>> PostTipoSesionFotografica(TipoSesionFotografica tipoSesionFotografica)
        {
            _context.TipoSesionFotograficas.Add(tipoSesionFotografica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoSesionFotografica", new { id = tipoSesionFotografica.IdTipo }, tipoSesionFotografica);
        }

        // DELETE: api/TipoSesionFotograficas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoSesionFotografica(int id)
        {
            var tipoSesionFotografica = await _context.TipoSesionFotograficas.FindAsync(id);
            if (tipoSesionFotografica == null)
            {
                return NotFound();
            }

            _context.TipoSesionFotograficas.Remove(tipoSesionFotografica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoSesionFotograficaExists(int id)
        {
            return _context.TipoSesionFotograficas.Any(e => e.IdTipo == id);
        }
    }
}
