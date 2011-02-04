using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Role
    {
        public virtual Int32 ID { get; set; }

        public virtual String Nome { get; set; }

        public virtual String Descricao { get; set; }
        
        public virtual IList<Usuario> Usuarios { get; set; }
    }
}
