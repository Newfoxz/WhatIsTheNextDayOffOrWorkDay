using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Context
{
    public class WhatIsTheNextDayOffOrWorkDayDbContext : DbContext
    {
        public WhatIsTheNextDayOffOrWorkDayDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<Sequencia> Sequencias { get; set; }
    }
}
