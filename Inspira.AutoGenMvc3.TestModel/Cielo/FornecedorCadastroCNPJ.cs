using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class FornecedorCadastroCNPJ
    {
        public virtual Int32 ID { get; set; }

        public virtual String CNPJ { get; set; }

        public virtual DateTime? DataVinculo { get; set; }
    }
}
