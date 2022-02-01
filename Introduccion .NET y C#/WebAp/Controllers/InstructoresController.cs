using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAp.Context;
using WebAp.Models;

namespace WebAp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructoresController : ControllerBase
    {
        private readonly DemoContext _context;

        public InstructoresController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/Instructores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instructore>>> GetInstructores()
        {
            return await _context.Instructores.ToListAsync();
        }

        // GET: api/Instructores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instructore>> GetInstructore(short id)
        {
            var instructore = await _context.Instructores.FindAsync(id);

            if (instructore == null)
            {
                return NotFound();
            }

            return instructore;
        }

        // PUT: api/Instructores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructore(short id, Instructore instructore)
        {
            if (id != instructore.IdInstructores)
            {
                return BadRequest();
            }

            _context.Entry(instructore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructoreExists(id))
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

        // POST: api/Instructores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instructore>> PostInstructore(Instructore instructore)
        {
            _context.Instructores.Add(instructore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstructore", new { id = instructore.IdInstructores }, instructore);
        }

        // DELETE: api/Instructores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstructore(short id)
        {
            var instructore = await _context.Instructores.FindAsync(id);
            if (instructore == null)
            {
                return NotFound();
            }

            _context.Instructores.Remove(instructore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstructoreExists(short id)
        {
            return _context.Instructores.Any(e => e.IdInstructores == id);
        }
    }
}
