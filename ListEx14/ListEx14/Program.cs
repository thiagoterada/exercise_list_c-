/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 25/08/2018
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx14
{
	class Program
	{
		public static void Main(string[] args)
		{
			double c1, c2, c3, c1f, c2f, c3f, c1t, c2t, c3t, c1b, c2b, c3b, tgb, lucro1, lucro2, lucro3, lucrot;
			Console.WriteLine("Unidades de C1 (Início): ");
			c1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Unidades de C2 (Início): ");
			c2 = double.Parse(Console.ReadLine());
			Console.WriteLine("Unidades de C3 (Início): ");
			c3 = double.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Unidades de C1 (Final): ");
			c1f = double.Parse(Console.ReadLine());
			Console.WriteLine("Unidades de C2 (Final): ");
			c2f = double.Parse(Console.ReadLine());
			Console.WriteLine("Unidades de C3 (Final): ");
			c3f = double.Parse(Console.ReadLine());
			Console.WriteLine();
			c1t = (c1 - c1f);
			c2t = (c2 - c2f);
			c3t = (c3 - c3f);
			Console.WriteLine("Quantidade de Unidades Vendidas: " + "C1: " + c1t + ", C2: " + c2t + ", C3: " + c3t);
			c1b = c1t * 18.0;
			c2b = c2t * 25.0;
			c3b = c3t * 32.0;
			Console.WriteLine("Total Bruto de cada colar: ");
			Console.WriteLine("C1: R$" + c1b + "; C2: R$" + c2b + "; C3: R$" + c3b);
			tgb = c1b + c2b + c3b;
			Console.WriteLine("Total Geral Bruto: R$" + tgb);
			lucro1 = c1b * 0.30;
			lucro2 = c2b * 0.25;
			lucro3 = c3b * 0.20;
			lucrot = lucro1 + lucro2 + lucro3;
			Console.WriteLine("Lucro Total: R$" + lucrot);
			Console.ReadKey();
		}
	}
}