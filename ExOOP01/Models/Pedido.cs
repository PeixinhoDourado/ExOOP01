﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP01.Models
{
    public class Pedido
    {
        private int codigo;
        private DateTime dataHora;
        private string observacoes;
        private double valor;
        private Cliente cliente;
        private double valorUnitario;
        private int quantidade;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

        public string Observacoes { get => observacoes; set => observacoes = value; }
        public double Valor { get => valor; set => valor = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }


        public Pedido(int codigo, DateTime dataHora, string observacoes, double valor, Cliente cliente, double valorUnitario, int quantidade )
        {
            this.codigo = codigo;
            this.dataHora = dataHora;
            this.observacoes = observacoes;
            this.cliente = cliente;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            CalculaTotal();
        }

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
