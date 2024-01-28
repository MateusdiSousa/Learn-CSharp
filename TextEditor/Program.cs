using System.Formats.Asn1;
using System.IO;

namespace TextEditor
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
            System.Console.WriteLine("O que voce deseja fazer?");

            System.Console.WriteLine("1 - Open File");
            System.Console.WriteLine("2 - Create a new file");
            System.Console.WriteLine("0 - Exit");

            short option;
            try
            {
                option = short.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Erro ao selecionar opcao, por favor digite apenas numeros!");
                Thread.Sleep(5000);
                Menu();
                throw;
            }

            switch (option)
            {
                case 1:
                    OpenFile();
                    break;
                case 2:
                    CreateFile();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void OpenFile()
        {
            Console.Clear();
            System.Console.WriteLine("Which path to file?");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                System.Console.WriteLine(text);
            }
            System.Console.WriteLine(" ");
            System.Console.ReadLine();
            Menu();
        }
        static void CreateFile()
        {
            Console.Clear();
            System.Console.WriteLine("Type you text down (ESC to exit)");
            System.Console.WriteLine("----------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            SaveFIle(text);
        }
        static void SaveFIle(string text)
        {
            Console.Clear();
            Console.WriteLine("Which path do you will save your file?");
            var path = Console.ReadLine();

            try
            {
                using (var file = new StreamWriter(path))
                {
                    file.Write(text);
                }
            }
            catch (System.Exception)
            {
                SaveFIle(text);
                throw;
            }


            Console.WriteLine($"File {path} saved sucessfully");
            Thread.Sleep(5000);
            Menu();
        }
    }
}