using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        public async Task<ActionResult<Pessoa>> GetPessoas()
        {
            return Ok(await _repositoryPessoa.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoaById(int id)
        {
            var pessoa = await _repositoryPessoa.GetById(id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpGet("{id}/periodo/{periodo}")]
        public async Task<ActionResult<IDictionary<string, string>>> GetPessoaPeriodoById(int id, int periodo)
        {
            var pessoa = await _repositoryPessoa.GetById(id);

            if (pessoa is not null)
            {
                IDictionary<string, string> periodos = new Dictionary<string, string>();

                for (int cont = 0; cont < periodo; cont++)
                {
                    periodos.Add(DateTime.Now.AddDays(cont).ToString("dd/MM/yyyy - dddd", CultureInfo.CreateSpecificCulture("pt-BR")),
                        pessoa.Escala.Sequencias.ToList().Find(t =>
                            t.Numero == ((DateTime.Now.AddDays(cont) - pessoa.Escala.VigenciaInicial).Days % pessoa.Escala.Sequencias.ToList().Count) + 1
                        ).IndicadorToString()
                    );
                }

                return periodos == null ? BadRequest() : Ok(periodos);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("periodo")]
        public async Task<ActionResult<IDictionary<string, string>>> GetPessoaPeriodoById2(int id, int range)
        {
            var pessoa = await _repositoryPessoa.GetById(id);

            if (pessoa is not null)
            {
                IDictionary<string, string> periodos = new Dictionary<string, string>();

                for (int cont = 0; cont < range; cont++)
                {
                    periodos.Add(DateTime.Now.AddDays(cont).ToString("dd/MM/yyyy - dddd", CultureInfo.CreateSpecificCulture("pt-BR")),
                        pessoa.Escala.Sequencias.ToList().Find(t =>
                            t.Numero == ((DateTime.Now.AddDays(cont) - pessoa.Escala.VigenciaInicial).Days % pessoa.Escala.Sequencias.ToList().Count) + 1
                        ).IndicadorToString()
                    );
                }

                return periodos == null ? BadRequest() : Ok(periodos);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("periodo/2")]
        public async Task<ActionResult<IDictionary<string, string>>> GetPessoaPeriodoByApelido(string apelido, int range)
        {
            var pessoa = await _repositoryPessoa.GetByCondition(p => p.Apelido.Equals(apelido));

            if (pessoa.FirstOrDefault() is not null)
            {
                IDictionary<string, string> periodos = new Dictionary<string, string>();

                for (int cont = 0; cont < range; cont++)
                {
                    periodos.Add(DateTime.Now.AddDays(cont).ToString("dd/MM/yyyy - dddd", CultureInfo.CreateSpecificCulture("pt-BR")),
                        pessoa.FirstOrDefault().Escala.Sequencias.ToList().Find(t =>
                            t.Numero == ((DateTime.Now.AddDays(cont) - pessoa.FirstOrDefault().Escala.VigenciaInicial).Days % pessoa.FirstOrDefault().Escala.Sequencias.ToList().Count) + 1
                        ).IndicadorToString()
                    );
                }

                return periodos == null ? BadRequest() : Ok(periodos);
            }
            else
            {
                return NotFound();
            }
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
