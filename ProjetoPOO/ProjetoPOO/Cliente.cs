using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    public class Cliente
    {
        public string? nomeCliente;
        private long ncpf;
        private string enederecoCliente;
        public bool temCartaoLoja = false;

        public Cliente(string nome, long cpf, string endereco)
        {
            this.nomeCliente = nome;
            this.ncpf = cpf;
            this.enederecoCliente = endereco;
        }

        public void TemCartao()
        {
            temCartaoLoja = true;
        }
    }
}
