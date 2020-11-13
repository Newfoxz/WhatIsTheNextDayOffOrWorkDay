using Microsoft.AspNetCore.Mvc;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerPessoa : ControllerBase
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public ControllerPessoa(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositoryPessoa.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pessoa)
        {
            _repositoryPessoa.Add(pessoa);
            return Created("api/pessoa", pessoa);
        }
    }
}
