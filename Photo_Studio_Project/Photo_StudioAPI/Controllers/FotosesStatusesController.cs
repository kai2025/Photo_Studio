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
    public class FotosesStatusesController : ControllerBase
    {
        private readonly PhotoStudioDbContext _context;

        public FotosesStatusesController(PhotoStudioDbContext context)
        {
            _context = context;
        }

        // GET: api/FotosesStatuses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FotosStatus>>> GetFotosStatuses()
        {
            return await _context.FotosStatuses.ToListAsync();
        }

        // GET: api/FotosesStatuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FotosStatus>> GetFotosStatus(int id)
        {
            var fotosStatus = await _context.FotosStatuses.FindAsync(id);

            if (fotosStatus == null)
            {
                return NotFound();
            }

            return fotosStatus;
        }

        // PUT: api/FotosesStatuses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFotosStatus(int id, FotosStatus fotosStatus)
        {
            if (id != fotosStatus.IdStatus)
            {
                return BadRequest();
            }

            _context.Entry(fotosStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotosStatusExists(id))
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

        // POST: api/FotosesStatuses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FotosStatus>> PostFotosStatus(FotosStatus fotosStatus)
        {
            _context.FotosStatuses.Add(fotosStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFotosStatus", new { id = fotosStatus.IdStatus }, fotosStatus);
        }

        // DELETE: api/FotosesStatuses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFotosStatus(int id)
        {
            var fotosStatus = await _context.FotosStatuses.FindAsync(id);
            if (fotosStatus == null)
            {
                return NotFound();
            }

            _context.FotosStatuses.Remove(fotosStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FotosStatusExists(int id)
        {
            return _context.FotosStatuses.Any(e => e.IdStatus == id);
        }
    }
}
