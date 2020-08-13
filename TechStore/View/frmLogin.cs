using System;
using System.Windows.Forms;
using TechStore.Controller;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace TechStore
{
    public partial class frmLogin : Form
    {
        SqlCommand comando = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-DP6GSUO\\SQLEXPRESS;Initial Catalog=TechStore;Integrated Security=True");

                comando = new SqlCommand("SELECT cargo FROM Funcionario WHERE email = '" + tbEmail.Text + "' AND senha = '" + tbSenha.Text + "' ", conexao);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                sqlDataAdapter.SelectCommand = comando;

                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    this.Hide();
                    frmPrincipal frmPrincipal = new frmPrincipal(dataTable.Rows[0][0].ToString());
                    frmPrincipal.Show();
                }
                else
                {
                    lblMensagem.Text = "Usuário ou senha incorretos!";
                    lblMensagem.ForeColor = Color.Red;
                    tbEmail.Clear();
                    tbSenha.Clear();
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
