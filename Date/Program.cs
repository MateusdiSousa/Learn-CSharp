using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            //Cria um date time com base na hora atual
            // DateTime data = DateTime.Now;
            // System.Console.WriteLine(data);

            // //Cria um date apartir dos parâmetros
            // DateTime data2 = new DateTime(2024, 02, 27, 10, 33, 55);

            //Acessando os atributos da Data

            // System.Console.WriteLine(data2);
            // System.Console.WriteLine(data.Year);
            // System.Console.WriteLine(data.Month);
            // System.Console.WriteLine(data.Day);
            // System.Console.WriteLine(data.DayOfWeek);
            // System.Console.WriteLine(data.Hour);
            // System.Console.WriteLine(data.Minute);
            // System.Console.WriteLine(data.Second);

            // var formatada = $"{data.Day} de {data.Month} de {data.Year}";
            // var formatada2 = String.Format("{0:d/MM/yyyy}", data2);

            // System.Console.WriteLine(formatada);
            // System.Console.WriteLine(formatada2);

            // //padrões de formatação
            // var formatada3 = String.Format("{0:t}", data2);
            // System.Console.WriteLine(formatada3);
            // //10:33

            // var formatada4= String.Format("{0:d}", data2);
            // System.Console.WriteLine(formatada4);
            // //27/02/2024

            // var formatada5 = String.Format("{0:D}", data2);
            // System.Console.WriteLine(formatada5);
            // //terça-feira, 27 de fevereiro de 2024

            // var formatada6 = String.Format("{0:T}", data2);
            // System.Console.WriteLine(formatada6);
            // //10:33:55

            // var formatada7 = String.Format("{0:g}", data2);
            // System.Console.WriteLine(formatada7);

            // var formatada8 = String.Format("{0:f}", data2);
            // System.Console.WriteLine(formatada8);

            // var formatada9 = String.Format("{0:r}", data2);
            // System.Console.WriteLine(formatada9);
            // // padrõa UFC 

            // var formatada10 = String.Format("{0:s}", data2);
            // System.Console.WriteLine(formatada10);
            // // Banco de dados noSQL

            // var formatada11 = String.Format("{0:u}", data2);
            // System.Console.WriteLine(formatada11);
            // // json

            // //Adicionando Valores a Data

            var newData = DateTime.Now;

            // System.Console.WriteLine(newData);


            // System.Console.WriteLine(newData.AddDays(1));


            // System.Console.WriteLine(newData.AddMonths(5));


            // System.Console.WriteLine(newData.AddYears(1));

            // Comparando datas

            // if (newData.Date == DateTime.Now.Date)
            // {
            //     System.Console.WriteLine("É igual");
            // }

            //Culture Info

            var ptBR = new CultureInfo("pt-BR");

            var enUS = new CultureInfo("en-US");

            Console.WriteLine(DateTime.Now.ToString("D",enUS));

            //Time Zone

            var utcTime = DateTime.UtcNow;

            System.Console.WriteLine(utcTime);

            System.Console.WriteLine(utcTime.ToLocalTime());


            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            System.Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezoneAustralia);

            System.Console.WriteLine(horaAustralia);
        }
    }
}