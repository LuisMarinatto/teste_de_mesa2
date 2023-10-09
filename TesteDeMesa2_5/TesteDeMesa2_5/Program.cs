using System;
namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "sim";
            double valorFuturo = 7390.61;
            
            Console.WriteLine("quantos meses você quer investir no momento?");
            int tempoInvestido = int.Parse(Console.ReadLine());

            Console.WriteLine("qual a taxa de juros?");
            double taxaJuros = double.Parse(Console.ReadLine());

            double valorPresente = valorFuturo / Math.Pow(1 + (taxaJuros / 100), tempoInvestido);
            Console.WriteLine($"para chegar ao valor de 7.390,61 você precisa investir {valorPresente.ToString("c")} por {tempoInvestido} meses");

            Console.WriteLine("o Sr(a) gostaria de ter uma carteira de investimentos conosco? (sim/não)");
            y = Console.ReadLine();
            if(y == "sim")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("seja bem vindo a agência Sr(a)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("é uma pena, espero que fechemos um acordo no futuro");
            }
        }
    }
}
