using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            //SemSingleton jogador_2 = new SemSingleton();

            Singleton jogador_2 = Singleton.GetInstancia;
            //SemSingleton jogador_3 = new SemSingleton();

            Singleton jogador_3 = Singleton.GetInstancia;
            //SemSingleton jogador_3 = new SemSingleton();


            jogador_1.Mensagem("jogador 1: a bola está comigo");
            jogador_2.Mensagem("jogador 2: recebeu a bola");
            jogador_3.Mensagem("jogador 3: recebeu o lançamento na linha de campo");

            Console.ReadKey();
        }
    }
}
