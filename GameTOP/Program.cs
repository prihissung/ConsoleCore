using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("Ronaldo"));
            jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
        public readonly string _Nome;
        public Jogador(string nome)
        {
            _Nome = nome;
        }
        
        //chuta
        public void chuta()
        {
            Console.Write($"{_Nome} está chutando");
        }
        //corre
        public void corre()
        {
            Console.Write($"{_Nome} está correndo");
        }
        //passe
        public void passe()
        {
            Console.Write($"{_Nome} está passando");
        }

    }
}