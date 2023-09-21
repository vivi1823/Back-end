using Sesi.Model;

class Program
{
    public static void Main()
    {
    //Criando uma variável aluno1 e instanciando da classe aluno
    //Criando nosso objeto
      var aluno1 = new Aluno();
      aluno1.nome = "Vitória";
      aluno1.idade = 17;
      aluno1.turma = "2º médio";

    //Chamando o métedo de classe Aluno
    aluno1.Apresentar();

    var aluno2 = new Aluno();
    aluno2.nome = "Clara";
    aluno2.idade = 17;
    aluno2.turma = "2º médio";

    aluno2.Apresentar();
    aluno2.AdicionarFaltas(10);
    aluno2.Apresentar();

    //Chamar novo métedo ResumoFaltas
    aluno2.ResumoFaltas();
    
    }
}