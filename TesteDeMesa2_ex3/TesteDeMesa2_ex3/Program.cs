using System;
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Renda;
            int periodoAnos = 6;

            Console.WriteLine("informe o valor do investimento:");
            double valorPresente = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a taxa de juros atual para essa ação:");
            double taxaJuros = double.Parse(Console.ReadLine());

            Renda = valorPresente * Math.Pow(1 + (taxaJuros / 100), (6));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Renda.ToString("c"));
        }
    }
}