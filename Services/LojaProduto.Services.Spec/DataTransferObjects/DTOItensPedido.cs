using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LojaProduto.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOItensPedido
    {
        [DataMember(), Key(), Required()]
        public int Id { get; set; }

        [DataMember(), Required()]
        public int QuantidadeProduto { get; set; }

        [DataMember(), Required()]
        public decimal TotalItemPedido { get; set; }

        [DataMember(), Required()]
        public DTOPedido Pedido { get; set; }

        [DataMember(), Required()]
        public DTOProduto Produto { get; set; }
    }
}