/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 19/08/2018
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx11
{
	class Program
	{
		public static void Main(string[] args)
		{
			double c, a, b;
			Console.WriteLine("Cateto a: ");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Cateto b: ");
			b = double.Parse(Console.ReadLine());
			c = Math.Sqrt(a * a + b * b);
			Console.WriteLine("c = " + c);
			Console.ReadKey();
		}
	}
}