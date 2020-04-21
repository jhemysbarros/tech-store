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
    class EntradaController
    {
        private EntradaDAO entradaDAO = new EntradaDAO();

        public void Salvar(Entrada entrada)
        {
            try
            {
                entradaDAO.Salvar(entrada);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Editar(Entrada entrada)
        {
            try
            {
                entradaDAO.Editar(entrada);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Excluir(Entrada entrada)
        {
            try
            {
                entradaDAO.Excluir(entrada);
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

                dataTable = entradaDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object Pesquisar(Entrada entrada)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = entradaDAO.Pesquisar(entrada);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
