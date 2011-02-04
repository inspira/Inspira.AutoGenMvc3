﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Estado
    {
        public virtual Int32 ID { get; set; }

        public virtual String Nome { get; set; }

        public virtual String Sigla { get; set; }
    }
}
