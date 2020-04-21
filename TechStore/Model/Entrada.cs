using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Model
{
    class Entrada
    {
        private int id;
        private string fornecador;
        private int idproduto;
        private string produto;
        private string descricao;
        private DateTime data;
        private int quantidade;
        private decimal preco;
        private decimal total;
        private string observacao;

        public int Id { get => id; set => id = value; }
        public string Fornecador { get => fornecador; set => fornecador = value; }
        public int Idproduto { get => idproduto; set => idproduto = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public decimal Total { get => total; set => total = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
