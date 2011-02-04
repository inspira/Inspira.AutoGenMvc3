using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Visita
    {
        public virtual Int32 ID { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Promocao Promocao { get; set; }

        public virtual DateTime DataVisita { get; set; }
    }
}
