namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var lista = new int[5]{2,5,6,7,8};
        
            // int[] listaInt = new int[10];

            // for(int i = 0; i <=4; i++)
            // {
            //     lista[i] = Convert.ToInt16(Math.Pow(i,i));
            // }
            


            // foreach (var numero in lista)
            // {
            //     System.Console.WriteLine("-> "+numero);
            // }

            // var list = new Teste[1];
            // list[0].Id = 2;

            // System.Console.WriteLine(list[0].Id);

            var funcionarios = new Funcionario[5];

            for (int i = 0; i < funcionarios.Length; i++)
            {
                funcionarios[i] = new Funcionario() { Id = 2 * DateTime.Now.Millisecond };
                System.Console.WriteLine(funcionarios[i].Id);
            }
        }

        struct Funcionario{
            public int Id { get; set;}

        }
    }
}