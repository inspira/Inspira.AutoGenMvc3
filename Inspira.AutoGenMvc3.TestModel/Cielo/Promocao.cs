using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cielo.CartaoBNDES.DomainModels
{
    public class Promocao
    {
        public virtual Int32 ID { get; set; }

        #region Novos Campos

        public virtual String CodPromocao { get; set; }

        public virtual CategoriaProduto Categoria { get; set; }

        public virtual String Restricoes { get; set; }

        public virtual String LinkBNDESURL { get; set; }

        public virtual IList<Estado> EstadosCobertura { get; set; }

        #endregion

        public virtual String NomePromocao { get; set; }

        public virtual String Descricao { get; set; }

        public virtual String Foto1URL { get; set; }

        public virtual String Foto2URL { get; set; }

        public virtual String Foto3URL { get; set; }

        public virtual String Foto4URL { get; set; }

        public virtual Int32 Visitas { get; set; }

        public virtual IList<CartaoBandeira> CartoesAceitos { get; set; }

        public virtual IList<Visita> ListaVisitas { get; set; }

        public virtual DateTime VigenciaInicio { get; set; }

        public virtual DateTime VigenciaFim { get; set; }

        public virtual String Telefone { get; set; }

        public virtual String Email { get; set; }

        public virtual String Site { get; set; }

        public virtual StatusAprovacao Status { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        public virtual TipoPromocao TipoPromocao { get; set; }

        public virtual Int32 Avaliacao
        {
            get { return Avaliacoes.Sum(x => (int)x.Tipo * x.QtdVotos); }
        }

        public virtual Int32 QtdVotos
        {
            get { return Avaliacoes.Sum(x => x.QtdVotos); }
        }

        public virtual String MensagemReprovacao { get; set; }

        public virtual Boolean Publicado { get; set; }

        public virtual DateTime? DataPublicacao { get; set; }

        public virtual DateTime? DataAlteracao { get; set; }

        public virtual DateTime? DataModeracao { get; set; }
        
        public virtual DateTime DataCriacao { get; set; }
        
        public virtual IList<Avaliacao> Avaliacoes { get; set; }

        public virtual ParametrosPromocao Parametros { get; set; }

        #region Campos Obsoletos

        //public virtual Decimal ValorVista { get; set; }

        //public virtual Decimal PrecoSemDesconto { get; set; }

        //public virtual Int32? NumeroParcelas { get; set; }

        //public virtual decimal ValorParcela { get; set; }

        //public virtual decimal ValorSemDesconto { get; set; }

        #endregion

        public Promocao()
        {
            this.CartoesAceitos = new List<CartaoBandeira>();
            this.EstadosCobertura = new List<Estado>();
            this.TipoPromocao = new TipoPromocao();
            this.Parametros = new ParametrosPromocao();
        }
    }
}
