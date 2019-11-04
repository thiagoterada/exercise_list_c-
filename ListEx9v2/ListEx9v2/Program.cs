/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 23/08/2018
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx9v2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double precoFab, lucroLoj, impostos, precoFinal;
			string nomeP;
			Console.WriteLine("Digite o Nome do Produto: ");
		    nomeP = Console.ReadLine();
		    Console.WriteLine("Digite o Preço de Fábrica: ");
			precoFab = double.Parse(Console.ReadLine());
			lucroLoj = precoFab * 0.20;
			impostos = (precoFab + lucroLoj) * 0.25;
			precoFinal = precoFab + lucroLoj + impostos;
			Console.WriteLine();
			Console.WriteLine("Nome: " + nomeP);
			Console.WriteLine("Preço Final: " + precoFinal);
			Console.WriteLine("Lucro Lojista: " + lucroLoj);
			Console.WriteLine("Impostos: " + impostos);
			Console.ReadKey();

		}
	}
}