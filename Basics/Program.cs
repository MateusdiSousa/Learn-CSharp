namespace Teste
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     int contador = 10;

        //     do {
        //         Console.WriteLine("Numero: "+contador);
        //         contador--;
        //     } while (contador != 0);

        //     string nomeCompleto = RetornaNome("Mateus","Sousa");

        //     Console.WriteLine(nomeCompleto);
        // }

        // static string RetornaNome(string nome, string sobrenome){
        //     return nome +' ' + sobrenome;
        // }

        static void Main(string[] args)
        {
            //Heap type == Reference TYpes
            var arr = new string[2];
            arr[0] = "iTEM 1";
            var arr2 = arr; //pega o valor de referencia
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            //ALtera as duas listas
            arr[0] = "Item alterado";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            //Stack type == Value Types
            //copia o valor e coloca na memoria da variavel b
            var a = 'a';
            var b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //altera apenas o valor de a
            a = 'z';
            Console.WriteLine(a);
            Console.WriteLine(b);

            Pessoa mateus = new Pessoa(19, "Mateus", "Sousa",EEstadoCivil.Solteiro);
            mateus.FalarNome();
            mateus.FicarMaisVelho();
            Console.WriteLine(mateus.EstadoCivil);
            Console.WriteLine((int)mateus.EstadoCivil);
        }
        //Structs
        //Tipo de dado estruturado que criamos que se torna um tipo de valor, ele pode ser composto por propriedades e metodos
        //Nome sempre em maiusculo e criado apartir da palavra 'new'

        struct Pessoa
        {
            public string Nome;
            public string Sobrenome;
            public int Idade;
            public EEstadoCivil EstadoCivil;

            public Pessoa(int idade, string nome, string sobrenome, EEstadoCivil estadoCivil)
            {
                Idade = idade;
                Nome = nome;
                Sobrenome = sobrenome;
                EstadoCivil = estadoCivil;
            }

            public void FalarNome()
            {
                Console.WriteLine(Nome + " " + Sobrenome);
            }


            public void FicarMaisVelho()
            {
                Idade += 1;
                Console.WriteLine("Feliz aniversario de " + Idade);
            }
        }

        //Enums 
        //Usado para frnecer uma visualizacao melhor do codigo
        //Substituem o uso de inteiros
        //Usados em listas curtas
        //Usados em dados fixos

        enum EEstadoCivil{
            Solteiro = 1,
            Casado = 2,
            Divorciado = 3,
            Viuvo = 4
        }
    }
}
