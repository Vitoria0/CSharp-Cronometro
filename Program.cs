using System;
using System.Threading;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cronômetro");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Iniciar");
            Console.WriteLine("2 - Sair");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Start();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        public static void Start()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Pressione Enter para iniciar o cronômetro...");
            Console.ReadLine();
            stopwatch.Start();

            while (!Console.KeyAvailable)
            {
                TimeSpan elapsed = stopwatch.Elapsed;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"Tempo decorrido: {elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}.{elapsed.Milliseconds:D3}");
                Thread.Sleep(100);
            }

            Console.ReadKey();
            stopwatch.Stop();

            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para retornar ao menu...");
            Console.ReadKey();
            Menu();
        }
    }
}
