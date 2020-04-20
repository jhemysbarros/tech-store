using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.DAO;
using TechStore.Model;

namespace TechStore.Controller
{
    class FornecedorController
    {
        FornecedorDAO fornecedorDAO = new FornecedorDAO();
        public void Salvar(Fornecedor fornecedor)
        {
            try
            {
                fornecedorDAO.Salvar(fornecedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Editar(Fornecedor fornecedor)
        {
            try
            {
                fornecedorDAO.Editar(fornecedor);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Excluir(Fornecedor fornecedor)
        {
            try
            {
                fornecedorDAO.Excluir(fornecedor);
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

                dataTable = fornecedorDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object Pesquisar(Fornecedor fornecedor)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = fornecedorDAO.Pesquisar(fornecedor);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
