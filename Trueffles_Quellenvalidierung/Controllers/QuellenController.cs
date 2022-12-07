using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trueffles_Quellenvalidierung.ContextDb;
using Trueffles_Quellenvalidierung.Models;
using Trueffles_Quellenvalidierung.Funktionen;

namespace Trueffles_Quellenvalidierung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuellenController : ControllerBase
    {
        private readonly Context _context;

        public QuellenController(Context context)
        {
            _context = context;
        }

        // GET: api/Quellen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quellen>>> GetQuellen()
        {
            if (_context.Quellen == null)
            {
                return NotFound();
            }
            return await _context.Quellen.ToListAsync();
        }

        // GET: api/Quellen/5
        [HttpGet("{url}")]
        public async Task<ActionResult<Quellen>> GetQuellen(string URL)
        {
            if (_context.Quellen == null)
            {
                return NotFound();
            }

            var quellen = await _context.Quellen.FindAsync(URL);

            if (quellen == null)
            {
                return NotFound();
            }

            return quellen;
        }

        // PUT: api/Quellen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuellen(string id, Quellen quellen)
        {
            if (id != quellen.ID)
            {
                return BadRequest();
            }

            _context.Entry(quellen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuellenExists(id))
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

        // POST: api/Quellen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Quellen>> PostQuellen(Quellen quellen)
        {
            if (_context.Quellen == null)
            {
                return NotFound();
            }

            quellen.ID = new uuid().CreateUUID();
            quellen.Createdatum = DateTime.Now;

            _context.Quellen.Add(quellen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (QuellenExists(quellen.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetQuellen", new { id = quellen.ID }, quellen);
        }

        // DELETE: api/Quellen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuellen(string id)
        {
            if (_context.Quellen == null)
            {
                return NotFound();
            }
            var quellen = await _context.Quellen.FindAsync(id);
            if (quellen == null)
            {
                return NotFound();
            }

            _context.Quellen.Remove(quellen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuellenExists(string id)
        {

            return (_context.Quellen?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
