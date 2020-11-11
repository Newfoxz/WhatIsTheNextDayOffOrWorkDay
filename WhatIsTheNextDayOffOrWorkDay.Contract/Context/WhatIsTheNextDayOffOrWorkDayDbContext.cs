using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;
using WhatIsTheNextDayOffOrWorkDay.Repository.Configuration;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationEscala());
            modelBuilder.ApplyConfiguration(new ConfigurationPessoa());
            modelBuilder.ApplyConfiguration(new ConfigurationSequencia());
            base.OnModelCreating(modelBuilder);
        }
    }
}
