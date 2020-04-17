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
    class FornecedorDAO
    {
        public Fornecedor insert(Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Fornecedor(nome, cnpj, endereco, numero, cep, complemento, bairro, telefone, cidade, estado, insc_estadual, insc_municipal, email) values (@nome, @cnpj, @endereco, @numero, @cep, @complemento, @bairro, @telefone, @cidade, @estado, @insc_estadual, @insc_municipal, @email)";
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            cmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
            cmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
            cmd.Parameters.AddWithValue("@estado", fornecedor.Estado);
            cmd.Parameters.AddWithValue("@insc_estadual", fornecedor.InscEstadual);
            cmd.Parameters.AddWithValue("@insc_municipal", fornecedor.InscMunicipal);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);

            if (Conexao.CRUD(cmd))
                return fornecedor;
            return null;
        }

        public Fornecedor update(Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Fornecedor set nome = @nome, cnpj = @cnpj, endereco = @endereco, numero = @numero, cep = @cep, complemento = @complemento, bairro = @bairro, telefone = @telefone, cidade = @cidade, estado = @estado, insc_estadual = @insc_estadual, insc_municipal = @insc_municipal, email = @email";
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            cmd.Parameters.AddWithValue("@numero", fornecedor.Numero);
            cmd.Parameters.AddWithValue("@cep", fornecedor.Cep);
            cmd.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
            cmd.Parameters.AddWithValue("@estado", fornecedor.Estado);
            cmd.Parameters.AddWithValue("@insc_estadual", fornecedor.InscEstadual);
            cmd.Parameters.AddWithValue("@insc_municipal", fornecedor.InscMunicipal);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);
            if (Conexao.CRUD(cmd))
                return fornecedor;
            return null;
        }

        public static DataTable returnDataSource()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Fornecedor";
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
