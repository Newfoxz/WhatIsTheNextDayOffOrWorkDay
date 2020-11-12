using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [Route("api/[controller]")]
    public class ControllerPessoa : Controller
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public ControllerPessoa(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }
    }
}
