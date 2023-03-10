using System.Collections.Generic;

namespace EstoqueMercado
{
    public interface IRepository
    {
        List<Produtos> ObterTodos();
        Produtos ObterPorIndice(int indice);
        void Remover(int indice);
        void Criar(Produtos produto);
        void Atualizar(int indice, Produtos produto);
    }
}