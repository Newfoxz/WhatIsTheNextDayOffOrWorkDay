using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [Route("api/[controller]")]
    public class ControllerSequencia : Controller
    {
        private readonly IRepositorySequencia _repositorySequencia;

        public ControllerSequencia(IRepositorySequencia repositorySequencia)
        {
            _repositorySequencia = repositorySequencia;
        }
    }
}
