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
                comando.Parameters.AddWithValue("@idcategoria", produto.Categoria.id);

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
    }
}
