namespace POO
{
    class Program
    {
        static void Main(String[] args)
        {
            // Music music1 = new Music("It's my life", "BOn Jovi");
            // music1.duration = 238;
            // music1.avaliable = true;

            Music music2 = new Music("Killer Queen", "Queen");
            music2.Duration = 257;
            music2.Avaliable = true;
            music2.Description = "The song Killet Queen belong to the band Queen";


            // music1.ShowInfo();
            // System.Console.WriteLine("\n=============================\n");
            // music2.ShowInfo();

            Carro polo = new Carro("Polo MODELO 2023");

            polo.Acelerar(80);
            polo.Buzinar();
            polo.Frear();

            music2.ShowInfo();
        }
    }
}