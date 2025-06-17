using System;
using System.IO;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opção:");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: System.Environment.Exit(0); break;
            }
        }

        static private void Open()
        {
            
            Console.WriteLine("Caminho do arquivo:");
            string caminho = Console.ReadLine();

            try
            {
                using (var file = new StreamReader(caminho))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }

        static private void Edit()
        {
            
            Console.WriteLine("Digite um texto e pressione ESC para sair");
            Console.WriteLine("");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);

        }

        static private void Save(string text)
        {

            Console.WriteLine("");
            Console.WriteLine("Caminho para salvar o arquivo:");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo");
       
        }
    }
}
