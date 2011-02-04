using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Depoimento
    {
        public virtual Int32 ID { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual String Foto { get; set; }

        public virtual String Mensagem { get; set; }

        public virtual StatusAprovacao Status { get; set; }

        public virtual String MensagemReprovacao { get; set; }

        public virtual Boolean Publicado { get; set; }

        public virtual DateTime? DataPublicacao { get; set; }

        public virtual DateTime? DataAlteracao { get; set; }

        public virtual DateTime DataCriacao { get; set; }

        public Depoimento()
        {
            this.Usuario = new Usuario();
            this.Status = new StatusAprovacao();
        }
    }
}
