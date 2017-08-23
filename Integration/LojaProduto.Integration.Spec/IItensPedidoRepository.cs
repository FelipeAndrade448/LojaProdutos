using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace LojaProduto.Integration.Spec
{
    [ObjectMap("ItensPedidoRepository", true)]
    public interface IItensPedidoRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarItensPedidos(int startIndex, int pageSize, string orderProperty, bool orderAscending);
    }
}