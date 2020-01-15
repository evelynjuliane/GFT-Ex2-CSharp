using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Fiat", "Uno", "EEE-222", "Preto", 5, "2014", 250000, true, 100, 0, 250000);
            
            carro.Imprime();

          Aviao aviao = new Aviao("BBB", "GGG-22","AZUL", 30000000,false, 20,100 ,100000000,"Comercial", "privado");

           aviao.Imprime();

        }
    }
}
