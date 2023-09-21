    using Models; 

    public class Program 
    {
        public static void Main()
        {
          //Criar um objeto da classe Pessoa 
          /*
          //Instanciando objeto sem método construtor
          Pessoa pessoa1 = new Pessoa
          pessoa1.nome = "Vitória";
          pessoa1.idade = 17;

          //Alternativa de um objeto instanciado sem construtor
          Pessoa pessoa1 = new Pessoa {
            nome = "Ana Clara",
            idade = 17
          }
          */
 
          //Instanciando um objeto com método construtor
          Pessoa pessoa1 = new Pessoa("Vitória", 17);

          //Chamando o método Cantar da classe Pessoa
          pessoa1.Cantar();

          Pessoa pessoa2 = new Pessoa("Clara", 17);
          pessoa2.Dançar();

          Pessoa pessoa3 = new Pessoa("Ayla", 16);
          pessoa3.Teatro();
        }
    }
