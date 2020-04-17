using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechStore.View;

namespace TechStore
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCadastrarEntrada_Click(object sender, EventArgs e)
        {
            frmCadastroEntrada frmCadastroEntrada = new frmCadastroEntrada();
            frmCadastroEntrada.ShowDialog();
            frmCadastroEntrada.Dispose();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.ShowDialog();
            frmEstoque.Dispose();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
            frmCadastroProduto.Dispose();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmEntradaEstoque frmEntradaEstoque = new frmEntradaEstoque();
            frmEntradaEstoque.ShowDialog();
            frmEntradaEstoque.Dispose();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmSaidaEstoque frmfrmSaidaEstoque = new frmSaidaEstoque();
            frmfrmSaidaEstoque.ShowDialog();
            frmfrmSaidaEstoque.Dispose();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frmCadastroFornecedor = new frmCadastroFornecedor();
            frmCadastroFornecedor.ShowDialog();
            frmCadastroFornecedor.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
            frmSobre.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario frmCadastrarColaborador = new frmCadastrarFuncionario();
            frmCadastrarColaborador.ShowDialog();
            frmCadastrarColaborador.Dispose();
        }
    }
}
