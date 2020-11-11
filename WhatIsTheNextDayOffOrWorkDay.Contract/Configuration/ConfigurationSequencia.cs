using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Configuration
{
    public class ConfigurationSequencia : IEntityTypeConfiguration<Sequencia>
    {
        public void Configure(EntityTypeBuilder<Sequencia> builder)
        {
            builder.HasKey(sequencia => sequencia.Id);
            builder.Property(sequencia => sequencia.Numero).IsRequired();
            builder.Property(sequencia => sequencia.Indicador).IsRequired();
        }
    }
}
