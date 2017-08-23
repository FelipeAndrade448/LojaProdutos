using NHibernate.Criterion;
using LojaProduto.Domain.Entities;
using LojaProduto.Integration.Spec;
using SQFramework.Data.Pagging;
using SQFramework.Spring.Data.Hibernate;

namespace LojaProduto.Integration.Impl
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository<Categoria>
    {
        public PageMessage<Categoria> ListarCategorias(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            var criteria = DetachedCriteria.For<Categoria>();

            return Page<Categoria>(criteria, startIndex, pageSize, orderProperty, orderAscending);
        }
    }
}