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
    class EstoqueController
    {
        private EstoqueDAO estoqueDAO = new EstoqueDAO();

        public DataTable Listar()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = estoqueDAO.Listar();

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

                dataTable = estoqueDAO.Pesquisar(entrada);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
