/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 18/08/2018
 * Time: 16:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx1
{
	class Program
	{
		public static void Main(string[] args)
		{
			float a, b, c, d;
			a = 10;
			b = 5;
			c = 3;
			d = a + b * c;
			Console.WriteLine("d = a + b * c       | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			a = a - c;
			Console.WriteLine("a = a - c           | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			b = a * b - d / b; 
			Console.WriteLine("b = a * b - d / b   | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			a = 2 * a - 1;
			Console.WriteLine("a = 2 * a - 1       | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			c = (a - c) * c;
			Console.WriteLine("c = (a - c) * c     | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			a = c - 2 * a;
			Console.WriteLine("a = c - 2 * a       | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			d = (b + c) / a;
			Console.WriteLine("d = (b + c) / a     | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			c = (c * a + b) / d;
			Console.WriteLine("c = (c * a + b) / d | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			b = b - d * 2;
			Console.WriteLine("b = b - d * 2       | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			d = (d * a) / c;
			Console.WriteLine("d = (d * a) / c     | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			a = c / 4 - d * b;
			Console.WriteLine("a = c / 4 - d * b   | " + "a: " + a + " b: " + b + " c: " + c + " d: " + d);
			
			Console.ReadKey();
		}
	}
}