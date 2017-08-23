using LojaProduto.Services.Spec.DataTransferObjects;
using LojaProduto.Services.UnitTest.Common;
using System;

namespace LojaProduto.Services.UnitTest.Produto
{
    public class TestDataBase : TestBase
    {
        public DTOItensPedido PreencheItemPedido()
        {
            DTOItensPedido itemPedido = new DTOItensPedido();
            itemPedido.Produto = PreencheProduto();
            itemPedido.Pedido = PreenchePedido();
            itemPedido.QuantidadeProduto = 10;
            return itemPedido;
        }

        public DTOCategoria PreencheCategoria()
        {
            DTOCategoria categoria = new DTOCategoria();
            categoria.Nome = "Cozinha";
            categoria.CodigoIntegracao = "CAT41546";
            var categoriaSalva = GetCadastroService().SalvarCategoria(categoria);
            return categoriaSalva;
        }

        public DTOProduto PreencheProduto()
        {
            DTOProduto produto = new DTOProduto();
            produto.Categoria = PreencheCategoria();
            produto.CodigoBarra = "1234567891234";
            produto.CodigoProduto = "PRO00263";
            produto.DataFabricacao = new DateTime(2016, 08, 15);
            produto.DataVencimento = new DateTime(2018, 08, 15);
            produto.Fornecedor = PreencheFornecedor();
            produto.Nome = "Detergente";
            produto.PrecoProduto = 1M;
            produto.QuantidadeEmEstoque = 100;
            return produto;
        }

        public DTOFornecedor PreencheFornecedor()
        {
            DTOFornecedor fornecedor = new DTOFornecedor();
            fornecedor.Nome = "Limpe Mais";
            fornecedor.NomeFantasia = "Limpe Mais LTDA";
            fornecedor.Telefone = 65689568;
            fornecedor.Endereco = PreencheEndereco();
            fornecedor.Codigo = "FOR25635";
            fornecedor.Cnpj = "36569678596";
            var fornecedorSalvo = GetCadastroService().SalvarFornecedor(fornecedor);
            return fornecedorSalvo;
        }

        public DTOCliente PreencheCliente()
        {
            DTOCliente cliente = new DTOCliente();
            cliente.Nome = "Jose da Silva Filho";
            cliente.Codigo = "CLI00236";
            cliente.Cpf = "123656895632";
            cliente.Endereco = PreencheEndereco();
            cliente.Filiacao = "Jose da Silva";
            cliente.LimiteCredito = 1000.0M;
            cliente.Telefone = 23568956;
            cliente.TipoStatus = "1";
            return cliente;
        }

        public DTOEndereco PreencheEndereco()
        {
            DTOEndereco endereco = new DTOEndereco();
            endereco.Cep = "31693568";
            endereco.Cidade = "Belo Horizonte";
            endereco.Complemento = "Casa 2";
            endereco.Logradouro = "R. Dr. José da Silva";
            endereco.Numero = 235;
            endereco.Uf = "MG";
            var enderecoSalvo = GetCadastroService().SalvarEndereco(endereco);
            return enderecoSalvo;
        }

        public DTOPedido PreenchePedido()
        {
            DTOPedido pedido = new DTOPedido();
            pedido.Cliente = PreencheCliente();
            pedido.Codigo = "PED0032656";
            pedido.DataElaboracao = DateTime.Now;
            pedido.ItensPedidos.Add(PreencheItemPedido());
            pedido.statusPedido = 1;
            pedido.TipoVenda = 1;
            pedido.TipoVenda = 1;
            pedido.TotalParcelas = 10;
            return pedido;
        }
    }
}
