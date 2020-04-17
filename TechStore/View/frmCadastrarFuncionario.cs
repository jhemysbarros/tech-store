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
    public partial class frmCadastrarFuncionario : Form
    {
        FuncionarioController funcionarioController = new FuncionarioController();
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
            Limpar();
        }

        private void Salvar(Funcionario funcionario)
        {
            FuncionarioController funcionarioController = new FuncionarioController();

            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                funcionario.Nome = tbNome.Text;
                funcionario.Cpf = mtbCpf.Text;
                funcionario.Endereco = tbEndereco.Text;
                funcionario.Numero = Convert.ToInt32(tbNumero.Text);
                funcionario.Cep = mtbCep.Text;
                funcionario.Complemento = tbComplemento.Text;
                funcionario.Bairro = tbBairro.Text;
                funcionario.Telefone = mtbCelular.Text;
                funcionario.Email = tbEmail.Text;
                funcionario.Cidade = tbCidade.Text;
                funcionario.Estado = tbEstado.Text;
                funcionario.Senha = tbSenha.Text;
                funcionario.Cargo = tbCargo.Text;

                funcionarioController.Salvar(funcionario);

                MessageBox.Show("Novo funcionário salvo com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Editar(Funcionario funcionario)
        {
            FuncionarioController funcionarioController = new FuncionarioController();

            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                funcionario.Id = Convert.ToInt32(tbId.Text);
                funcionario.Nome = tbNome.Text;
                funcionario.Cpf = mtbCpf.Text;
                funcionario.Endereco = tbEndereco.Text;
                funcionario.Numero = Convert.ToInt32(tbNumero.Text);
                funcionario.Cep = mtbCep.Text;
                funcionario.Complemento = tbComplemento.Text;
                funcionario.Bairro = tbBairro.Text;
                funcionario.Telefone = mtbCelular.Text;
                funcionario.Email = tbEmail.Text;
                funcionario.Cidade = tbCidade.Text;
                funcionario.Estado = tbEstado.Text;
                funcionario.Senha = tbSenha.Text;
                funcionario.Cargo = tbCargo.Text;

                funcionarioController.Editar(funcionario);

                MessageBox.Show("Funcionario alterado com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Excluir(Funcionario funcionario)
        {
            CategoriaController categoriaController = new CategoriaController();

            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse funcionário?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                funcionario.Id = Convert.ToInt32(tbId.Text);
                funcionario.Nome = tbNome.Text;
                funcionario.Cpf = mtbCpf.Text;
                funcionario.Endereco = tbEndereco.Text;
                funcionario.Numero = Convert.ToInt32(tbNumero.Text);
                funcionario.Cep = mtbCep.Text;
                funcionario.Complemento = tbComplemento.Text;
                funcionario.Bairro = tbBairro.Text;
                funcionario.Telefone = mtbCelular.Text;
                funcionario.Email = tbEmail.Text;
                funcionario.Cidade = tbCidade.Text;
                funcionario.Estado = tbEstado.Text;
                funcionario.Senha = tbSenha.Text;
                funcionario.Cargo = tbCargo.Text;

                funcionarioController.Excluir(funcionario);

                MessageBox.Show("Funcionário excluido com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Listar()
        {
            FuncionarioController funcionarioController = new FuncionarioController();

            dgvFuncionario.DataSource = funcionarioController.Listar();
        }

        public void Limpar()
        {
            tbNome.Clear();
            mtbCpf.Clear();
            tbEndereco.Clear();
            tbNumero.Clear();
            mtbCep.Clear();
            tbComplemento.Clear();
            tbBairro.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbCidade.Clear();
            tbEstado.Clear();
            tbSenha.Clear();
            tbCargo.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            Salvar(funcionario);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmCadastrarFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.techStoreDataSet.funcionario);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            Editar(funcionario);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            Excluir(funcionario);
        }
    }
}
