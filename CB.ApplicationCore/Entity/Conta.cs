using System;
using System.Collections.Generic;
using System.Text;

namespace CB.ApplicationCore.Entity
{
    public class Conta
    {
        public Conta()
        {

        }
        public int ContaId { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public bool Situacao { get; set; }
        public ICollection<Movimentacao> Movimentacoes { get; set; }
        public TipoConta TipoConta { get; set; }
        public ICollection<ContaPessoa> ContaPessoas { get; set; }
    }
}
