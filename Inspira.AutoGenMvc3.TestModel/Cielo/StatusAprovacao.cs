using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class StatusAprovacao
    {
        public enum Status : byte
        { 
            Pendente = 1, Aprovado = 2, Reprovado = 3  
        }

        public virtual Int32 ID { get; set; }

        public virtual String Nome { get; set; }
    }
}
