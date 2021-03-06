﻿using System;
using System.Windows.Forms;
using TechStore.Model;
using TechStore.Controller;

namespace TechStore.View
{
    public partial class frmCadastrarCategoria : Form
    {
        private CategoriaController categoriaController = new CategoriaController();
        private Categoria categoria = new Categoria();

        public frmCadastrarCategoria()
        {
            InitializeComponent();
            Listar();
        }

        private void Salvar(Categoria categoria)
        {

            if (tbCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome da categoria não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCategoria.Focus();
            }
            else
            {
                categoria.nome = tbCategoria.Text;

                categoriaController.Salvar(categoria);

                MessageBox.Show("Nova categoria cadastrada com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Editar(Categoria categoria)
        {
            if (tbCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome da categoria não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                categoria.id = Convert.ToInt32(tbId.Text);
                categoria.nome = tbCategoria.Text;

                categoriaController.Editar(categoria);

                MessageBox.Show("Categoria alterada com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Excluir(Categoria categoria)
        {
            if (tbCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir essa categoria?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                categoria.id = Convert.ToInt32(tbId.Text);

                categoriaController.Excluir(categoria);

                MessageBox.Show("Categoria excluida com sucesso!");

                Limpar();
                Listar();
            }
        }

        private void Listar()
        {
            dgvCategoria.DataSource = categoriaController.Listar();
        }

        private void Pesquisar(Categoria categoria)
        {
            categoria.nome = tbBuscarCategoria.Text;
            dgvCategoria.DataSource = categoriaController.Pesquisar(categoria);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            Pesquisar(categoria);

            if (tbBuscarCategoria.Text == "")
            {
                Listar();
                return;
            }
        }

        public void Limpar()
        {
            tbId.Clear();
            tbCategoria.Clear();
            tbBuscarCategoria.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(categoria);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Editar(categoria);
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            Excluir(categoria);
        }

        private void frmCadastrarCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.techStoreDataSet.categoria);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            tbCategoria.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();

            tbBuscarCategoria.Clear();
        }
    }
}
