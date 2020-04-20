using System;
using System.Windows.Forms;
using TechStore.Model;
using TechStore.Controller;

namespace TechStore.View
{
    public partial class frmCadastroProduto : Form
    {
        private ProdutoController produtoController = new ProdutoController();
        private CategoriaController categoriaController = new CategoriaController();
        private Produto produto = new Produto();

        public frmCadastroProduto()
        {
            InitializeComponent();
            Listar();
        }

        private void Salvar(Produto produto)
        {
            if (tbProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do produto não pode estar em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                produto.Nome = tbProduto.Text;
                produto.Descricao = tbDescricao.Text;
                produto.Preco = Convert.ToDecimal(tbPreco.Text);
                produto.Idcategoria = Convert.ToInt32(cbCategoria.SelectedValue);

                produtoController.Salvar(produto);

                MessageBox.Show("Novo produto cadastrado com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(produto);
        }

        private void Editar(Produto produto)
        {
            if (tbProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do produto não pode estar em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                produto.Id = Convert.ToInt32(tbId.Text);
                produto.Nome = tbProduto.Text;
                produto.Descricao = tbDescricao.Text;
                produto.Preco = Convert.ToDecimal(tbPreco.Text);
                produto.Idcategoria = Convert.ToInt32(cbCategoria.SelectedValue);

                produtoController.Editar(produto);

                MessageBox.Show("Produto alterado com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Editar(produto);
        }

        private void Excluir(Produto produto)
        {
            if (tbProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                produto.Id = Convert.ToInt32(tbId.Text);
                produto.Nome = tbProduto.Text;
                produto.Descricao = tbDescricao.Text;
                produto.Preco = Convert.ToDecimal(tbPreco.Text);
                produto.Idcategoria = Convert.ToInt32(cbCategoria.SelectedValue);


                produtoController.Excluir(produto);

                MessageBox.Show("Produto excluído com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir(produto);
        }

        private void Listar()
        {
            dgvProduto.DataSource = produtoController.Listar();
        }

        public void Limpar()
        {
            tbId.Clear();
            tbProduto.Clear();
            tbDescricao.Clear();
            tbPreco.Clear();
            cbCategoria.SelectedIndex = -1; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
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
            cbCategoria.DataSource = categoriaController.Listar();
            cbCategoria.ValueMember = "idcategoria";
            cbCategoria.DisplayMember = "nome";

            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.techStoreDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.techStoreDataSet.categoria);

            Listar();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            tbProduto.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            tbDescricao.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
            tbPreco.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            cbCategoria.SelectedValue = dgvProduto.CurrentRow.Cells[4].Value.ToString();            
        }        
    }
}
