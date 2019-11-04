/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 19/08/2018
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx12
{
	class Program
	{
		public static void Main(string[] args)
		{
			float f, c;
			Console.WriteLine("Temperatura em F°: ");
			f = float.Parse(Console.ReadLine());
			c = 5 * (f - 32) / 9;
			Console.WriteLine(f + " F° equivale a: " + c + " C°");
			Console.ReadKey();
		}
	}
}