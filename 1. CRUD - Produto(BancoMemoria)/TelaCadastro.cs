using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstoqueMercado
{
    public partial class TelaCadastro : Form
    {
        public List<Produtos> TodosProdutos;
        private TelaInicial formInicial;
        private static int ProximoId = 1;
        private static HashSet<int> IdsUsados = new HashSet<int>();
        public int IndiceSelecionado { get; set; }

        public TelaCadastro(List<Produtos> TodosProdutos, TelaInicial formInicial, int IndiceSelecionado = -1)
        {
            InitializeComponent();
            this.TodosProdutos = TodosProdutos;
            this.formInicial = formInicial;
            this.IndiceSelecionado = IndiceSelecionado;
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            CarregarDadosProduto();
        }

        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                return;
            }

            if (IndiceSelecionado >= 0)
            {
                Produtos produto = TodosProdutos[IndiceSelecionado];
                produto.Nome = txtNomeProduto.Text;
                produto.Marca = txtMarca.Text;
                produto.CodigoBarras = txtCodigoBarras.Text;
                produto.DataVencimento = DataVencimento.Value;
                produto.DataCadastro = DateTime.Now;

                produto = TodosProdutos[IndiceSelecionado];
            }
            else
            {
                Produtos novoProduto = new Produtos();

                novoProduto.Id = TodosProdutos.Count;
                novoProduto.Nome = txtNomeProduto.Text;
                novoProduto.Marca = txtMarca.Text;
                novoProduto.CodigoBarras = txtCodigoBarras.Text;
                novoProduto.DataVencimento = DataVencimento.Value;
                novoProduto.DataCadastro = DateTime.Now;

                while (IdsUsados.Contains(ProximoId))
                {
                    ProximoId++;
                }

                novoProduto.Id = ProximoId;
                this.TodosProdutos.Add(novoProduto);
                IdsUsados.Add(novoProduto.Id);
            }

            formInicial.AtualizarDataGridView();

            MessageBox.Show("Produto Cadastrado!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.Close();
        }

        private void CarregarDadosProduto()
        {
            if (IndiceSelecionado >= 0)
            {
                Produtos produto = TodosProdutos[IndiceSelecionado];
                txtNomeProduto.Text = produto.Nome;
                txtMarca.Text = produto.Marca;
                txtCodigoBarras.Text = produto.CodigoBarras;
                DataVencimento.Value = produto.DataVencimento;
            }
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
