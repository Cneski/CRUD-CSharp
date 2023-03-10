using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace EstoqueMercado
{
    public class RepositoryBancoDados : IRepository
    {
        private readonly string _conexaoString;
        private DadosSingleton _dadosSingleton;

        public RepositoryBancoDados()
        {
            const string connectionString = "ConexaoBancoDados";
            _conexaoString = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            _dadosSingleton = DadosSingleton.Instancia();
        }

        public void Criar(Produtos produto)
        {
            using (var conexao = new SqlConnection(_conexaoString))
            {
                conexao.Open();
                var query = "INSERT INTO Produtos (Nome, Marca, CodigoBarras, DataVencimento, DataCadastro) " +
                    "VALUES (@Nome, @Marca, @CodigoBarras, @DataVencimento, @DataCadastro)";
                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", produto.Nome);
                    comando.Parameters.AddWithValue("@Marca", produto.Marca);
                    comando.Parameters.AddWithValue("@CodigoBarras", produto.CodigoBarras);
                    comando.Parameters.AddWithValue("@DataVencimento", produto.DataVencimento);
                    comando.Parameters.AddWithValue("@DataCadastro", produto.DataCadastro);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Produtos> ObterTodos()
        {
            List<Produtos> listaProdutos = new List<Produtos>();
            using (var conexao = new SqlConnection(_conexaoString))
            {
                conexao.Open();
                var query = "SELECT * FROM Produtos";
                using (var comando = new SqlCommand(query, conexao))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(query, conexao);
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Produtos produto = new Produtos();
                        produto.Id = Convert.ToInt32(row["Id"]);
                        produto.Nome = row["Nome"].ToString();
                        produto.Marca = row["Marca"].ToString();
                        produto.CodigoBarras = row["CodigoBarras"].ToString();
                        produto.DataVencimento = Convert.ToDateTime(row["DataVencimento"]);
                        produto.DataCadastro = Convert.ToDateTime(row["DataCadastro"]);

                       listaProdutos.Add(produto);
                    }
                }
            }
            return listaProdutos;
        }

        public Produtos ObterPorIndice(int indice)
        {
            return ObterTodos()[indice];
        }

        public void Remover(int id)
        {
            using (var conexao = new SqlConnection(_conexaoString))
            {
                conexao.Open();
                var query = "DELETE Produtos WHERE Id = @Id";
                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Editar(int id, Produtos produto)
        {
            using (var conexao = new SqlConnection(_conexaoString))
            {
                conexao.Open();
                var query = "UPDATE Produtos SET Nome = @Nome, Marca = @Marca, CodigoBarras = @CodigoBarras," +
                    " DataVencimento = @DataVencimento, DataCadastro = @DataCadastro WHERE Id = @Id";
                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", produto.Id);
                    comando.Parameters.AddWithValue("@Nome", produto.Nome);
                    comando.Parameters.AddWithValue("@Marca", produto.Marca);
                    comando.Parameters.AddWithValue("@CodigoBarras", produto.CodigoBarras);
                    comando.Parameters.AddWithValue("@DataVencimento", produto.DataVencimento);
                    comando.Parameters.AddWithValue("@DataCadastro", produto.DataCadastro);
                    comando.ExecuteNonQuery(); 
                }
            }
        }

    }
}
