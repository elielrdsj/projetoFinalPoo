using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    class CriacaoObjetos
    {
        static void Main(string[] args)
        {
            //Criando clientes

            Cliente michael = new Cliente("Michael Tadeu",88745961245,"Rua Hipotético Almeida, 155");
            michael.temCartaoLoja = true;
            Cliente amanda = new Cliente("Amanda Mantovani", 4457986213, "Rua Juiz Antonio Medeiros, 759");

            //Criando Loja

            Loja loja1 = new Loja();
            loja1.email = "loja1@mercado.com";
            loja1.numeroDaloja = 001;
            loja1.numeroTelefone = "1133245689";


            //Criando Funcionarios

            Gerente eliel = new Gerente();
            eliel.Nome = "Eliel";
            eliel.DataContratacao = new DateOnly(2021, 06, 24);
            eliel.Setor = "Administração";
            eliel.loja = loja1;
            eliel.Salario = 10000;
            Pessoa fabio = new Funcionario();
            fabio.Nome = "Fabio";
            fabio.DataContratacao = new DateOnly(2022, 10, 22);
            fabio.Setor = "Açogue";
            fabio.loja = loja1;
            fabio.Salario = 8000;

            //Criando produtos

            Produto produto1 = new Produto();
            produto1.descricao = "Coca-Lata";
            produto1.codigoBarras = 15546789;
            produto1.loja = loja1;
            produto1.preco = 3.50;
            produto1.unidadeDeMedida = "unidades";
            produto1.estoque = 57;

            Produto produto2 = new Produto();
            produto2.descricao = "Tomate";
            produto2.codigoBarras = 4567;
            produto2.loja = loja1;
            produto2.preco = 6;
            produto2.unidadeDeMedida = "kg";
            produto2.estoque = 200;

            Produto produto3 = new Produto();
            produto3.descricao = "Picanha Bovinha";
            produto3.codigoBarras = 2222;
            produto3.loja = loja1;
            produto3.preco = 96.56;
            produto3.unidadeDeMedida = "kg";
            produto3.estoque = 120.5;

            // Criando Recibos

            //Recibo recibo1 = new Recibo();
            //recibo1.cliente = michael;
            //recibo1.loja = loja1;
            //recibo1.metodoPagamento = 2;
            //recibo1.AdicionaItem(produto3,20);
            //recibo1.AdicionaItem(produto1, 10);
            //recibo1.ImprimeResultado();

            ////Imprimindo dados Funcionarios


            //eliel.ImprimeDados();
            //Console.WriteLine("Alterando Salário....");
            //eliel.AlteraSalario(eliel.Salario);
            //eliel.ImprimeDados();

            //Console.WriteLine();
            //fabio.ImprimeDados();



            // Classe Produto


            ////Alterando quantidade em estoque

            //produto1.ImprimeDados();
            //Console.WriteLine("\nVamos atualizar o estoque...");
            //Console.ReadKey();

            //Console.Write("Digite a quantidade de produto inserido: ");

            //produto1.AlteraQuant(double.Parse(Console.ReadLine()));
            //Console.Clear();
            //produto1.ImprimeDados();
            //Console.ReadKey();

            ////Alterando preço de produtos

            //produto2.ImprimeDados();
            //Console.WriteLine("\nVamos alterar o preço...");
            //Console.ReadKey();

            //Console.Write("Digite o novo preço do produto: ");
            //produto2.AlteraPreco(double.Parse(Console.ReadLine()));
            //Console.Clear();
            //produto2.ImprimeDados();
            //Console.ReadKey();

        }
    }
}
