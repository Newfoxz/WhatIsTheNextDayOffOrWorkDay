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
            builder.HasOne(sequencia => sequencia.Escala);
            
            builder.HasData(
                new Sequencia
                {
                    Id = 1,
                    Numero = 1,
                    Indicador = 0,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 2,
                    Numero = 2,
                    Indicador = 1,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 3,
                    Numero = 3,
                    Indicador = 1,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 4,
                    Numero = 4,
                    Indicador = 1,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 5,
                    Numero = 5,
                    Indicador = 0,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 6,
                    Numero = 6,
                    Indicador = 0,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 7,
                    Numero = 7,
                    Indicador = 1,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 8,
                    Numero = 8,
                    Indicador = 1,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 9,
                    Numero = 9,
                    Indicador = 1,
                    EscalaId = 1,
                },
                new Sequencia
                {
                    Id = 10,
                    Numero = 10,
                    Indicador = 1,
                    EscalaId = 1,
                }
            );
        }
    }
}
