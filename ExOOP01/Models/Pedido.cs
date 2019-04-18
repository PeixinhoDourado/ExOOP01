using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP01.Models
{
    public class Pedido
    {
        public int codigo;
        public DateTime dataHora;
        public string observacoes;
        public double valor;
        public Cliente cliente;
        private double valorUnitario;
        private int quantidade;

        public void CalculaTotal()
        {
            valor = valorUnitario * quantidade;
        }

        public void AumentarQuantidade(int quantidade)
        {
            this.quantidade += quantidade;
            CalculaTotal();
        }

    }


}
