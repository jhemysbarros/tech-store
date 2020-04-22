using System;
using System.Windows.Forms;
using TechStore.View;
using TechStore.Model;
using TechStore.Controller;

namespace TechStore
{
    public partial class frmCadastroEntrada : Form
    {
        private EntradaController entradaController = new EntradaController();
        private Entrada entrada = new Entrada();

        public frmCadastroEntrada()
        {
            InitializeComponent();
        }

        private void Salvar(Entrada entrada)
        {
            if (tbEntradaFornecedor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do fornecedor não pode estar em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                entrada.Fornecador = tbEntradaFornecedor.Text;
                entrada.Idproduto = Convert.ToInt32(tbEntradaId.Text);
                entrada.Produto = tbEntradaProduto.Text;
                entrada.Descricao = tbEntradaDescricao.Text;
                entrada.Data = Convert.ToDateTime(dtpData.Text);
                entrada.Quantidade = Convert.ToInt32(tbQuantidade.Text);
                entrada.Preco = Convert.ToDecimal(tbPreco.Text);
                entrada.Total = Convert.ToDecimal(tbTotal.Text);
                entrada.Observacao = rtbObservacao.Text;

                entradaController.Salvar(entrada);

                MessageBox.Show("Nova entrada salva com sucesso!");

                Limpar();
            }
        }

        public void Limpar()
        {
            tbEntradaId.Clear();
            tbEntradaFornecedor.Clear();
            tbEntradaProduto.Clear();
            tbEntradaDescricao.Clear();
            tbQuantidade.Clear();
            tbPreco.Clear();
            tbTotal.Clear();
            rtbObservacao.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto(this);
            frmCadastroProduto.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frmCadastroFornecedor = new frmCadastroFornecedor(this);
            frmCadastroFornecedor.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(entrada);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmEntradaEstoque frmEntradaEstoque = new frmEntradaEstoque();
            frmEntradaEstoque.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmSaidaEstoque frmSaidaEstoque = new frmSaidaEstoque();
            frmSaidaEstoque.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.ShowDialog();
        }
    }
}
