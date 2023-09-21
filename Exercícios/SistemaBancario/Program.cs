using Models;
class Program
{
    public static string[] conta = new string[0];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("--------------------");
        Console.WriteLine("Bem-Vindo ao SesiBank");
        Console.WriteLine("--------------------");
        Console.WriteLine("Aqui cuidamos e garatimos sua vida financeira!!!");
        SistemaBancario();
    }

    public static void SistemaBancario()
    {

        string opcao = "";

        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine();

        ContaCorrente conta = new ContaCorrente(titular, 0 );
        
        do
        {
            Console.WriteLine("#### M E N U ####");
            Console.WriteLine("1- Consultar saldo");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Sacar");
            Console.WriteLine("0- Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigada, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite um valor para depositar");
                    decimal valor1 = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valor1);
                    break;
                case "3":
                    Console.WriteLine("Digite um valor para sacar");
                    decimal valor2 = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valor2);
                    break;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            }

        } while (opcao != "0");

    }

}



