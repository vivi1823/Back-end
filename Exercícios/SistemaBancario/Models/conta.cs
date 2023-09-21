
namespace Models
{

    public class ContaCorrente
    {
        //Atributos da nossa classe Pessoa
        private string titular { get; set; }
        private decimal saldo { get; set; }

        //Criando nosso Método Construtor
        public ContaCorrente(string nome, decimal saldo)
        {
            this.titular = nome;
            this.saldo = saldo;
        }

        //Métodos da Classe Pessoa
        public void ConsultarSaldo()
        {
            Console.WriteLine($"{titular} seu saldo é de {saldo}");
        }

        public void Depositar(decimal valor)
        {
            saldo = saldo + valor;
            Console.WriteLine($"{titular} você depositou o valor de {valor} ");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > saldo)
            {
                Console.WriteLine("O valor do saque não pode ser negativo");
            }
            else
            {
                saldo = saldo - valor;
                Console.WriteLine($"Seu saldo é de {saldo} :");
                Console.WriteLine($"{titular} você sacou o valor de {valor} :");
            }
            
        }
    }
}



