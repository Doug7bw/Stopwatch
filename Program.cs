using System;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("s = Segundo => 10s = 10 segundos");
            Console.WriteLine("m = Minuto => 1m = 1 minuto (60 segundos)");
            Console.WriteLine("0 = Finalizar aplicação\n");

            Console.Write("Quanto tempo deseja contar (Ex: 20s): ");
            string timeChoose = Console.ReadLine().ToLower().Trim();
            int time = 0;

            if (timeChoose != "0")
            {
                time = int.Parse(timeChoose.Substring(0, timeChoose.Length - 1));
                char typeChoose = timeChoose[timeChoose.Length - 1];

                if (typeChoose == 'm')
                {
                    time *= 60;
                }
            }
            else
            {
                Console.WriteLine("\nFinalizando a aplicação.");
                System.Environment.Exit(0);
            }

            Start(time);
        }

        static void Start(int time)
        {
            for (int currentTime = 1; currentTime <= time; currentTime++)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Console.WriteLine("Acabou o tempo.\n");
            Environment.Exit(0);
        }
    }
}