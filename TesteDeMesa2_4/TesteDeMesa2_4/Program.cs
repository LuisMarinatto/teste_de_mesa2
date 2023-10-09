using System;
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double rendimento, rendaLiquida, rendaAcumulada, resgate = 1000, Saldo;
            int periodoMes = 8;
            Console.WriteLine("informe o valor inicial para ser aplicado:");
            double valorPresente = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a taxa de juros da ação:");
            double taxaJuros = double.Parse(Console.ReadLine());
            

            for (int i = 0; i < periodoMes; i++)
            {
                rendimento = valorPresente * Math.Pow(1 + (taxaJuros / 100), (i+1));
                Console.WriteLine("sua aplicação rendeu: " +rendimento.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
                rendaLiquida = rendimento - valorPresente;
                Console.WriteLine("sua renda liquida é: " +rendaLiquida.ToString("c"));

                rendaAcumulada = (valorPresente + rendaLiquida);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("você acumulou um total de:" +rendaAcumulada.ToString("c"));

                Console.ForegroundColor = ConsoleColor.White;
                

                if(i == 4)
                {
                    Console.WriteLine("informe o valor a ser sacado");
                    resgate = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"você sacou {resgate}");

                    Console.ForegroundColor = ConsoleColor.White;
                    valorPresente = rendimento - resgate;

                    Console.WriteLine(valorPresente.ToString("c"));
                }

            }
        }
    }
}