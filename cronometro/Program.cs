using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("S = Segundo => 10 segundos\nM = Minuto => 1 minuto\n0 = Sair\nQuanto tempo?");

            string data = Console.ReadLine();
            int parametro = 10;

            if (char.Parse(data.Substring(0, 1))=='0') System.Environment.Exit(0);
            if (char.Parse(data.Substring(0, 1).ToLower())=='m') parametro = 60;

            Console.WriteLine("Conômetro começando...");
            Thread.Sleep(1000);
            
            Contador(parametro);
            
        }

        static private void Contador(int numero)
        {
            int contador = 0;

            while (contador <= numero)
            {
                Console.WriteLine(contador);
                Thread.Sleep(1000);
                contador++;
            }

            Console.WriteLine("Cronômetro finalizado");
            
        }
    }
}
