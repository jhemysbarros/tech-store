using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStore
{
    public partial class frmCadastroEntrada : Form
    {
        public frmCadastroEntrada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbFornecedor.Text = "";
            tbProduto.Text = "";
            tbDescricao.Text = "";
            mtbData.Text = "";
            mtbHora.Text = "";
            tbQuantidade.Text = "";
            tbPreco.Text = "";
            tbTotal.Text = "";
            rtbObservacao.Text = "";
        }
    }
}
