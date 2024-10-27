using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozyasar_Sigorta_Musteri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YourEntitiesController : ControllerBase
    {
        private readonly YourDbContext _context;

        public YourEntitiesController(YourDbContext context)
        {
            _context = context;
        }

        // GET: api/YourEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<YourEntity>>> GetYourEntities()
        {
            return await _context.YourEntities.ToListAsync();
        }

        // GET: api/YourEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<YourEntity>> GetYourEntity(int id)
        {
            var yourEntity = await _context.YourEntities.FindAsync(id);
            if (yourEntity == null)
            {
                return NotFound();
            }
            return yourEntity;
        }

        // POST: api/YourEntities
        [HttpPost]
        public async Task<ActionResult<YourEntity>> PostYourEntity(YourEntity yourEntity)
        {
            _context.YourEntities.Add(yourEntity);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetYourEntity", new { id = yourEntity.Id }, yourEntity);
        }

        // PUT: api/YourEntities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYourEntity(int id, YourEntity yourEntity)
        {
            if (id != yourEntity.Id)
            {
                return BadRequest();
            }
            _context.Entry(yourEntity).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YourEntityExists(id))
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

        // DELETE: api/YourEntities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYourEntity(int id)
        {
            var yourEntity = await _context.YourEntities.FindAsync(id);
            if (yourEntity == null)
            {
                return NotFound();
            }
            _context.YourEntities.Remove(yourEntity);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool YourEntityExists(int id)
        {
            return _context.YourEntities.Any(e => e.Id == id);
        }
    }
}
