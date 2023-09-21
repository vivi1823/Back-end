//Classe pai que será herdada - Superclasse
abstract class Animal
{
    public string cor {get; set;}
    public abstract void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algun som");
    }
}

//Classe filha que herdará da classe Animal(pai)
class Cachorro : Animal 
{
    //Sobrescrevendo o métedo EmitirSom
    public override void EmitirSom()
    {
    Console.WriteLine($"Cachorro da cor {cor} está latindo"); 
    }
}

class Gato : Animal 
{
    //Sobrescrevendo o métedo EmitirSom
    public override void EmitirSom()
    {
    Console.WriteLine($"Gato da cor {cor} está miando"); 
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando!");
    }
}

class Program
{
    public static void Main()
    {
      //Não é permitido criar um objeto de uma classe abstrata
      //Só conseguimos criar de sua classe derivada
      /*
      Animal animalGenerico = new Animal();
      animalGenerico.cor = "preto";
      animalGenerico.EmitirSom();
      */

      Cachorro meuCachorro = new Cachorro();
      meuCachorro.cor = "marrom";
      meuCachorro.EmitirSom();
      //meuCachorro.Ronronar(): // Não posso chamar este métedo pois não existe nessa classe
      
      Gato meuGato = new Gato();
      meuGato.cor = "branco";
      meuGato.EmitirSom();   
    
    }
}
