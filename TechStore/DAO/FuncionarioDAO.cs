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
    class FuncionarioDAO : Conexao2
    {
        SqlCommand comando = null;
        public void Salvar(Funcionario funcionario)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("INSERT INTO Funcionario(nome, cpf, endereco,numero,cep, complemento, bairro, telefone, email, cidade, estado, senha, cargo) values (@nome, @cpf, @endereco, @numero, @cep, @complemento, @bairro, @telefone, @email, @cidade, @estado, @senha, @cargo)", conexao);

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                comando.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@senha", funcionario.Senha);
                comando.Parameters.AddWithValue("@cargo", funcionario.Cargo);

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

        public void Editar(Funcionario funcionario)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("UPDATE Funcionario set nome = @nome, cpf = @cpf, endereco = @endereco, numero = @numero, cep = @cep, complemento = @complemento, bairro = @bairro, telefone = @telefone, email = @email, cidade = @cidade, estado = @estado, senha = @senha, cargo = @cargo WHERE idfuncionario = @id", conexao);

                comando.Parameters.AddWithValue("@id", funcionario.Id);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                comando.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@senha", funcionario.Senha);
                comando.Parameters.AddWithValue("@cargo", funcionario.Cargo);

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

        public void Excluir(Funcionario funcionario)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Funcionario WHERE idfuncionario = @id", conexao);

                comando.Parameters.AddWithValue("@id", funcionario.Id);

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

                comando = new SqlCommand("SELECT * FROM Funcionario ORDER BY nome", conexao);

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
