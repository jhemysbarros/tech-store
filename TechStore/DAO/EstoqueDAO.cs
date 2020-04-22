using System;
using System.Data;
using System.Data.SqlClient;
using TechStore.Model;

namespace TechStore.DAO
{
    class EstoqueDAO : Conexao
    {
        SqlCommand comando = null;
        public DataTable Listar()
        {
            try
            {
                Conectar();

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                comando = new SqlCommand("SELECT identrada, produto, quantidade FROM Entrada ORDER BY produto", conexao);

                sqlDataAdapter.SelectCommand = comando;

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable Pesquisar(Entrada entrada)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Entrada WHERE produto LIKE @produto", conexao);

                comando.Parameters.AddWithValue("@produto", "%" + entrada.Produto + "%");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = comando;

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
