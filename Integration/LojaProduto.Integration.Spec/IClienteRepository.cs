using SQFramework.Spring;
using SQFramework.Data;
using SQFramework.Data.Pagging;

namespace LojaProduto.Integration.Spec
{
    [ObjectMap("ClienteRepository", true)]
    public interface IClienteRepository<T> : IRepositoryBase<T>
    {
        PageMessage<T> ListarClientes(int startIndex, int pageSize, string orderProperty, bool orderAscending);

        T PesquisaCliente(string cpf, string codigo);
    }


}