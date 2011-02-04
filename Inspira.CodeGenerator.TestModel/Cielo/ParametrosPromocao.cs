using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class ParametrosPromocao
    {
        public virtual Int32 ID { get; set; }

        public virtual String Pague { get; set; }

        public virtual String Leve { get; set; }

        public virtual String Compre { get; set; }
        public virtual String Ganhe { get; set; }

        public virtual Decimal? Preco { get; set; }

        public virtual Decimal? PrecoDesconto { get; set; }

        public virtual String Mecanica { get; set; }
    }
}
