using System;
using System.Collections.Generic;
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
        private int idcategoria;
        private Categoria categoria;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        internal Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
