/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 25/08/2018
 * Time: 15:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx10
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome, sobrenome;
			Console.WriteLine("Digite o Nome: ");
			nome = Console.ReadLine();
			Console.WriteLine("Digite o Sobrenome: ");
			sobrenome = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine(nome[0].ToString() + sobrenome[0].ToString());
			Console.WriteLine(sobrenome + ", " + nome);
			Console.WriteLine(nome[0].ToString() + nome[1].ToString() + nome[2].ToString() + sobrenome[0].ToString() + sobrenome[1].ToString() + sobrenome[2].ToString());
			Console.WriteLine(sobrenome[2].ToString() + sobrenome[1].ToString() + sobrenome[0].ToString() + nome[2].ToString() + nome[1].ToString() + nome[0].ToString());
			Console.ReadKey();
		}
	}
}