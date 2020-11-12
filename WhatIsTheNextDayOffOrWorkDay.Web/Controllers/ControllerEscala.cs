using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;

namespace WhatIsTheNextDayOffOrWorkDay.Web.Controllers
{
    [Route("api/[controller]")]
    public class ControllerEscala : Controller
    {
        private readonly IRepositoryEscala _repositoryEscala;

        public ControllerEscala(IRepositoryEscala repositoryEscala)
        {
            _repositoryEscala = repositoryEscala;
        }
    }
}
