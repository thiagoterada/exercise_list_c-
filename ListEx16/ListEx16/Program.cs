/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 25/08/2018
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx16
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nC, somaProdS;
			double somaProd, dig1, dig2, dig3, dig4, dig5, digitoVerificador;
			Console.WriteLine("Número Conta Corrente: ");
			nC = Console.ReadLine();
			dig1 = 1 * double.Parse(nC[0].ToString());
			dig2 = 2 * double.Parse(nC[1].ToString());
			dig3 = 3 * double.Parse(nC[2].ToString());
			dig4 = 4 * double.Parse(nC[3].ToString());
			dig5 = 5 * double.Parse(nC[4].ToString());
			somaProd = dig1 + dig2 + dig3 + dig4 + dig5;
			somaProdS = somaProd.ToString();
			digitoVerificador = double.Parse(somaProdS[0].ToString());
			Console.WriteLine("Dígito Verificador: " + digitoVerificador);
			Console.ReadKey();
		}
	}
}