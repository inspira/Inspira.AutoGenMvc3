using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Evento
    {
        public virtual Int32 ID { get; set; }

        public virtual String Nome { get; set; }

        public virtual DateTime DataRealizacao { get; set; }

        public virtual String NomeLocal { get; set; }

        public virtual String RuaLocal { get; set; }

        public virtual String CidadeLocal { get; set; }

        public virtual Estado EstadoLocal { get; set; }

        public virtual String CEP { get; set; }

        public virtual String Telefone { get; set; }

        public virtual String SiteWeb { get; set; }

        public virtual String Descricao { get; set; }

        public virtual Boolean Publicado { get; set; }

        public virtual DateTime DataCriacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual Usuario UsuarioCriacao { get; set; }
        public virtual Usuario UsuarioAlteracao { get; set; }
    }
}
