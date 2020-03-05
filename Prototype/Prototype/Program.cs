using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente func_permanente = new FuncionarioPermanente();
            func_permanente.Nome = "João";
            func_permanente.Idade = 30;
            func_permanente.Tipo = "Permanente";

            FuncionarioPermanente clone_func_permanente = (FuncionarioPermanente)func_permanente.clone();
            clone_func_permanente.Nome = "Carlos";
            clone_func_permanente.Idade = 40;

            Console.WriteLine("Detalhe do funcionario permanente: ");
            Console.WriteLine("{0}, {1}, {2}", func_permanente.Nome, func_permanente.Idade, func_permanente.Tipo);

            Console.WriteLine("Detalhe do funcionario permanente CLONADO: ");
            Console.WriteLine("{0}, {1}, {2}", clone_func_permanente.Nome, clone_func_permanente.Idade, clone_func_permanente.Tipo);

            Console.ReadKey();

        }
    }
}
