/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 25/08/2018
 * Time: 17:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx13
{
	class Program
	{
		public static void Main(string[] args)
		{
			double unidades, preco;
			Console.WriteLine("Digite o número de unidades: ");
			unidades = double.Parse(Console.ReadLine());
			preco = unidades * 5;
			Console.WriteLine("Preço: " + "R$" + preco);
			Console.ReadKey();
		}
	}
}