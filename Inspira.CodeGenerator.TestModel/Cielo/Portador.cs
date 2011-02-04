using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Portador
    {

        public Portador()
        {
            this.Estado = new Estado();
            this.Promocoes = new List<Promocao>();
            this.RamoAtividade = new RamoAtividade();
            this.CategoriaProduto = new CategoriaProduto();
            this.EmissorCartao = new CartaoEmissor();
            this.BandeiraCartao = new CartaoBandeira();
        }

        public virtual Int32 ID { get; set; }

        public virtual String CNPJ { get; set; }

        public virtual String RazaoSocial { get; set; }

        public virtual RamoAtividade RamoAtividade { get; set; }

        public virtual CategoriaProduto CategoriaProduto { get; set; }

        public virtual String Endereco { get; set; }

        public virtual String Complemento { get; set; }

        public virtual String Bairro { get; set; }

        public virtual String Cidade { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual String CEP { get; set; }

        public virtual String Nome { get; set; }

        public virtual String Cargo { get; set; }

        public virtual String TelefoneComercial { get; set; }

        public virtual String Celular { get; set; }

        public virtual String Email1 { get; set; }
        
        public virtual String Email2 { get; set; }

        public virtual String Email3 { get; set; }

        public virtual CartaoBandeira BandeiraCartao { get; set; }

        public virtual CartaoEmissor EmissorCartao { get; set; }

        public virtual bool NovidadesMercadoEmpresarial { get; set; }

        public virtual bool InformacoesEventos { get; set; }

        public virtual bool PromocoesBNDES { get; set; }

        public virtual bool NovidadesCartao { get; set; }

        public virtual bool ReceberEmail { get; set; }

        public virtual bool ReceberCorreio { get; set; }

        public virtual bool ReceberSMS { get; set; }

        public virtual IList<Promocao> Promocoes { get; set; }

    }
}
