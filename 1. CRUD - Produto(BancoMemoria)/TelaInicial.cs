using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstoqueMercado
{
    public partial class TelaInicial : Form
    {
        private List<Produtos> TodosProdutos = new List<Produtos>();
        private int IndiceSelecionado { get; set; }

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void AoClicarEmNovo(object sender, EventArgs e)
        {
            TelaCadastro formCadastro = new TelaCadastro(TodosProdutos, this);
            formCadastro.ShowDialog();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // Define a fonte de dados do DataGridView
            BindingSource bs = new BindingSource();
            bs.DataSource = TodosProdutos;
            DataGrid_ListaProdutos.DataSource = bs;
        }

        public void AtualizarDataGridView()
        {
            DataGrid_ListaProdutos.DataSource = null;
            DataGrid_ListaProdutos.DataSource = TodosProdutos;
            DataGrid_ListaProdutos.Refresh();
        }

        private void AoClicarEmOK(object sender, EventArgs e)
        {
            Close();
        }

        bool VerificaLinhasSelecionadas(string tipo)
        {
            int quantidadeLinhasSelecionadas = DataGrid_ListaProdutos.SelectedRows.Count;
            if (quantidadeLinhasSelecionadas == 1)
            {
                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja {tipo}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show($"Selecione uma linha para {tipo} o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show($"Selecione apenas uma linha para {tipo} o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void AoClicarEmDeletar(object sender, EventArgs e)
        {
            const string TipoAcao = "Excluir";
            if (VerificaLinhasSelecionadas(TipoAcao))
            {
                IndiceSelecionado = DataGrid_ListaProdutos.CurrentRow.Index;
                TodosProdutos.RemoveAt(IndiceSelecionado);
                AtualizarDataGridView();
            }
        }

        private void AoClicarEmEditar(object sender, EventArgs e)
        {
            const string TipoAcao = "Editar";
            if (VerificaLinhasSelecionadas(TipoAcao))
            {
                IndiceSelecionado = DataGrid_ListaProdutos.CurrentRow.Index;
                TelaCadastro formCadastro = new TelaCadastro(TodosProdutos, this, IndiceSelecionado);
                formCadastro.ShowDialog();
            }
        }

    }
}
