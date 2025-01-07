using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_CRUD.Data;
using API_CRUD.Models;

namespace API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemestreModelsController : ControllerBase
    {
        private readonly ClassConexion _context;

        public SemestreModelsController(ClassConexion context)
        {
            _context = context;
        }

        // GET: api/SemestreModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SemestreModel>>> GetSemestres()
        {
            return await _context.Semestre.ToListAsync();
        }

        // GET: api/SemestreModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SemestreModel>> GetSemestreModel(int id)
        {
            var semestreModel = await _context.Semestre.FindAsync(id);

            if (semestreModel == null)
            {
                return NotFound();
            }

            return semestreModel;
        }

        // PUT: api/SemestreModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSemestreModel(int id, SemestreModel semestreModel)
        {
            if (id != semestreModel.Id_Semestre)
            {
                return BadRequest();
            }

            _context.Entry(semestreModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SemestreModelExists(id))
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

        // POST: api/SemestreModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SemestreModel>> PostSemestreModel(SemestreModel semestreModel)
        {
            _context.Semestre.Add(semestreModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSemestreModel", new { id = semestreModel.Id_Semestre }, semestreModel);
        }

        // DELETE: api/SemestreModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSemestreModel(int id)
        {
            var semestreModel = await _context.Semestre.FindAsync(id);
            if (semestreModel == null)
            {
                return NotFound();
            }

            _context.Semestre.Remove(semestreModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SemestreModelExists(int id)
        {
            return _context.Semestre.Any(e => e.Id_Semestre == id);
        }
    }
}
