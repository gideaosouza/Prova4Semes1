using System;
using System.Collections.Generic;
using System.Text;

namespace CB.ApplicationCore.Entity
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public int PessoaId { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public ICollection<ContaPessoa> ContaPessoas { get;set;}
    }
}
