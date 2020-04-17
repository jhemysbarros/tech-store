using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechStore.DAO
{
    public class Conexao
    {
        string conecta = "Data Source=DESKTOP-DP6GSUO\\SQLEXPRESS;Initial Catalog=TechStore;Integrated Security=True";
        protected SqlConnection conexao = null;

        //Método para conectar no banco de dados
        public void Conectar()
        {
            try
            {
                conexao = new SqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        //Método para desconectar do banco de dados
        public void Desconectar()
        {
            try
            {
                conexao = new SqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
