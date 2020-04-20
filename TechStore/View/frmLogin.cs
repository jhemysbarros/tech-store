using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechStore.DAO;
using TechStore.Model;
using TechStore.Controller;

namespace TechStore
{
    public partial class frmLogin : Form
    {
        FuncionarioController funcionarioController = new FuncionarioController();
        public frmLogin()
        {
            InitializeComponent();
        }

        public void Logar(Funcionario funcionario)
        {
            try
            {
                if (tbEmail.Text == string.Empty)
                {
                    MessageBox.Show("Informe o usuário!");
                    tbEmail.Focus();
                    return;
                }

                if (tbSenha.Text == string.Empty)
                {
                    MessageBox.Show("Informe a senha!");
                    tbSenha.Focus();
                    return;
                }

                funcionario.Email = tbEmail.Text;
                funcionario.Senha = tbSenha.Text;

                funcionario = funcionarioController.Login(funcionario);

                if (funcionario.Email == null)
                {
                    lblMensagem.Text = "Usuário ou senha incorretos!";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }

                frmPrincipal frmPrincipal = new frmPrincipal();
                this.Hide();
                frmPrincipal.Show();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            Logar(funcionario);

            tbEmail.Clear();
            tbSenha.Clear();
        }
    }
}
