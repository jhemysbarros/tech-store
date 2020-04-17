using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.Model;

namespace TechStore.DAO
{
    class FornecedorDAO : Conexao
    {
        SqlCommand comando = null;
        public void Salvar(Fornecedor fornecedor)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("INSERT INTO Fornecedor(nome, cnpj, endereco, numero, cep, complemento, bairro, telefone, cidade, estado, insc_estadual, insc_municipal, email) values(@nome, @cnpj, @endereco, @numero, @cep, @complemento, @bairro, @telefone, @cidade, @estado, @insc_estadual, @insc_municipal, @email)", conexao);

                comando.Parameters.AddWithValue("@nome", fornecedor.Nome);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                comando.Parameters.AddWithValue("@numero", fornecedor.Numero);
                comando.Parameters.AddWithValue("@cep", fornecedor.Cep);
                comando.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                comando.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                comando.Parameters.AddWithValue("@estado", fornecedor.Estado);
                comando.Parameters.AddWithValue("@insc_estadual", fornecedor.InscEstadual);
                comando.Parameters.AddWithValue("@insc_municipal", fornecedor.InscMunicipal);
                comando.Parameters.AddWithValue("@email", fornecedor.Email);

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

        public void Editar(Fornecedor fornecedor)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("UPDATE Fornecedor set nome = @nome, cnpj = @cnpj, endereco = @endereco, numero = @numero, cep = @cep, complemento = @complemento, bairro = @bairro, telefone = @telefone, cidade = @cidade, estado = @estado, insc_estadual = @insc_estadual, insc_municipal = @insc_municipal, email = @email WHERE idfornecedor = @id", conexao);

                comando.Parameters.AddWithValue("@id", fornecedor.Id);
                comando.Parameters.AddWithValue("@nome", fornecedor.Nome);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                comando.Parameters.AddWithValue("@numero", fornecedor.Numero);
                comando.Parameters.AddWithValue("@cep", fornecedor.Cep);
                comando.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                comando.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                comando.Parameters.AddWithValue("@estado", fornecedor.Estado);
                comando.Parameters.AddWithValue("@insc_estadual", fornecedor.InscEstadual);
                comando.Parameters.AddWithValue("@insc_municipal", fornecedor.InscMunicipal);
                comando.Parameters.AddWithValue("@email", fornecedor.Email);

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

        public void Excluir(Fornecedor fornecedor)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Fornecedor WHERE idfornecedor = @id", conexao);

                comando.Parameters.AddWithValue("@id", fornecedor.Id);

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

                comando = new SqlCommand("SELECT * FROM Fornecedor ORDER BY nome", conexao);

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
