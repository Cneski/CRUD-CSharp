using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstoqueMercado
{
    public partial class TelaCadastro : Form
    {
        private Produtos ProdutoAtual { get; set; }
        private TelaInicial formInicial;
        private int _id;
        private int Indice { get; set; }
        Repository Repository = new Repository();

        public TelaCadastro(TelaInicial formInicial, int indice = -1)
        {
            InitializeComponent();
            this.formInicial = formInicial;
            Indice = indice;

            if (indice >= 0)
            {
                ProdutoAtual = Repository.ObterPorIndice(indice);
            }
            else
            {
                ProdutoAtual = new Produtos();
                if (ProdutoAtual.Id > 0 && Indice < ProdutoAtual.Id)
                {
                    _id = DadosSingleton.Instancia().GerarId();
                    _id--;

                }
            }
        }

        private void CarregarCampos()
        {
            if (Indice >= 0)
            {
                _id = ProdutoAtual.Id;
                txtNomeProduto.Text = ProdutoAtual.Nome;
                txtMarca.Text = ProdutoAtual.Marca;
                txtCodigoBarras.Text = ProdutoAtual.CodigoBarras;
                DataVencimento.Value = ProdutoAtual.DataVencimento;
            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            CarregarCampos();
        }

        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void SalvarProduto()
        {
            ProdutoAtual.Id = _id;
            ProdutoAtual.Nome = txtNomeProduto.Text;
            ProdutoAtual.Marca = txtMarca.Text;
            ProdutoAtual.CodigoBarras = txtCodigoBarras.Text;
            ProdutoAtual.DataVencimento = DataVencimento.Value;
            ProdutoAtual.DataCadastro = DateTime.Now;
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                return;
            }
            SalvarProduto();
            if (Indice >= 0)
            {
                Repository.Atualizar(Indice, ProdutoAtual);
            }
            else
            {
                Repository.Criar(ProdutoAtual);
            }
            formInicial.AtualizarDataGridView();
            MessageBox.Show("Produto Cadastrado!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private bool Validacoes()
        {
            List<string> erros = new List<string>();

            if (txtNomeProduto.Text == "")
            {
                erros.Add("Preencha o campo Nome.");
            }

            if (txtMarca.Text == "")
            {
                erros.Add("Preencha o campo Marca.");
            }

            if (txtCodigoBarras.Text == "")
            {
                erros.Add("Preencha o campo Código de Barras.");
            }

            if (txtCodigoBarras.Text.Length > 0)
            {
                if (txtCodigoBarras.Text.Length != 13)
                {
                    erros.Add("O código de barras deve ter 13 dígitos.");
                }

                if (!long.TryParse(txtCodigoBarras.Text, out _))
                {
                    erros.Add("O código de barras só pode conter números.");

                }

                if (!txtCodigoBarras.Text.StartsWith("789"))
                {
                    erros.Add("Os 3 primeiros dígitos do código de barras devem começar com 789.");
                }
            }

            if (DataVencimento.Value < DateTime.Now)
            {
                erros.Add("Produto fora da Data de Validade.");
            }

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
