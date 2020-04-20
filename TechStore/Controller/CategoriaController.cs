using System;
using TechStore.DAO;
using TechStore.Model;
using System.Data;

namespace TechStore.Controller
{
    class CategoriaController
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public void Salvar(Categoria categoria)
        {
            try
            {
                categoriaDAO.Salvar(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Editar(Categoria categoria)
        {
            try
            {
                categoriaDAO.Editar(categoria);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Excluir(Categoria categoria)
        {
            try
            {
                categoriaDAO.Excluir(categoria);
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

                dataTable = categoriaDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object Pesquisar(Categoria categoria)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = categoriaDAO.Pesquisar(categoria);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
