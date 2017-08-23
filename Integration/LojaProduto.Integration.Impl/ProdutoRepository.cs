﻿using NHibernate.Criterion;
using System.Collections.Generic;
using LojaProduto.Domain.Entities;
using LojaProduto.Integration.Spec;
using SQFramework.Data.Pagging;
using SQFramework.Spring.Data.Hibernate;

namespace LojaProduto.Integration.Impl
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository<Produto>
    {
        public PageMessage<Produto> ListarProdutos(int startIndex, int pageSize, string orderProperty, bool orderAscending)
        {
            var criteria = DetachedCriteria.For<Produto>();

            return Page<Produto>(criteria, startIndex, pageSize, orderProperty, orderAscending);
        }

        public IList<Produto> PesquisarProdutos(string pesquisa)
        {
            var criteria = DetachedCriteria.For<Produto>();
            var resultado = "%" + pesquisa + "%";

            if (!string.IsNullOrEmpty(pesquisa))
                criteria.Add(Restrictions.Like("nome", resultado));
            
            var result = this.List<Produto>(criteria);
              
            return result;
        }
    }
}