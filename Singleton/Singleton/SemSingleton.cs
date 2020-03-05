using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SemSingleton
    {
        public SemSingleton()
        {
            Console.WriteLine("bola em jogo");
        }

        public void Mensagem(string msg) {
            Console.WriteLine(msg);
        }
    }
}
