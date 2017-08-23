using LojaProduto.Services.UnitTest.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaProduto.Services.UnitTest.Produto
{
    [TestClass]
    public class ProdutoUnitTest : TestBase
    {
        [TestCategory("Produto")]
        [TestMethod]
        public void AlterarCodigoBarra()
        {
            var database = new TestDataBase();
            var dados = database.PreencheProduto();
            var produto = GetCadastroService().SalvarProduto(dados);

             var codigoBarra = produto.CodigoBarra = "46546546545156";

            var alteracao = GetCadastroService().AlterarCodigoBarra(produto.Id, codigoBarra);
            var codigoAlterado = produto.CodigoBarra;
            Assert.IsNotNull(alteracao);
            Assert.AreEqual("46546546545156", codigoAlterado);
        }
    }
}
