using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class EmailMarketing
    {
        public virtual Int32 ID { get; set; }

        public virtual String Titulo { get; set; }

        public virtual String TextoIntro { get; set; }

        public virtual String TextoRodape { get; set; }

        public virtual TemplateEmail Template { get; set; }

        public virtual IList<Promocao> Promocoes { get; set; }
    }
}
