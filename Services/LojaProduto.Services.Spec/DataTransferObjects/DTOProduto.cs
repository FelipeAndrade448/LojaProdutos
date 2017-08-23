using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LojaProduto.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOProduto
    {
        [DataMember(), Key(), Required()]
        public int Id { get; set; }

        [DataMember(), Required(), StringLength(10), Display(Name = "Código")]
        public string CodigoProduto { get; set; }

        [DataMember(), Required(), StringLength(50)]
        public string Nome { get; set; }

        [DataMember(), Required(), Display(Name = "Data Fabricação")]
        public DateTime DataFabricacao { get; set; }

        [DataMember(), Required(), Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }

        [DataMember(), Required(), Display(Name = "Preço")]
        public decimal PrecoProduto { get; set; }

        [DataMember(), Required(), Display(Name = "Quantidade")]
        public int QuantidadeEmEstoque { get; set; }

        [DataMember(), Required(), StringLength(50), Display(Name = "Codigo de Barras")]
        public string CodigoBarra { get; set; }

        [DataMember(), Required(), Display(Name = "Categoria")]
        public DTOCategoria Categoria { get; set; }

        [DataMember(), Required(), Display(Name = "Fornecedor")]
        public DTOFornecedor Fornecedor { get; set; }

        public byte ImagemProduto { get; set; }

    }
}