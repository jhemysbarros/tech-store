﻿using System;
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
            Listar();
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
                funcionario.Estado = cbEstado.Text;
                funcionario.Senha = tbSenha.Text;
                funcionario.Cargo = cbCargo.Text;

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
                funcionario.Estado = cbEstado.Text;
                funcionario.Senha = tbSenha.Text;
                funcionario.Cargo = cbCargo.Text;

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
                funcionario.Estado = cbEstado.Text;
                funcionario.Senha = tbSenha.Text;
                funcionario.Cargo = cbCargo.Text;

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
            tbId.Clear();
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
            cbEstado.Text = "";
            tbSenha.Clear();
            cbCargo.Text = "";
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

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
            tbEndereco.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
            tbNumero.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            mtbCep.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
            tbComplemento.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
            tbBairro.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
            mtbCelular.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
            tbEmail.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
            tbCidade.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
            cbEstado.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
            tbSenha.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
            cbCargo.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
