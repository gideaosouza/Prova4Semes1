using System;
using System.Collections.Generic;
using System.Text;

namespace CB.ApplicationCore.Entity
{
    public class ContaPessoa
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int ContaId { get; set; }
        public Conta Conta { get; set; }
    }
}
