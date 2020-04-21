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
    class SaidaController
    {
        private SaidaDAO saidaDAO = new SaidaDAO();

        public void Salvar(Saida saida)
        {
            try
            {
                saidaDAO.Salvar(saida);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Editar(Saida saida)
        {
            try
            {
                saidaDAO.Editar(saida);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Excluir(Saida saida)
        {
            try
            {
                saidaDAO.Excluir(saida);
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

                dataTable = saidaDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object Pesquisar(Saida saida)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = saidaDAO.Pesquisar(saida);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
