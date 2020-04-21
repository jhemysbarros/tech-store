using System;
using System.Windows.Forms;
using TechStore.Controller;
using TechStore.Model;

namespace TechStore.View
{
    public partial class frmCadastroSaida : Form
    {
        private SaidaController saidaController = new SaidaController();
        private Saida saida = new Saida();

        public frmCadastroSaida()
        {
            InitializeComponent();
        }

        private void Salvar(Saida saida)
        {
            if (tbProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do produto não pode estar em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                saida.Idproduto = Convert.ToInt32(tbId.Text);
                saida.Produto = tbProduto.Text;
                saida.Data = Convert.ToDateTime(dtpData.Text);
                saida.Quantidade = Convert.ToInt32(tbQuantidade.Text);

                saidaController.Salvar(saida);

                MessageBox.Show("Nova entrada salva com sucesso!");

                Limpar();
            }
        }

        private void Limpar()
        {
            tbId.Clear();
            tbProduto.Clear();
            tbQuantidade.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Salvar(saida);
        }
    }
}
