/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 21/08/2018
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx3
{
	class Program
	{
		public static void Main(string[] args)
		{
			float anos, meses, dias, idadeDias;
			Console.WriteLine("Digite Anos: ");
			anos = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite Meses: ");
			meses = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite Dias: ");
			dias = float.Parse(Console.ReadLine());
			idadeDias = (anos * 365) + (meses * 30) + dias;
			Console.WriteLine("A idade é de " + idadeDias + " dias.");
	        Console.ReadKey();
		}
	}
}