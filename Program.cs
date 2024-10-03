using System;
using System.Reflection.PortableExecutable;

class Heroi{
    public string nome = "Hugh Martelo";
    public int idade = 32;
    string tipo = "guerreiro";

    public void atacar(){

        string ataque = "";

        if(tipo == "mago"){
            ataque = "usando magia";
        }
        else if(tipo == "guerreiro"){
            ataque = "usando espada";
        }
        else if(tipo == "monge"){
            ataque = "usando artes marciais";
        }
        else if(tipo == "ninja"){
            ataque = "usando shuriken";
        }

        Console.WriteLine($"O {tipo} atacou {ataque}");
    }
}
class Program {
    public static void Main(string[] args){
        Heroi heroi = new Heroi();
        
        Console.WriteLine($"O Heroi {heroi.nome} de {heroi.idade} anos está prestes a realizar um ataque!!");
        heroi.atacar();
    }
}