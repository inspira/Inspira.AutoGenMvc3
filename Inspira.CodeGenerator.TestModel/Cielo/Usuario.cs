using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Usuario
    {
        public enum TiposRole : byte
        {
            Admin = 1, Portador, Fornecedor, FornecedorRestrito
        }

        public static IDictionary<TiposRole, String> NomesRoles = new Dictionary<TiposRole, string>
        {
            {TiposRole.Admin, "Admin"},
            {TiposRole.Portador, "Portador"},
            {TiposRole.Fornecedor, "Fornecedor"},
            {TiposRole.FornecedorRestrito, "FornecedorRestrito"},
        };

        public virtual Int32 ID { get; set; }

        public virtual String Login { get; set; }

        public virtual String Password { get; set; }

        public virtual DateTime DataCriacao { get; set; }

        public virtual DateTime? UltimoLogin { get; set; }

        public virtual Boolean Ativo { get; set; }

        public virtual IList<Role> Roles { get; set; }

        public virtual Boolean Apagado { get; set; }

        public virtual String CodigoConfirmacao { get; set; }

        public virtual String Email { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        public virtual Portador Portador { get; set; }

        public virtual Fornecedor FornecedorPai { get; set; }

        public Usuario()
        {
            this.Roles = new List<Role>();
        }
    }
}
