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
    class EntradaDAO : Conexao
    {
        SqlCommand comando = null;

        public void Salvar(Entrada entrada)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("INSERT INTO Entrada(fornecedor, idproduto, produto, descricao, data, quantidade, preco ,total, observacao) values (@fornecedor, @idproduto, @produto, @descricao, @data, @quantidade, @preco , @total, @observacao)", conexao);


                comando.Parameters.AddWithValue("@fornecedor", entrada.Fornecador);
                comando.Parameters.AddWithValue("@idproduto", entrada.Idproduto);
                comando.Parameters.AddWithValue("@produto", entrada.Produto);
                comando.Parameters.AddWithValue("@descricao", entrada.Descricao);
                comando.Parameters.AddWithValue("@data", entrada.Data);
                comando.Parameters.AddWithValue("@quantidade", entrada.Quantidade);
                comando.Parameters.AddWithValue("@preco", entrada.Preco);
                comando.Parameters.AddWithValue("@total", entrada.Total);
                comando.Parameters.AddWithValue("@observacao", entrada.Observacao);

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

        public void Editar(Entrada entrada)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("UPDATE Entrada SET fornecedor = @fornecedor, idproduto = @idproduto, produto = @produto, descricao = @descricao, data = @data, quantidade = @quantidade, preco = @preco, total = @total, observacao = @observacao WHERE identrada = @id", conexao);

                comando.Parameters.AddWithValue("@id", entrada.Id);
                comando.Parameters.AddWithValue("@fornecedor", entrada.Fornecador);
                comando.Parameters.AddWithValue("@idproduto", entrada.Idproduto);
                comando.Parameters.AddWithValue("@produto", entrada.Produto);
                comando.Parameters.AddWithValue("@descricao", entrada.Descricao);
                comando.Parameters.AddWithValue("@data", entrada.Data);
                comando.Parameters.AddWithValue("@quantidade", entrada.Quantidade);
                comando.Parameters.AddWithValue("@preco", entrada.Preco);
                comando.Parameters.AddWithValue("@total", entrada.Total);
                comando.Parameters.AddWithValue("@observacao", entrada.Observacao);

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

        public void Excluir(Entrada entrada)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Entrada WHERE identrada = @id", conexao);

                comando.Parameters.AddWithValue("@id", entrada.Id);

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

                comando = new SqlCommand("SELECT * FROM Entrada ORDER BY identrada", conexao);

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

        public DataTable Pesquisar(Entrada entrada)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Entrada WHERE fornecedor LIKE @fornecedor", conexao);

                comando.Parameters.AddWithValue("@nome", "%" + entrada.Fornecador + "%");

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
