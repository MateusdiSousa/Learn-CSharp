using System.Runtime.InteropServices;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }


        public static void DrawHorinontalLine()
        {
            System.Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                System.Console.Write("-");
            }
            System.Console.Write("+");
            System.Console.Write("\n");
        }
        public static void DrawVerticalLine()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                System.Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                System.Console.Write("\n");
            }
        }
        public static void DrawScreen()
        {

            DrawHorinontalLine();
            DrawVerticalLine();
            DrawHorinontalLine();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3, 4);
            System.Console.WriteLine("Selecione a opção abaixo");
            Console.SetCursorPosition(3, 6);
            System.Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            System.Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            System.Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    System.Console.WriteLine("View");
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Menu.Show();
                    break;
            }
        }
    }
}