using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TechStore.Model;
using System.Data;

namespace TechStore.DAO
{
    class ProdutoDAO : Conexao
    {
        SqlCommand comando = null;
        public void Salvar(Produto produto)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("INSERT INTO Produto(produto, descricao, preco, fk_categoria) VALUES (@nome, @descricao, @preco, @idcategoria)", conexao);

                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@idcategoria", produto.Idcategoria);

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

        public void Editar(Produto produto)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("UPDATE Produto set produto = @produto, descricao = @descricao, preco = @preco, fk_categoria = @idcategoria WHERE idproduto = @id", conexao);

                comando.Parameters.AddWithValue("@id", produto.Id);
                comando.Parameters.AddWithValue("@produto", produto.Nome);
                comando.Parameters.AddWithValue("@descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@idcategoria", produto.Idcategoria);

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

        public void Excluir(Produto produto)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Produto WHERE idproduto = @id", conexao);

                comando.Parameters.AddWithValue("@id", produto.Id);

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

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                comando = new SqlCommand("SELECT * FROM Produto ORDER BY produto", conexao);

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
    }
}
