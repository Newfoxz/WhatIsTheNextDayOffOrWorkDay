using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalasController : ControllerBase
    {
        private readonly IRepositoryEscala _repositoryEscala;

        public EscalasController(IRepositoryEscala repositoryEscala)
        {
            _repositoryEscala = repositoryEscala;
        }

        [HttpGet]
        public async Task<ActionResult<Escala>> Get()
        {
            return Ok(await _repositoryEscala.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Escala>> GetById(int id)
        {
            var escala = await _repositoryEscala.GetById(id);

            return escala == null ? NotFound() : Ok(escala);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Escala escaka)
        {
            _repositoryEscala.Create(escaka);
            return Created("api/escalas", escaka);
        }
    }
}
