using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AfaryApi.Data;
using AfaryApi.Models;

namespace AfaryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancersController : ControllerBase
    {
        private readonly DataContext _context;

        public FreelancersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Freelancers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Freelancer>>> GetFreelancers()
        {
          if (_context.Freelancers == null)
          {
              return NotFound();
          }
            return await _context.Freelancers.ToListAsync();
        }

        // GET: api/Freelancers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Freelancer>> GetFreelancer(int id)
        {
          if (_context.Freelancers == null)
          {
              return NotFound();
          }
            var freelancer = await _context.Freelancers.FindAsync(id);

            if (freelancer == null)
            {
                return NotFound();
            }

            return freelancer;
        }

        // PUT: api/Freelancers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFreelancer(int id, Freelancer freelancer)
        {
            if (id != freelancer.FreeId)
            {
                return BadRequest();
            }

            _context.Entry(freelancer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FreelancerExists(id))
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

        // POST: api/Freelancers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Freelancer>> PostFreelancer(Freelancer freelancer)
        {
          if (_context.Freelancers == null)
          {
              return Problem("Entity set 'DataContext.Freelancers'  is null.");
          }
            _context.Freelancers.Add(freelancer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFreelancer", new { id = freelancer.FreeId }, freelancer);
        }

        // DELETE: api/Freelancers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFreelancer(int id)
        {
            if (_context.Freelancers == null)
            {
                return NotFound();
            }
            var freelancer = await _context.Freelancers.FindAsync(id);
            if (freelancer == null)
            {
                return NotFound();
            }

            _context.Freelancers.Remove(freelancer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FreelancerExists(int id)
        {
            return (_context.Freelancers?.Any(e => e.FreeId == id)).GetValueOrDefault();
        }
    }
}
