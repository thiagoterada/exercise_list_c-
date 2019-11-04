/*
 * Created by SharpDevelop.
 * User: Angela
 * Date: 25/08/2018
 * Time: 17:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx15
{
	class Program
	{
		public static void Main(string[] args)
		{
			string s, t;
			Console.WriteLine("String s: ");
			s = Console.ReadLine();
			Console.WriteLine("String t: ");
			t = Console.ReadLine();
			Console.WriteLine("Resultado: " + s[0].ToString() + t[0].ToString() + s[1].ToString() + t[1].ToString() + s[2].ToString() + t[2].ToString() + s[3].ToString() + t[3].ToString() + s[4].ToString() + t[4].ToString() + s[5].ToString() + t[5].ToString() + s[6].ToString() + t[6].ToString() + s[7].ToString() + t[7].ToString());
			Console.ReadKey();
		}
	}
}