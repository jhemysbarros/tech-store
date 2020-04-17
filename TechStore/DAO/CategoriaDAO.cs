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

    class CategoriaDAO : Conexao2
    {
        SqlCommand comando = null;
        public void Salvar(Categoria categoria)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("INSERT INTO Categoria(nome) VALUES (@nome)", conexao);

                comando.Parameters.AddWithValue("@nome", categoria.nome);

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

        public void Editar(Categoria categoria)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("UPDATE Categoria SET nome = @nome WHERE idcategoria = @id", conexao);

                comando.Parameters.AddWithValue("@id", categoria.id);
                comando.Parameters.AddWithValue("@nome", categoria.nome);

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

        public void Excluir(Categoria categoria)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Categoria WHERE idcategoria = @id", conexao);

                comando.Parameters.AddWithValue("@id", categoria.id);

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

                comando = new SqlCommand("SELECT * FROM Categoria ORDER BY nome", conexao);

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
