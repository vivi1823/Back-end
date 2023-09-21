    namespace Models
    {
       public class Pessoa
       {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }

       //Criando nosso Método Construtor
        public Pessoa (string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        //Métodos da Classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Dançar()
        {
            Console.WriteLine($"{nome} está dançando");
        }

        public void Teatro()
        {
            Console.WriteLine($"{nome} faz teatro");
        }
       } 
    }