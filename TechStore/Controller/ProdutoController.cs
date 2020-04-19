using System;
using TechStore.DAO;
using TechStore.Model;
using System.Data;

namespace TechStore.Controller
{
    class ProdutoController
    {
        ProdutoController produtoController = new ProdutoController();
        public void Salvar(Produto produto)
        {
            try
            {
                produtoController.Salvar(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
