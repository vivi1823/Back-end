//Exercício Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar em uma variável do tipo string
Console.WriteLine("Informe o nome do Aluno:");
string nome = Console.ReadLine();


//Receber a nota 1, converter e armazenar em uma variável int
Console.WriteLine("Digite o valor da nota 1 ");
int nota1 = int.Parse(Console.ReadLine());

//Receber a nota 2, converter e armarzenar em uma variável int
Console.WriteLine("Digite o valor da nota 2");
int nota2 = int.Parse(Console.ReadLine());

//Receber a nota 3, converter e armarzenar em uma variável int
Console.WriteLine("Digite o valor da nota 3 ");
int nota3 = int.Parse(Console.ReadLine());

//Declarar uma variável do tipo int, para receber a média das notas
// (nota1 + nota2 + nota3) / 3
int media = (nota1 +  nota2 + nota3) / 3;

//Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7
if (media >= 7)
{
    Console.WriteLine($"{nome} você está aprovado com média {media}");
} else {
    Console.WriteLine($"{nome} você está reprovado com média {media}");
}

