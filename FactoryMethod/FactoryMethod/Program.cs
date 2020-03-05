using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();
            Console.WriteLine("LiuKang | SubZero | Scorpion \n");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine("Escolhido: ");
            personagem.Escolhido();
            Console.ReadKey();

        }
    }
}
