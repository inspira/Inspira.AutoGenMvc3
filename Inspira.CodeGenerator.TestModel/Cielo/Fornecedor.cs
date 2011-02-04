using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Fornecedor
    {
        public virtual Int32 ID { get; set; }

        public virtual String CNPJ { get; set; }

        public virtual String NumeroEC { get; set; }

        public virtual String RazaoSocial { get; set; }

        public virtual String NomeFantasia { get; set; }

        public virtual DateTime DataFundacao { get; set; }

        public virtual RamoAtividade RamoAtividade { get; set; }

        public virtual String LogoEmpresaURL { get; set; }

        public virtual String Endereco { get; set; }

        public virtual String Complemento { get; set; }

        public virtual String Bairro { get; set; }

        public virtual String Cidade { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual String CEP { get; set; }

        public virtual IList<Estado> EstadosCobertura { get; set; }

        public virtual String Historico { get; set; }

        public virtual QtdFuncionarios QtdFuncionarios { get; set; }

        public virtual FaturamentoAnual FaturamentoAnual { get; set; }

        public virtual String SiteURL { get; set; }

        public virtual String Nome { get; set; }

        public virtual String Cargo { get; set; }

        public virtual String TelefoneComercial { get; set; }

        public virtual String Celular { get; set; }

        public virtual String Email1 { get; set; }

        public virtual String Email2 { get; set; }

        public virtual String Email3 { get; set; }

        public virtual FornecedorCadastroCNPJ FornecedorCadastroCNPJ { get; set; }

        public virtual bool NovidadesMercadoEmpresarial { get; set; }

        public virtual bool InformacoesEventos { get; set; }

        public virtual bool PromocoesBNDES { get; set; }

        public virtual bool NovidadesCartao { get; set; }

        public virtual bool ReceberEmail { get; set; }

        public virtual bool ReceberCorreio { get; set; }

        public virtual bool ReceberSMS { get; set; }                

        public virtual IList<Promocao> Promocoes { get; set; }

        public virtual IList<Usuario> UsuariosRestritos { get; set; }

        public Fornecedor()
        {
            this.Estado = new Estado();
            this.Promocoes = new List<Promocao>();
            this.RamoAtividade = new RamoAtividade();
            this.EstadosCobertura = new List<Estado>();
            this.QtdFuncionarios = new QtdFuncionarios();
            this.FaturamentoAnual = new FaturamentoAnual();
            this.UsuariosRestritos = new List<Usuario>();
        }
    }
}
