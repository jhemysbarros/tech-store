using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechStore.Controller;
using TechStore.Model;

namespace TechStore.View
{
    public partial class frmEntradaEstoque : Form
    {
        private EntradaController entradaController = new EntradaController();
        private Entrada entrada = new Entrada();
        public frmEntradaEstoque()
        {
            InitializeComponent();
            Listar();
        }

        private void Limpar()
        {
            tbId.Clear();
            tbProduto.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Excluir(Entrada entrada)
        {
            if (tbId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir essa entrada?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                entrada.Id = Convert.ToInt32(tbId.Text);
                entrada.Produto = tbProduto.Text;
                

                entradaController.Excluir(entrada);

                MessageBox.Show("Funcionário excluido com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir(entrada);
        }

        private void Listar()
        {
            dgvEntradaEstoque.DataSource = entradaController.Listar();
        }

        private void dgvEntradaEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvEntradaEstoque.CurrentRow.Cells[0].Value.ToString();
            tbProduto.Text = dgvEntradaEstoque.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
