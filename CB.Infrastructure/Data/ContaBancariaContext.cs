using CB.ApplicationCore.Entity;
using CB.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CB.Infrastructure.Data
{
    public class ContaBancariaContext : DbContext
    {
        public ContaBancariaContext(DbContextOptions<ContaBancariaContext> options) : base(options)
        {

        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<TipoConta> TipoContas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfig());
            modelBuilder.ApplyConfiguration(new ContaConfig());
            modelBuilder.ApplyConfiguration(new ContaPessoaConfig());
        }
    }
}
