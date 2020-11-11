using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WhatIsTheNextDayOffOrWorkDay.Domain.Entity;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Configuration
{
    public class ConfigurationPessoa : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(pessoa => pessoa.Id);
            builder.Property(pessoa => pessoa.NomeCompleto).IsRequired().HasMaxLength(75);
            builder.Property(pessoa => pessoa.Apelido).IsRequired().HasMaxLength(25);
            builder.Property(pessoa => pessoa.NumeroCPF).IsRequired().HasMaxLength(11);
            builder.Property(pessoa => pessoa.DataNascimento).IsRequired();
        }
    }
}
