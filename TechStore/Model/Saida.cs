using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Model
{
    class Saida
    {
        private int id;
        private int idproduto;
        private string produto;
        private DateTime data;
        private int quantidade;

        public int Id { get => id; set => id = value; }
        public int Idproduto { get => idproduto; set => idproduto = value; }
        public string Produto { get => produto; set => produto = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
