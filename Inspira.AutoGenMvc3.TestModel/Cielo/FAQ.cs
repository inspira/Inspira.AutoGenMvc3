using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class FAQ
    {
        public virtual Int32 ID { get; set; }

        public virtual String Pergunta { get; set; }

        public virtual String Resposta { get; set; }

        public virtual int Ordem { get; set; }
    }
}
