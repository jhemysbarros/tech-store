using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.DAO;
using TechStore.Model;

namespace TechStore.Controller
{
    class FornecedorController
    {
        public Fornecedor CadastrarFornecedor(Fornecedor obj)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            if (obj.Id != 0)
            {
                return fornecedorDAO.update(obj);
            }
            return fornecedorDAO.insert(obj);
        }
    }
}
