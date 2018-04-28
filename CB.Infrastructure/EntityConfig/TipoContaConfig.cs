using CB.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CB.Infrastructure.EntityConfig
{
    public class TipoContaConfig : IEntityTypeConfiguration<TipoConta>
    {
        public void Configure(EntityTypeBuilder<TipoConta> builder)
        {
            builder.ToTable("TipoConta");
            builder.HasMany(x => x.Contas).WithOne(x => x.TipoConta);
        }
    }
}
