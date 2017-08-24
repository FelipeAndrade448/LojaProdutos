using NHibernate.Criterion;
using LojaProduto.Domain.Entities;
using LojaProduto.Integration.Spec;
using SQFramework.Data.Pagging;
using SQFramework.Spring.Data.Hibernate;

namespace LojaProduto.Integration.Impl
{
    class ControleDeNotaFiscalRepository : RepositoryBase<ControleDeNotaFiscal>, IControleDeNotaFiscalRepository<ControleDeNotaFiscal>
    {
        public PageMessage<ControleDeNotaFiscal> ListarControleDeNotaFiscal(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            var criteria = DetachedCriteria.For<ControleDeNotaFiscal>();

            return Page<ControleDeNotaFiscal>(criteria, startIndex, pageSize, orderProperty, orderAscending);
        }
    }
}
