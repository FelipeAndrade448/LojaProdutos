using LojaProduto.Services.Spec.Services;
using SQFramework.Net.Services;

namespace LojaProduto.Services.UnitTest.Common
{
    public abstract class TestBase 
    {
        private ServiceLocator serviceLocator = new ServiceLocator();
        public ICadastroService GetCadastroService()
        {
            return serviceLocator.GetService<ICadastroService>("lojaproduto.servicos/cadastrosService");
        }
        public int CodigoCliente { get { return 5; } }
    }
}
