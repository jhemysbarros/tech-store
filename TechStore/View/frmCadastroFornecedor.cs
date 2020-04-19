using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechStore.Model;
using TechStore.DAO;
using TechStore.Controller;

namespace TechStore.View
{
    public partial class frmCadastroFornecedor : Form
    {
        private FornecedorController fornecedorController = new FornecedorController();
        private Fornecedor fornecedor = new Fornecedor();

        public frmCadastroFornecedor()
        {
            InitializeComponent();
            Listar();
        }

        private void Salvar(Fornecedor fornecedor)
        {
            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                fornecedor.Nome = tbNome.Text;
                fornecedor.Cnpj = mtbCnpj.Text;
                fornecedor.Endereco = tbEndereco.Text;
                fornecedor.Numero = Convert.ToInt32(tbNumero.Text);
                fornecedor.Cep = mtbCep.Text;
                fornecedor.Complemento = tbComplemento.Text;
                fornecedor.Bairro = tbBairro.Text;
                fornecedor.Telefone = mtbTelefone.Text;
                fornecedor.Cidade = tbCidade.Text;
                fornecedor.Estado = cbEstado.Text;
                fornecedor.InscEstadual = mtbInscEstadual.Text;
                fornecedor.InscMunicipal = mtbInscMunicipal.Text;
                fornecedor.Email = tbEmail.Text;

                fornecedorController.Salvar(fornecedor);

                MessageBox.Show("Novo fornecedor salvo com sucesso!");

                Limpar();
                Listar();
            }
        }


        private void Editar(Fornecedor fornecedor)
        {
            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fornecedor.Id = Convert.ToInt32(tbId.Text);
                fornecedor.Nome = tbNome.Text;
                fornecedor.Cnpj = mtbCnpj.Text;
                fornecedor.Endereco = tbEndereco.Text;
                fornecedor.Numero = Convert.ToInt32(tbNumero.Text);
                fornecedor.Cep = mtbCep.Text;
                fornecedor.Complemento = tbComplemento.Text;
                fornecedor.Bairro = tbBairro.Text;
                fornecedor.Telefone = mtbTelefone.Text;
                fornecedor.Cidade = tbCidade.Text;
                fornecedor.Estado = cbEstado.Text;
                fornecedor.InscEstadual = mtbInscEstadual.Text;
                fornecedor.InscMunicipal = mtbInscMunicipal.Text;
                fornecedor.Email = tbEmail.Text;

                fornecedorController.Editar(fornecedor);

                MessageBox.Show("Fornecedor alterado com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Excluir(Fornecedor fornecedor)
        {
            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse fornecedor?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                fornecedor.Id = Convert.ToInt32(tbId.Text);
                fornecedor.Nome = tbNome.Text;
                fornecedor.Cnpj = mtbCnpj.Text;
                fornecedor.Endereco = tbEndereco.Text;
                fornecedor.Numero = Convert.ToInt32(tbNumero.Text);
                fornecedor.Cep = mtbCep.Text;
                fornecedor.Complemento = tbComplemento.Text;
                fornecedor.Bairro = tbBairro.Text;
                fornecedor.Telefone = mtbTelefone.Text;
                fornecedor.Cidade = tbCidade.Text;
                fornecedor.Estado = cbEstado.Text;
                fornecedor.InscEstadual = mtbInscEstadual.Text;
                fornecedor.InscMunicipal = mtbInscMunicipal.Text;
                fornecedor.Email = tbEmail.Text;

                fornecedorController.Excluir(fornecedor);

                MessageBox.Show("Fornecedor excluído com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Listar()
        {
            dgvFornecedor.DataSource = fornecedorController.Listar();
        }

        public void Limpar()
        {
            tbId.Clear();
            tbNome.Clear();
            mtbCnpj.Clear();
            tbEndereco.Clear();
            tbNumero.Clear();
            mtbCep.Clear();
            tbComplemento.Clear();
            tbBairro.Clear();
            mtbTelefone.Clear();
            tbCidade.Clear();
            cbEstado.Text = "";
            mtbInscEstadual.Clear();
            mtbInscMunicipal.Clear();
            tbEmail.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Salvar(fornecedor);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.techStoreDataSet.fornecedor);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Editar(fornecedor);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir(fornecedor);
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            mtbCnpj.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            tbEndereco.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            tbNumero.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            mtbCep.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
            tbComplemento.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
            tbBairro.Text = dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
            mtbTelefone.Text = dgvFornecedor.CurrentRow.Cells[8].Value.ToString();
            tbCidade.Text = dgvFornecedor.CurrentRow.Cells[10].Value.ToString();
            cbEstado.Text = dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
            mtbInscEstadual.Text = dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
            mtbInscMunicipal.Text = dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
            tbEmail.Text = dgvFornecedor.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
