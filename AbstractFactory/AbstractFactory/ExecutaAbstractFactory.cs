using System;

namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montaCarro(string tipo) {
            CarroFactory cf = null;
            switch (tipo) {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "popular":
                    cf = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            carro.Roda = cf.montarRoda();
            carro.Som = cf.montarSom();
            return carro;
        }

    }
}
