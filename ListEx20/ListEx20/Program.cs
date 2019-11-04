/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 29/08/2018
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx20
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Registro Hackeado: ");
			string regFuncHack =  Console.ReadLine();
			string regFunc = regFuncHack[7].ToString() + regFuncHack[4].ToString() + regFuncHack[2].ToString() + regFuncHack[8].ToString() + regFuncHack[1].ToString() + regFuncHack[6].ToString() + regFuncHack[5].ToString() + regFuncHack[0].ToString() + regFuncHack[3].ToString();
			Console.WriteLine();
			Console.WriteLine("Registro Original: " + regFunc);
			Console.ReadKey();
		}
	}
}