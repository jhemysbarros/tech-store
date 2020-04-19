using System;
using System.Windows.Forms;
using TechStore.Model;
using TechStore.Controller;

namespace TechStore.View
{
    public partial class frmCadastroProduto : Form
    {
        private CategoriaController categoriaController = new CategoriaController();

        public frmCadastroProduto()
        {
            InitializeComponent();
            //Listar();
        }

        private void Salvar(Produto produto)
        {
            if (tbProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Produto não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                produto.Nome = tbProduto.Text;
                produto.Descricao = tbDescricao.Text;
                produto.Preco = 0;
                produto.Categoria.id = Convert.ToInt32(cbCategoria.Text);

                //categoriaController.Salvar(produto);

                MessageBox.Show("Nova categoria salva com sucesso!");

                Limpar();
                //Listar();
            }
        }


        public void Limpar()
        {
            tbId.Clear();
            tbProduto.Clear();
            tbDescricao.Clear();
            tbPreco.Clear();
            cbCategoria.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrarCategoria cadastrarCategoria = new frmCadastrarCategoria();
            cadastrarCategoria.ShowDialog();
            cadastrarCategoria.Dispose();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.techStoreDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.techStoreDataSet.categoria);
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            tbProduto.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            tbDescricao.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
            tbPreco.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            cbCategoria.Text = dgvProduto.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
