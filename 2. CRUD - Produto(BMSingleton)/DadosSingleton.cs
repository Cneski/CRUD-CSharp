using EstoqueMercado;
using System.Collections.Generic;
using System.Windows.Forms;

public class DadosSingleton
{
    private static DadosSingleton _instancia;
    private List<Produtos> _listaProdutos;
    private int _idAtual;

    private DadosSingleton()
    {
        _listaProdutos = new List<Produtos>();
        _idAtual = 0;
    }

    public static DadosSingleton Instancia()
    {
        if (_instancia == null)
        {
            _instancia = new DadosSingleton();
        }
        return _instancia;
    }

    public List<Produtos> ListaProdutos
    {
        get { return _listaProdutos; }
    }

    public int GerarId()
    {
        return ++_idAtual;
    }

    public void AdicionarProduto(Produtos produto)
    {
        _listaProdutos.Add(produto);
    }

    public void AtualizarProduto(int indice, Produtos produto)
    {
        _listaProdutos[indice] = produto;
    }

    public void RemoverProduto(int indice)
    {
        _listaProdutos.RemoveAt(indice);
    }

    public Produtos ObterProduto(int indice)
    {
        return _listaProdutos[indice];
    }

}
