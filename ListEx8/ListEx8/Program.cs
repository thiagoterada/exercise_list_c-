/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 23/08/2018
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double x, y, so, su, di, mu;
			Console.WriteLine("Digite o 1° número: ");
			x = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o 2° número: ");
			y = double.Parse(Console.ReadLine());
			so = x + y;
			su = x - y;
			di = x / y;
			mu = x * y;
			Console.WriteLine();
			Console.WriteLine("Soma: " + so);
			Console.WriteLine("Subtração : " + su);
			Console.WriteLine("Divisão: " + di);
			Console.WriteLine("Multiplicação: " + mu);
			Console.ReadKey();

		}
	}
}