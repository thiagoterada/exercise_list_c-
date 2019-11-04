/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 27/08/2018
 * Time: 15:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx17
{
	class Program
	{
		public static void Main(string[] args)
		{
			double altura, largura, comprimento, volume, baldes;
			Console.WriteLine("Digite Altura: ");
			altura = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite Largura: ");
			largura =  double.Parse(Console.ReadLine());
			Console.WriteLine("Digite Comprimento: ");
			comprimento = double.Parse(Console.ReadLine());
			volume = altura * largura * comprimento;
			baldes = (volume / 0.0038) * 8;
			Console.WriteLine("O orçamento é de: R$" + baldes);
			Console.ReadKey();
		}
	}
}