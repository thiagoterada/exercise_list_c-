/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 19/08/2018
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx9
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nomeProduto;
			float precoFabrica, lucroLojista, impostos, precoFinal;
			Console.WriteLine("Nome do Produto: ");
			nomeProduto = Console.ReadLine();
			Console.WriteLine("Preço de Fábrica: ");
			precoFabrica = float.Parse(Console.ReadLine());
			lucroLojista = precoFabrica * 20 / 100;
			impostos = (precoFabrica + lucroLojista) * 25 / 100;
			precoFinal = precoFabrica + lucroLojista + impostos;
			Console.WriteLine();
			Console.WriteLine(nomeProduto);
			Console.WriteLine("Preço Final: " + precoFinal);
			Console.WriteLine("Lucro do Lojista: " + lucroLojista);
			Console.WriteLine("Impostos: " + impostos);
			Console.ReadKey();
		}
	}
}