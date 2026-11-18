

namespace POO2;

class Program
{
    static void Main()
    {
        Felinos Gato = new Felinos();
        Caninos cao = new Caninos();
        Console.WriteLine($"{Gato.especie} = {Gato.vida}HP");
        Gato.ataque();
        Console.WriteLine($"{cao.especie} = {cao.vida}HP");
        cao.ataque();
        
        
    }

}
class Animais
{
    public int vida = 100;
    public string especie;
    public string arma;
    
    public void ataque()
    {
        Console.WriteLine($"{this.especie} atacou com {this.arma}!");
    }


}
class Felinos : Animais
{
    public Felinos()
    {
        this.especie = "Gato";
        this.arma = "Patas";
    }
}
class Caninos : Felinos
{
    public Caninos()
    {
        this.especie = "Cão";
        this.arma = "Mordida";
    }
}