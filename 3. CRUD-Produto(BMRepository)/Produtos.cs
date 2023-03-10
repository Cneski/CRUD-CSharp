using System;

namespace EstoqueMercado
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
    }

}
