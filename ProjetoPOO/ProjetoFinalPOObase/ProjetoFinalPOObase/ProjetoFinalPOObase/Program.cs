namespace ProjetoFinalPOObase
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //================================ GERENTE ================================

            Gerente gerente1 = new Gerente();
            gerente1.loja = new Loja();

            gerente1.Nome = "Marcelo";
            gerente1.Setor = "Financeiro";
            gerente1.Salario = 7500;
            gerente1.DataContratacao = new DateOnly(1992, 01, 20);

            //Teste de erros de Null Exception

            gerente1.loja.numeroDaloja = 1;
            gerente1.loja.numeroTelefone = "11 1234-5678";
            gerente1.loja.email = "loja@teste.com";
            gerente1.loja.endereco = "Av teste, 123";

            Console.WriteLine("=============== Teste Gerente ===============\n");

            Console.WriteLine("Nome Gerente: " + gerente1.Nome);
            Console.WriteLine("Setor: " + gerente1.Setor);
            Console.WriteLine("Salário gerente: " + gerente1.Salario);

            Console.WriteLine("\n");
            gerente1.AlteraSalario(7500);
            Console.WriteLine("\n");

            Console.WriteLine("Data de contratação: " + gerente1.DataContratacao + "\n");

            //Teste de erros de Null Exception

            Console.WriteLine(gerente1.loja.numeroDaloja);
            Console.WriteLine(gerente1.loja.numeroTelefone);
            Console.WriteLine(gerente1.loja.email);
            Console.WriteLine(gerente1.loja.endereco + "\n");

            //============================== FUNCIONÁRIO ==============================

            Funcionario func1 = new Funcionario();
            func1.gerente = new Gerente();

            func1.Nome = "João";
            func1.Setor = "Limpeza";
            func1.Salario = 2000;
            func1.DataContratacao = new DateOnly(1998, 01, 20);
            func1.funcao = "Limpeza da cozinha";

            func1.gerente.Nome = gerente1.Nome;

            func1.EstaDeFerias = false;

            Console.WriteLine("============= Teste Funcionário =============\n");

            Console.WriteLine("Nome funcionário: " + func1.Nome);
            Console.WriteLine("Setor: " + func1.Setor);
            Console.WriteLine("Salário funcionário: " + func1.Salario);

            Console.WriteLine("\n");
            func1.gerente.AlteraSalario(2000);
            Console.WriteLine("\n");

            Console.WriteLine("Data de contratação: " + func1.DataContratacao);
            Console.WriteLine("Função: " + func1.funcao);
            Console.WriteLine(func1.gerente.Nome);
            Console.WriteLine("Férias: " + func1.EstaDeFerias);

            Console.WriteLine("\n");
            gerente1.Ferias(func1);
            Console.WriteLine("\n");

            //================================ PESSOA =================================

            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Roberto";
            pessoa.Setor = "---";
            pessoa.Salario = 0;
            //pessoa.DataContratacao = new DateOnly(0000, 00, 00);

            Console.WriteLine("================ Teste Pessoa ===============\n");

            Console.WriteLine("Nome Pessoa: " + pessoa.Nome);
            Console.WriteLine("Setor: " + pessoa.Setor);
            Console.WriteLine("Salário gerente: " + pessoa.Salario);
            Console.WriteLine("Data de contratação: " + pessoa.DataContratacao + "\n");

            //================================= LOJA ==================================

            Loja loja = new Loja();

            loja.numeroDaloja = 1;
            loja.numeroTelefone = "11 1234-5678";
            loja.email = "loja@teste.com";
            loja.endereco = "Av. teste, 123";

            Console.WriteLine("================= Teste Loja ================\n");

            Console.WriteLine("Número da loja: " + loja.numeroDaloja);
            Console.WriteLine("telefone: " + loja.numeroTelefone);
            Console.WriteLine("email: " + loja.email);
            Console.WriteLine("endereço: " + loja.endereco + "\n");

            //==========================================================================

        }
    }

}