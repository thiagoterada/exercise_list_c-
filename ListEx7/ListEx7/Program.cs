/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 19/08/2018
 * Time: 15:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx7
{
	class Program
	{
		public static void Main(string[] args)
		{
			float d, m, a, idd, t;
			Console.WriteLine("Anos: ");
			a = float.Parse(Console.ReadLine());
			Console.WriteLine("Meses: ");
			m = float.Parse(Console.ReadLine());
			Console.WriteLine("Dias: ");
			d = float.Parse(Console.ReadLine());
			idd = (365 * a) + (30 * m) + d;
			t = (365 * 18) - idd;
			Console.WriteLine("Faltam " + t + " dias para completar a maioridade!");
			Console.ReadKey();
		}
	}
}