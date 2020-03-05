using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cria o fabricante
            Fabricante fabricante = new Fabricante();

            //permite que a classe builder esteja pronta
            ICelular celularbuilder = null;

            //Agora vamos criar um telefone android
            celularbuilder = new IphoneBuilder();
            fabricante.Construtor(celularbuilder);

            //Console.WriteLine("um novo celular foi construido: \n\n{0}", celularbuilder.Celular.Nome);
            Console.WriteLine("Fabricado o celular: " + celularbuilder.Celular.Nome);
            Console.ReadKey();
        }
    }
}
