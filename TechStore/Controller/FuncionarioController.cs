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
    class FuncionarioController
    {
        private FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        public void Salvar(Funcionario funcionario)
        {
            try
            {
                funcionarioDAO.Salvar(funcionario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Editar(Funcionario funcionario)
        {
            try
            {
                funcionarioDAO.Editar(funcionario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            try
            {
                funcionarioDAO.Excluir(funcionario);
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

                dataTable = funcionarioDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object Pesquisar(Funcionario funcionario)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = funcionarioDAO.Pesquisar(funcionario);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
