using System;
using System.Collections.Generic;
using System.Text;

namespace CB.ApplicationCore.Entity
{
    public class TipoConta
    {
        public TipoConta()
        {

        }
        public int TipoContaId { get; set; }
        public string Descricao { get; set; }
        public ICollection<Conta> Contas { get; set; }
    }
}
