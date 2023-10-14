using System.Globalization;
namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double Etanol, Gasolina, x;
            string name = "s";
            while (name == "s")
            {
                Console.Write("Qual o valor do Álcool:R$ ");
                Etanol = double.Parse(Console.ReadLine(), CI);
                Console.Write("Qual o valor do Gasolina:R$ ");
                Gasolina = double.Parse(Console.ReadLine(), CI);
                x = (Etanol / Gasolina);
                Console.WriteLine(x);
                if (x > 0.7)
                {
                    Console.WriteLine("Abastecer com gasolina é mais vantajoso");
                }
                else if (x < 0.7)
                {
                    Console.WriteLine("Abastecer com álcool é mais vantajoso");
                }
                else (x == 0.7)
                {
                    Console.WriteLine("Tanto faz abastecer com gasolina ou álcool");
                }
                Console.Write("Deseja realizar nova consulta (s/n)?: ");
                name = Console.ReadLine();
                {
                if (name == "n")
                {
                Console.WriteLine("Obrigado! Boa viagem");
                }
            }
        }
    }
}