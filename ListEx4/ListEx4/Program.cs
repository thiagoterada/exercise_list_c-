/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 21/08/2018
 * Time: 15:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx4
{
	class Program
	{
		public static void Main(string[] args)
		{
			float sal, faltas, inss, salarioLiquido, descontoFaltas;
            Console.WriteLine("Digite salário: ");
            sal = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite faltas: ");
            faltas = float.Parse(Console.ReadLine());
            inss = sal * 0.12f;
            descontoFaltas = (sal/30) * faltas;
            salarioLiquido = sal - descontoFaltas - inss;
            Console.WriteLine("Salário Bruto = " + sal);
            Console.WriteLine("INSS = " + inss);
            Console.WriteLine("Desconto pelas faltas = " + descontoFaltas);
            Console.WriteLine("Salário Líquido = " + salarioLiquido);
            Console.ReadKey();
		}
	}
}