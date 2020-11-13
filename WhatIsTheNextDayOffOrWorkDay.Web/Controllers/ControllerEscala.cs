using Microsoft.AspNetCore.Mvc;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerEscala : ControllerBase
    {
        private readonly IRepositoryEscala _repositoryEscala;

        public ControllerEscala(IRepositoryEscala repositoryEscala)
        {
            _repositoryEscala = repositoryEscala;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositoryEscala.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Escala escala)
        {
            _repositoryEscala.Add(escala);
            return Created("api/escala", escala);
        }
    }
}
