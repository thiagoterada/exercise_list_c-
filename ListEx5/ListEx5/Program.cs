/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 18/08/2018
 * Time: 20:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx5
{
	class Program
	{
		public static void Main(string[] args)
		{
			float cidadeA, cidadeB, posto1, posto2, posto3, distancia;
			Console.WriteLine("Cidade A (km):");
			cidadeA = float.Parse(Console.ReadLine());
			Console.WriteLine("Cidade B (km):");
			cidadeB = float.Parse(Console.ReadLine());
			distancia = (cidadeB - cidadeA) / 4;
			posto1 = distancia + cidadeA;
			posto2 = distancia + posto1;
			posto3 = distancia + posto2;
			Console.WriteLine();
			Console.WriteLine("Os melhores locais para os postos são: ");
			Console.WriteLine("Posto 1: " + posto1 + " Posto 2: " + posto2 + " Posto 3: " + posto3);
			Console.ReadKey();
		}
	}
}