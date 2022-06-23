using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Gerente : Pessoa
    {

        public Loja? loja;
        double salarioFinal;

        public void Ferias(Funcionario funcionario)
        {

            funcionario = new Funcionario();

            if (funcionario.EstaDeFerias == false)
            {

                funcionario.EstaDeFerias = true;
                Console.WriteLine("Funcionário está de férias!");

            }
            else
            {

                funcionario.EstaDeFerias = false;
                Console.WriteLine("Funcionário voltou da férias!");
            }

        }

        public void AlteraSalario(double salario)
        {

            salarioFinal = Salario;

            Console.Write("Digite a porcentagem de aumento: ");
            double aumento = double.Parse(Console.ReadLine());

            salario += ((salario * aumento) / 100);
            Salario = salario;
            Console.WriteLine("Novo salario: " + salario);
            salarioFinal = salario;

        }

        void CalculaSalario()
        {

            Console.WriteLine("O salário é: " + salarioFinal);

        }

    }
}
