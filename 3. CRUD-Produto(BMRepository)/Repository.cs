using System;
using System.Collections.Generic;
using System.Linq;

namespace EstoqueMercado
{

    public class Repository : IRepository
    {
        private DadosSingleton _dadosSingleton;

        public Repository()
        {
            _dadosSingleton = DadosSingleton.Instancia();
        }

        public List<Produtos> ObterTodos()
        {
            return _dadosSingleton.ListaProdutos.Cast<Produtos>().ToList();
        }

        public Produtos ObterPorIndice(int indice)
        {
            return _dadosSingleton.ListaProdutos[indice];
        }

        public void Remover(int indice)
        {
            _dadosSingleton.ListaProdutos.RemoveAt(indice);
        }

        public void Criar(Produtos produto)
        { 
            produto.Id = _dadosSingleton.GerarId();
            _dadosSingleton.ListaProdutos.Add(produto);
        }

        public void Atualizar(int indice, Produtos produto)
        {
            _dadosSingleton.ListaProdutos[indice] = produto;
        }
    }
}
