using CB.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CB.Infrastructure.EntityConfig
{
    class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasOne(x => x.Endereco).WithOne(c => c.Pessoa).HasForeignKey<Pessoa>(x=>x.EnderecoId);
            builder.Property(x => x.Nome).HasMaxLength(40);
            builder.Property(x => x.CPF).HasMaxLength(14);
        }
    }
}
