/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 21/08/2018
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx2
{
	class Program
	{
		public static void Main(string[] args)
		{
            float area, ba, altura;
            Console.WriteLine("Digite Altura: ");
	        altura = float.Parse(Console.ReadLine());
 	        Console.WriteLine("Digite Base: ");
 	        ba = float.Parse(Console.ReadLine());
 	        area = ba * altura;
 	        Console.WriteLine("A Área é " + area);
 	        Console.ReadKey();
		}
	}
}