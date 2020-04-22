using System;
using TechStore.DAO;
using TechStore.Model;
using System.Data;

namespace TechStore.Controller
{
    class ProdutoController
    {
        ProdutoDAO produtoDAO  = new ProdutoDAO();
        public void Salvar(Produto produto)
        {
            try
            {
                produtoDAO.Salvar(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Editar(Produto produto)
        {
            try
            {
                produtoDAO.Editar(produto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Excluir(Produto produto)
        {
            try
            {
                produtoDAO.Excluir(produto);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public DataTable Listar()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = produtoDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object Pesquisar(Produto produto)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = produtoDAO.Pesquisar(produto);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
