using Microsoft.AspNetCore.Mvc;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerSequencia : ControllerBase
    {
        private readonly IRepositorySequencia _repositorySequencia;

        public ControllerSequencia(IRepositorySequencia repositorySequencia)
        {
            _repositorySequencia = repositorySequencia;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositorySequencia.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Sequencia sequencia)
        {
            _repositorySequencia.Add(sequencia);
            return Created("api/sequencia", sequencia);
        }
    }
}
