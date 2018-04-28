using CB.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CB.Infrastructure.EntityConfig
{
    public class ContaPessoaConfig : IEntityTypeConfiguration<ContaPessoa>
    {
        public void Configure(EntityTypeBuilder<ContaPessoa> builder)
        {
            builder.ToTable("ContaPessoa");
            builder.HasKey(bc => new { bc.ContaId, bc.PessoaId });
            builder.HasOne(x => x.Pessoa).WithMany(c => c.ContaPessoas).HasForeignKey(c=>c.PessoaId);
            builder.HasOne(x => x.Conta).WithMany(c => c.ContaPessoas).HasForeignKey(c => c.ContaId);
        }

        //https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration
    }
}
