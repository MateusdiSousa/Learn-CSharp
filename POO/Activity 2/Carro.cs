
namespace POO
{
    public class Carro
    {
        public int velocidade;

        public string modelo;

        public Carro(string modelo)
        {
            this.velocidade = 0;
            this.modelo = modelo;
        }

        public void Acelerar(int aceleracao)
        {
            velocidade = velocidade + aceleracao;
            System.Console.WriteLine($"O {modelo} acelerou até chegar em {velocidade} Km/h");
        }

        public void Buzinar()
        {
            System.Console.WriteLine($"O {modelo} buzinou !!!");
        }

        public void Frear()
        {
            velocidade = 0;
            System.Console.WriteLine($"O {modelo} parou ");
        }
    }
}
