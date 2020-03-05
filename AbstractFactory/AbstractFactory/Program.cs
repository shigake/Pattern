using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.montaCarro("luxo");
            Carro c2 = ExecutaAbstractFactory.montaCarro("popular");

            Console.ReadLine();
        }
    }
}
