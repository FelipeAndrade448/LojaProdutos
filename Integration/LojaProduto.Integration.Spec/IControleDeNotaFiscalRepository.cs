using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace LojaProduto.Integration.Spec
{
    [ObjectMap("ControleDeNotaFiscalRepository", true)]
    public interface IControleDeNotaFiscalRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarControleDeNotaFiscal(int startIndex, int pageSize, string orderProperty, bool orderAscending);
    }
}
