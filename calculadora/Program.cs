using System;

namespace Calculatora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a operação:\n1 = Soma\n2 = Subtração\n3 = Divisão\n4 = Multiplicação\n5 = Sair");
           
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;                
            }
        }

        static void Soma()
        {
            
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"Soma: {resultado}");
            Console.ReadKey();
            
        }

        static void Subtracao()
        {
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"Subtração: {resultado}");
            Console.ReadKey();
            
        }

        static void Divisao()
        {
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"Divisão é {resultado}");
            Console.ReadKey();
            
        }

        static void Multiplicacao()
        {
           
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine("Multiplicação é " + (v1 * v2));
            Console.ReadKey();
            
        }
    }
}
