using System.Text;

namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        //interpolation of strings
        var price = 10.2;

        //example 1
        var text1 = "The price of product is "+ price;
        System.Console.WriteLine(text1);

        //example 2
        var text2 = String.Format("The price of product is  {0} just in the Offer",price);
        System.Console.WriteLine(text2);

        //example 3
        var text3 = $"The price of product is {price} just in the offer";
        System.Console.WriteLine(text3);

        //example 4 
        var brokenLIne = $@"The price of 
product is {price} just in the offer with line break";
        System.Console.WriteLine(brokenLIne);


        //Compare strings

        var text4 = "Testing";

        //CompareTo
        System.Console.WriteLine(text4.CompareTo("Testing")); // return 0 beacause is equal
        System.Console.WriteLine(text4.CompareTo("testing")); // return 1 beacause is not equal

        //Contains 
        System.Console.WriteLine(text1.Contains("Test")); //Return true
        System.Console.WriteLine(text1.Contains("TesTing")); //Return false
        System.Console.WriteLine(text1.Contains("test", StringComparison.OrdinalIgnoreCase)); //Return true because ignore the lower case or upper case

        //StartWIth/EndsWith
        var text5 = "This test start with";
        System.Console.WriteLine(text5.StartsWith("This")); //Return True
        System.Console.WriteLine(text5.StartsWith("this")); //Return False
        System.Console.WriteLine(text5.StartsWith(" This")); //Return False
        System.Console.WriteLine(text5.StartsWith("this", StringComparison.OrdinalIgnoreCase)); //Return true

        System.Console.WriteLine(text5.EndsWith("with", StringComparison.OrdinalIgnoreCase)); //Return true
        System.Console.WriteLine(text5.EndsWith("With")); //Return false
        System.Console.WriteLine(text5.EndsWith("with", StringComparison.OrdinalIgnoreCase)); //Return true

        //Equals
        System.Console.WriteLine(text5.Equals("This test start with"));
        System.Console.WriteLine(text5.Equals("this test start with",StringComparison.OrdinalIgnoreCase));
        System.Console.WriteLine(text5.Equals("This test start"));
        System.Console.WriteLine(text5.Equals("this test start with"));
        
        //Index 
        var text6 = "abcdefghijklmnopqrstuvwxyz";
        System.Console.WriteLine("Index of B "+text6.IndexOf("b"));

        System.Console.WriteLine(text5.LastIndexOf("t"));

        // ToUpper  /  ToLower  / Length  / Remove  / Replace
        System.Console.WriteLine(text6.ToUpper());
        System.Console.WriteLine(text5.ToLower());
        System.Console.WriteLine(text6.Insert(26," HERE"));
        System.Console.WriteLine(text6.Remove(0,25));
        System.Console.WriteLine(text6.Length);
        System.Console.WriteLine(text5.Replace("test", "product"));
        System.Console.WriteLine(text5.Replace("t", "X"));

        System.Console.WriteLine("");
        System.Console.WriteLine("Usando Split");

        //create a list separating the words with " "
        var divisao = text5.Split(" ");
        System.Console.WriteLine(divisao[0]);
        System.Console.WriteLine(divisao[1]);
        System.Console.WriteLine(divisao[2]);
        System.Console.WriteLine(divisao[3]);

        var resultado = text6.Substring(0,5);
        System.Console.WriteLine(resultado);

        // Trim limpa os espaços do começo e do final da string

        //StringBuilder
        var textA = new StringBuilder();
        textA.Append("Text one ");
        textA.Append("Text two ");
        textA.Append("Text thre ");
        textA.Append("Text four ");
        textA.Append("Text five ");

        System.Console.WriteLine(textA.ToString());

    }
}
