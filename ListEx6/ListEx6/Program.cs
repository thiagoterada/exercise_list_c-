/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 19/08/2018
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double v, r, pi;
			pi = 3.1416;
			Console.WriteLine("Digite o valor do raio: ");
			r = double.Parse(Console.ReadLine());
			v = (4/3) * pi * r;
			Console.WriteLine("Volume = " + v);
			Console.ReadKey();
		}
	}
}