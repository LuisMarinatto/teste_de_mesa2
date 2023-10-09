using System;
namespace Ex2
{
	class Program
	{
	static void Main(string[] args)
		{
			double valorPresente, taxaJuros = 1.25 / 100, rendimento_liq, renda_acumulada, valor_total;
			int periodoMes = 6;
			Console.WriteLine("informe o valor que gostaria de investir:");
			valorPresente = double.Parse(Console.ReadLine());
            for (int i = 0; i < periodoMes; i++)
            {
                rendimento_liq = valorPresente * Math.Pow(1 + taxaJuros, (i+1));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("o rendimento liquido é: "+ rendimento_liq.ToString("c"));

				renda_acumulada = valorPresente + rendimento_liq;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("a renda acumulada é: "+ renda_acumulada.ToString("c"));
				                
                valor_total = renda_acumulada + rendimento_liq;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("o valor total é: "+ valor_total.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
	}
    
}
