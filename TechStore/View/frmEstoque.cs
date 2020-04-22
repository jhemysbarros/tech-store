using System;
using System.Windows.Forms;
using TechStore.Controller;
using TechStore.Model;

namespace TechStore.View
{
    public partial class frmEstoque : Form
    {
        private EstoqueController estoqueController = new EstoqueController();
        private Entrada entrada = new Entrada();

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            dgvEstoque.DataSource = estoqueController.Listar();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.techStoreDataSet.estoque);
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.entrada'. Você pode movê-la ou removê-la conforme necessário.
            this.entradaTableAdapter.Fill(this.techStoreDataSet.entrada);
            Listar();
        }

        private void Limpar()
        {
            tbProduto.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Pesquisar(Entrada entrada)
        {
            entrada.Produto = tbProduto.Text;
            dgvEstoque.DataSource = estoqueController.Pesquisar(entrada);
        }

        private void tbProduto_TextChanged(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            Pesquisar(entrada);

            if (tbProduto.Text == "")
            {
                Listar();
                return;
            }
        }

        private void dgvEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCadastroSaida frmCadastroSaida = new frmCadastroSaida();
            frmCadastroSaida.ShowDialog();
        }
    }
}
