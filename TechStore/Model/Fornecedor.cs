using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Model
{
    class Fornecedor
    {
        private int id;
        private String nome;
        private String cnpj;
        private String endereco;
        private int numero;
        private String cep;
        private String complemento;
        private String bairro;
        private String telefone;
        private String cidade;
        private String estado;
        private String inscEstadual;
        private String inscMunicipal;
        private String email;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string InscEstadual { get => inscEstadual; set => inscEstadual = value; }
        public string InscMunicipal { get => inscMunicipal; set => inscMunicipal = value; }
        public string Email { get => email; set => email = value; }
    }
}
