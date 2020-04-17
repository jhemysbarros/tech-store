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
        FornecedorController fornecedorController = new FornecedorController();
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void Fornecedor()
        {
            Fornecedor obj = new Fornecedor();
            obj.Nome = tbNome.Text;
            obj.Cnpj = mtbCnpj.Text;
            obj.Endereco = tbEndereco.Text;
            obj.Numero = Convert.ToInt32(tbNumero.Text);
            obj.Cep = mtbCep.Text;
            obj.Complemento = tbComplemento.Text;
            obj.Bairro = tbBairro.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Cidade = tbCidade.Text;
            obj.Estado = tbEstado.Text;
            obj.InscEstadual = mtbInscEstadual.Text;
            obj.InscMunicipal = mtbInscMunicipal.Text;
            obj.Email = tbEmail.Text;
            if (tbNome.Text != "")
            {
                if (fornecedorController.CadastrarFornecedor(obj) != null)
                {
                    MessageBox.Show("Cadastro realizado de: " + obj.Nome);
                    DataTable dt = new DataTable();
                    dt = FornecedorDAO.returnDataSource();
                    tbNome.Text = "";
                    mtbCnpj.Text = "";
                    tbEndereco.Text = "";
                    tbNumero.Text = "";
                    mtbCep.Text = "";
                    tbComplemento.Text = "";
                    tbBairro.Text = "";
                    mtbTelefone.Text = "";
                    tbCidade.Text = "";
                    tbEstado.Text = "";
                    mtbInscEstadual.Text = "";
                    mtbInscMunicipal.Text = "";
                    tbEmail.Text = "";

                }
                else
                {
                    MessageBox.Show("Cadastro não realizado de : " + obj.Nome);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fornecedor();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Text = "";
            mtbCnpj.Text = "";
            tbEndereco.Text = "";
            tbNumero.Text = "";
            mtbCep.Text = "";
            tbComplemento.Text = "";
            tbBairro.Text = "";
            mtbTelefone.Text = "";
            tbCidade.Text = "";
            tbEstado.Text = "";
            mtbInscEstadual.Text = "";
            mtbInscMunicipal.Text = "";
            tbEmail.Text = "";
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techStoreDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.techStoreDataSet.fornecedor);

        }
    }
}
