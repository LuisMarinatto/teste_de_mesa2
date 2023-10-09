using System;
 

namespace Teste01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double valorPresente = 1000, taxaJuros = 5.30 / 100;
            int periodoMes = 6;

			double valorFuturo = valorPresente * Math.Pow((1 + taxaJuros), periodoMes); 
			Console.WriteLine(valorFuturo.ToString("c"));
		}
 
    }
}
