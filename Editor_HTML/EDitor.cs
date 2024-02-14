using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("MODE EDITOR");
            System.Console.WriteLine("=================");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.AppendLine(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            System.Console.WriteLine("===================");
            System.Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
        }
    }
}