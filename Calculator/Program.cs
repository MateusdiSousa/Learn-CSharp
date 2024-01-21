// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool continuar = true;
            do
            {
                Console.WriteLine("Selecione a operacao que deseja realizar:");
                Console.WriteLine("1 - Soma \n2 - Subtracao, \n3 - Divisao, \n4 - Multiplicacao \n5 - Encerrar calculadora");
                Console.WriteLine("---------------------");
                int operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 5:
                        continuar = false;
                        Console.WriteLine($"Calculadora encerrada");
                        break;
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Subtrair();
                        break;
                    case 3:
                        Dividir();
                        break;
                    case 4:
                        Multiplicar();
                        break;
                    default:
                        Console.WriteLine("Comando nao reconhecido");
                        break;
                }
            } while (continuar);
        }

        static void Somar()
        {
            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da Soma e {valor1 + valor2}");
        }

        static void Subtrair()
        {
            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da Subtracao e {valor1 - valor2}");
        }

        static void Multiplicar()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da Multiplicacao e {(valor1 * valor2)}");
            Console.ReadKey();
        }

        static void Dividir()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da Divisao e {valor1 / valor2}");
        }
    }
}