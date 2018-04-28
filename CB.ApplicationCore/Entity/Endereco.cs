using System;
using System.Collections.Generic;
using System.Text;

namespace CB.ApplicationCore.Entity
{
    public class Endereco
    {
        public Endereco()
        {

        }
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
