using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Repository
{
    public class RepositoryPessoa : Repository<Pessoa>, IRepositoryPessoa
    {

    }
}
