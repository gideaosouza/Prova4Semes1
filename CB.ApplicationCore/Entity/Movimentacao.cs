using System;
using System.Collections.Generic;
using System.Text;

namespace CB.ApplicationCore.Entity
{
    public class Movimentacao
    {
        public Movimentacao()
        {

        }
        public int MovimentacaoId { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public Conta Conta { get; set; }
    }
}
