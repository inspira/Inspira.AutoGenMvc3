using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Avaliacao
    {
        public enum TipoAvaliacao : byte
        {
            Ruim = 1,
            Regular,
            Bom,
            Otimo,
            Excelente
        }

        public virtual int ID { get; set; }

        public virtual int QtdVotos { get; set; }

        public virtual Promocao Promocao { get; set; }

        public virtual TipoAvaliacao Tipo { get; set; }

    }
}
