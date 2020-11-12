using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Contract;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;
using WhatIsTheNextDayOffOrWorkDay.Repository.Context;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Repository
{
    public class RepositoryEscala : Repository<Escala>, IRepositoryEscala
    {
        public RepositoryEscala(WhatIsTheNextDayOffOrWorkDayDbContext whatIsTheNextDayOffOrWorkDayDbContext) 
            : base(whatIsTheNextDayOffOrWorkDayDbContext)
        {

        }
    }
}
