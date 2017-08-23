using System.Collections.Generic;
using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace LojaProduto.Integration.Spec
{
    [ObjectMap("ProdutoRepository", true)]
    public interface IProdutoRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarProdutos(int startIndex, int pageSize, string orderProperty, bool orderAscending);

        IList<T> PesquisarProdutos(string pesquisa);
    }
}