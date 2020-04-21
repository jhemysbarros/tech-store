using System;
using System.Windows.Forms;
using TechStore.Controller;
using TechStore.Model;

namespace TechStore.View
{
    public partial class frmSaidaEstoque : Form
    {
        private SaidaController saidaController = new SaidaController();
        private Saida saida = new Saida();
        public frmSaidaEstoque()
        {
            InitializeComponent();
            Listar();
        }

        private void Excluir(Saida saida)
        {
            if (tbId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir essa saida?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                saida.Id = Convert.ToInt32(tbId.Text);
                saida.Produto = tbProduto.Text;


                saidaController.Excluir(saida);

                MessageBox.Show("Funcionário excluido com sucesso!");

                Limpar();
                Listar();
            }
        }
        private void dgvEntradaEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvSaidaProduto.CurrentRow.Cells[0].Value.ToString();
            tbProduto.Text = dgvSaidaProduto.CurrentRow.Cells[3].Value.ToString();
        }

        private void Listar()
        {
            dgvSaidaProduto.DataSource = saidaController.Listar();
        }

        private void Limpar()
        {
            tbId.Clear();
            tbProduto.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmSaidaEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.saida'. Você pode movê-la ou removê-la conforme necessário.
            this.saidaTableAdapter.Fill(this.techStoreDataSet.saida);
        }
    }
}
