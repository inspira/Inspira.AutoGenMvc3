using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Contato
    {
        public enum TipoContato : byte
        {
            Reclamacao = 1,
            Sugestao,
            Elogio,
            SoliciteSeuCartao,
            SejaFornecedor,
            Outro
        }

        public virtual Int32 ID { get; set; }

        public virtual String Nome { get; set; }

        public virtual String Email { get; set; }

        public virtual TipoContato Tipo { get; set; }

        public virtual String Telefone { get; set; }

        public virtual String Mensagem { get; set; }

        public virtual DateTime DataCriacao { get; set; }

        public Contato()
        {            
        }
    }
}
