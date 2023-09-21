    //O nome space é um nome em que usaremos para fazer referêncsias quando usarmos
    namespace Sesi.Model
    {
    //Declarando a classe Aluno
        public class Aluno
        {
    //Declarando os atributos (propriedades) da classe Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

    //Declarando um atributo privado
        private int nrFaltas { get; set; }

    //Criando um métedo
    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {nome}, eu tenho {idade} anos e estudo na turma do {turma}, e tenho {nrFaltas} faltas");
    }

    public void AdicionarFaltas(int nr)
    {
        Console.WriteLine($"A aluna {nome} faltou hoje e somou {nr} faltas");
        nrFaltas = nrFaltas + nr;
    }

    //Métedo ResumoFaltas
      public void ResumoFaltas()
    {
        Console.WriteLine($"Resumo de faltas = {nrFaltas} faltas");
    }


        }
    }