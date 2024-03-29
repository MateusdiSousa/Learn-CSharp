﻿namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Stopwatch!");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Seconds");
            Console.WriteLine("2 - Minutes");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Select the option: ");

            int opcao;

            try
            {
                opcao = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Menu();
                throw;
            }


            switch (opcao)
            {
                case 0:
                    Console.WriteLine("System finished!");
                    break;
                case 1:
                    CountSeconds();
                    break;
                case 2:
                    CountMInutes();
                    break;
                default:
                    Console.WriteLine("Command not recognized");
                    Thread.Sleep(3000);
                    Menu();
                    break;
            }
        }
        static void CountSeconds()
        {
            Console.WriteLine("How long seconds do you wanna to count? ");
            int timeCount;
            try
            {
                timeCount = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("You must type a valid number");
                Thread.Sleep(5);
                CountSeconds();
                throw;
            }
            PreStart();
            Start(timeCount);
        }
        static void CountMInutes()
        {
            Console.WriteLine("How long Minutes do you wanna to count? ");
            int timeCount;
            try
            {
                timeCount = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("You must type a valid number");
                Thread.Sleep(5);
                CountMInutes();
                throw;
            }
            PreStart();
            Start(timeCount*60);
        }
        static void PreStart()
        {
            Console.Write("Ready");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Write("Set");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Write("Start");
            Console.WriteLine("...");
            Thread.Sleep(1000);
        }
        static void Start(int tim)


        {
            int time = tim;
            int currentTIme = 0;
            while (time != currentTIme)
            {
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                currentTIme++;
                Console.Write(currentTIme);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished");
            Thread.Sleep(2500);
        }
    }
}