using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Configuration
{
    public class ConfigurationEscala : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> builder)
        {
            builder.HasKey(escala => escala.Id);
            builder.Property(escala => escala.Descricao).IsRequired().HasMaxLength(50);
            builder.Property(escala => escala.VigenciaInicial).IsRequired();
            builder.HasMany(escala => escala.Sequencias);

            builder.HasData(new Escala
            {
                Id = 1,
                Descricao = "@FILIPOSO CPTM-ESCALA (4-1-3-2)",
                VigenciaInicial = new DateTime(2020, 10, 30),
            });
        }
    }
}
