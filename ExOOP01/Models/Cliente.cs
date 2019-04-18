using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP01.Models
{
    public class Cliente
    {
        private int codigo;
        private string nome;
        private string email;
        private string cidade;
        private string uf;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }

        public Cliente(int codigo, string nome, string email, string cidade, string uf)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.email = email;
            this.cidade = cidade;
            this.uf = uf;
        }
    }
}
