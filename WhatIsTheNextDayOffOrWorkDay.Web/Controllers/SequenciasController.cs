using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SequenciasController : ControllerBase
    {
        private readonly IRepositorySequencia _repositorySequencia;

        public SequenciasController(IRepositorySequencia repositorySequencia)
        {
            _repositorySequencia = repositorySequencia;
        }

        [HttpGet]
        public async Task<ActionResult<Sequencia>> Get()
        {
            return Ok(await _repositorySequencia.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sequencia>> GetById(int id)
        {
            var sequencia = (await _repositorySequencia.GetByCondition(sequencia => sequencia.Id == id)).FirstOrDefault();

            return sequencia == null ? NotFound() : Ok(sequencia);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Sequencia sequencia)
        {
            _repositorySequencia.Create(sequencia);
            return Created("api/sequencias", sequencia);
        }
    }
}
