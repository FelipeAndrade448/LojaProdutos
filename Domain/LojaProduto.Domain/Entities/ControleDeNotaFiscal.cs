using SQFramework.Spring.Domain;
using System;
using LojaProduto.Integration.Spec;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProduto.Domain.Entities
{
    public partial class ControleDeNotaFiscal : DomainBase<ControleDeNotaFiscal, IControleDeNotaFiscalRepository<ControleDeNotaFiscal>>
    {
        public ControleDeNotaFiscal()
        {
        }

        protected int numeroDaNF;
        protected DateTime dataDeLancamento;
        protected string fornecedor;
        protected IList<Pedido> pedido;
        protected string natureza;
        protected decimal valorDaNota;
        protected int tipoDeNota;

        public virtual int NumeroDaNF { get { return numeroDaNF; } }
        public virtual DateTime DataDeLancamento { get { return dataDeLancamento; } set { dataDeLancamento = value; } }
        public virtual string Fornecedor { get { return fornecedor; } set { fornecedor = value; } }
        public virtual IList<Pedido> Pedido { get { return pedido; } set { pedido = value; } }
        public virtual string Natureza { get { return natureza; } set { natureza = value; } }
        public virtual decimal ValorDaNota { get { return valorDaNota; } set { valorDaNota = value; } }
        public virtual int TipoDeNota { get { return tipoDeNota; } set { tipoDeNota = value; } }

        public override void Save()
        {
            base.Save();
        }

        public virtual void AdicionaPedido(Pedido pedido)
        {
            if (pedido == null)
                throw new Exception("Pedido inválido");
            if (pedido.StatusPedido != 3)
                throw new Exception("Pedido não encontra-se faturado");

            this.Pedido.Add(pedido);
            CalculaValorDaNota();
            this.Save();
        }

        public virtual void CalculaValorDaNota()
        {
            ValorDaNota = 0;

            foreach(var pedido in pedido)
            {
                if (pedido == null)
                    throw new Exception("Pedido inválido");
                if (pedido.StatusPedido != 3)
                    throw new Exception("Pedido não encontra-se faturado");

                ValorDaNota += pedido.ValorTotalPedido;
            }

        }
    }
}
