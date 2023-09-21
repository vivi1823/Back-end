//Escreva um programa que receba uma placa e informe qual é o dia de rodízio no transito 
//de SP (considerando final 1 e 2 na segunda, 
// 3 e 4 na terça,
// 5 e 6 na quarta,
// 7 e 8 na quinta,
// 9 e 0 na sexta)
// EX: ABC1B34 ter apenas o ultimo caracter no caso 4



Console.WriteLine("Digite sua placa:");
string placa = Console.ReadLine();

string final = placa.Substring(placa.Length - 1, 1)

Console.WriteLine(final);

if (final == "1" || final == "2") {
    Console.WriteLine("Você não pode sair em SP na segunda-feira");
} else if (final == "3" || final == "4") {
    Console.WriteLine("Você não pode sair em SP na terça-feira");
} else if (final == "5" || final == "6") {
    Console.WriteLine("Você não pode sair em SP na quarta-feira");
} else if (final == "7" || final == "8") {
    Console.WriteLine("Você não pode sair em SP na quinta-feira");
} else if (final == "9" || final == "0") {
    Console.WriteLine("Você não pode sair em SP na sexta-feira");
}








