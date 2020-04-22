using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Model
{
    class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private decimal preco;
        private byte[] imagem;
        private int idcategoria;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public byte[] Imagem { get => imagem; set => imagem = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
    }
}
