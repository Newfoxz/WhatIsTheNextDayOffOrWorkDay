using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public PessoasController(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        [HttpGet]
        public async Task<ActionResult<Pessoa>> Get()
        {
            return Ok(await _repositoryPessoa.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetById(int id)
        {
            var pessoa = await _repositoryPessoa.GetById(id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        //// PUT: api/Pessoas/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPessoa(int id, Pessoa pessoa)
        //{
        //    if (id != pessoa.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(pessoa).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PessoaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Pessoas
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        //{
        //    _context.Pessoas.Add(pessoa);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPessoa", new { id = pessoa.Id }, pessoa);
        //}

        //// DELETE: api/Pessoas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePessoa(int id)
        //{
        //    var pessoa = await _context.Pessoas.FindAsync(id);
        //    if (pessoa == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Pessoas.Remove(pessoa);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool PessoaExists(int id)
        //{
        //    return _context.Pessoas.Any(e => e.Id == id);
        //}
    }
}
