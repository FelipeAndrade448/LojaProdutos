using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace LojaProduto.Integration.Spec
{
    [ObjectMap("CategoriaRepository", true)]
    public interface ICategoriaRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarCategorias(int startIndex, int pageSize, string orderProperty, bool orderAscending);
    }
}