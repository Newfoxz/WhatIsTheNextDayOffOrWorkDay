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
            builder.Property(escala => escala.Descricao).IsRequired().HasMaxLength(25);
            builder.Property(escala => escala.VigenciaInicial).IsRequired();
            builder.Property(escala => escala.VigenciaFinal);
        }
    }
}
