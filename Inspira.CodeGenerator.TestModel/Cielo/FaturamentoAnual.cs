using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class FaturamentoAnual
    {
        public virtual Int32 ID { get; set; }

        public virtual String Faixa { get; set; }
    }
}
