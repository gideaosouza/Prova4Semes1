using CB.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CB.Infrastructure.EntityConfig
{
    class ContaConfig : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");
            builder.HasMany(x => x.Movimentacoes).WithOne(x => x.Conta);
        }
    }
}
