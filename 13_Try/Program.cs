﻿public class Program
{
    
    public static void Main()
    {
    //O try serve para tratar um erro e não parar a execução do programa
    //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
    //a execução do bloco e vai para o catch
        try{
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
        }
        catch(OverflowException)
        {
            Console.WriteLine("O número digitado é maior que o limite aceito");
        }
        //Tratando exceção de erro especifica
        catch(FormatException)
        {
            Console.WriteLine("Digite um número inteiro");
        }
    //catch é o tratamento do erro, normalmente colocamos as mensagens de acordo     
    //com o tipo do erro, para melhorcompreensão do usuário
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro generico: {erro.Message}");
        }
        finally {
            Console.WriteLine($"No bloco finally o programa entra independentemente de execução");
        }
    }
}
