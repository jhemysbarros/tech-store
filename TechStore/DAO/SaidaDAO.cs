using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechStore.Model;

namespace TechStore.DAO
{
    class SaidaDAO : Conexao
    {
        SqlCommand comando = null;

        public void Salvar(Saida saida)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("INSERT INTO Saida(idproduto, produto, data, quantidade) values (@idproduto, @produto, @data, @quantidade)", conexao);


                comando.Parameters.AddWithValue("@idproduto", saida.Idproduto);
                comando.Parameters.AddWithValue("@produto", saida.Produto);
                comando.Parameters.AddWithValue("@data", saida.Data);
                comando.Parameters.AddWithValue("@quantidade", saida.Quantidade);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Desconectar();
            }
        }

        public void Editar(Saida saida)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("UPDATE Saida SET idproduto = @idproduto, produto = @produto, data = @data, quantidade = @quantidade WHERE idsaida = @id", conexao);

                comando.Parameters.AddWithValue("@id", saida.Id);
                comando.Parameters.AddWithValue("@idproduto", saida.Idproduto);
                comando.Parameters.AddWithValue("@produto", saida.Produto);
                comando.Parameters.AddWithValue("@data", saida.Data);
                comando.Parameters.AddWithValue("@quantidade", saida.Quantidade);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Desconectar();
            }
        }

        public void Excluir(Saida saida)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Saida WHERE idsaida = @id", conexao);

                comando.Parameters.AddWithValue("@id", saida.Id);

                comando.ExecuteNonQuery();
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

        public DataTable Listar()
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Saida ORDER BY idsaida", conexao);

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

        public DataTable Pesquisar(Saida saida)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Saida WHERE produto LIKE @produto", conexao);

                comando.Parameters.AddWithValue("@produto", "%" + saida.Produto + "%");

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
