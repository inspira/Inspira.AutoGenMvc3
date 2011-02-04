using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Noticia
    {
        public virtual Int32 ID { get; set; }

        public virtual String Titulo { get; set; }

        public virtual String SubTitulo { get; set; }

        public virtual String Imagem { get; set; }

        public virtual String Corpo { get; set; }

        public virtual String Fonte { get; set; }

        public virtual Boolean Publicado { get; set; }

        public virtual DateTime DataCriacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual Usuario UsuarioCriacao { get; set; }
        public virtual Usuario UsuarioAlteracao { get; set; }
    }
}
