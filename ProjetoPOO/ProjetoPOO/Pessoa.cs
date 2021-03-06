using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Pessoa
    {

        //---------------------------Nome

        string? nome;

        public string Nome
        {
            get { return nome; }

            set { nome = value; }
        }

        //---------------------------Setor

        string? setor;

        public string Setor
        {
            get { return setor; }

            set { setor = value; }
        }

        //---------------------------Salário

        double salario;

        public double Salario
        {
            get { return salario; }

            set { salario = value; }
        }

        //---------------------------Data de contratação

        DateOnly dataContratacao;

        public DateOnly DataContratacao
        {
            get { return dataContratacao; }

            set { dataContratacao = value; }
        }

        public Loja? loja;

        public virtual void ImprimeDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Salario: R$" + Salario);
            Console.WriteLine("Data de Contratação: " + DataContratacao);

        }

    }
}
