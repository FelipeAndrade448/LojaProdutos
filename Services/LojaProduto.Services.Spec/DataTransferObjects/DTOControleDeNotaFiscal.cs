using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LojaProduto.Services.Spec.DataTransferObjects
{
    [DataContract()]
    [Serializable()]
    public class DTOControleDeNotaFiscal
    {
        [DataMember(), Key(), Required()]
        public virtual int NumeroDaNF { get; set; }

        [DataMember(), Required()]
        public virtual DateTime DataDeLancamento { get; set; }

        [DataMember(), Required(), StringLength(150)]
        public virtual string Fornecedor { get; set; }

        public virtual IList<DTOPedido> Pedido { get; set; }

        [DataMember(), Required(), StringLength(50)]
        public virtual string Natureza { get; set; }

        [DataMember(), Required()]
        public virtual decimal ValorDaNota { get; set; }

        [DataMember(), Required()]
        public virtual int TipoDeNota { get; set; }

    }
}
