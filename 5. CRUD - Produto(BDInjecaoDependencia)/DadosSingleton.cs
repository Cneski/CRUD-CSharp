using EstoqueMercado;
using System.Collections.Generic;

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

}
