using System;
using System.Windows.Forms;

namespace EstoqueMercado
{
    public partial class TelaInicial : Form
    {
        private int Indice { get; set; }
        private readonly IRepository Repository;

        public TelaInicial(IRepository repository)
        {
            InitializeComponent();
            this.Repository = repository;
        }

        private void AoClicarEmNovo(object sender, EventArgs e)
        {
            TelaCadastro formCadastro = new TelaCadastro(this, Repository);
            formCadastro.ShowDialog();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Repository.ObterTodos();
            DataGrid_ListaProdutos.DataSource = bs;
        }

        public void AtualizarDataGridView()
        {
            DataGrid_ListaProdutos.DataSource = null;
            DataGrid_ListaProdutos.DataSource = Repository.ObterTodos();
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
                int id = (int)DataGrid_ListaProdutos.Rows[Indice].Cells[0].Value;
                Repository.Remover(id);
                AtualizarDataGridView();
            }

        }

        private void AoClicarEmEditar(object sender, EventArgs e)
        {
            const string TipoAcao = "Editar";
            if (VerificaLinhasSelecionadas(TipoAcao))
            {
                Indice = DataGrid_ListaProdutos.CurrentRow.Index;
                TelaCadastro formCadastro = new TelaCadastro(this, Indice, Repository);
                formCadastro.ShowDialog();
            }
              
        }

    }
}
