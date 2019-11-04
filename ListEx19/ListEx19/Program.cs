/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 29/08/2018
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx19
{
	class Program
	{
		public static void Main(string[] args)
		{
			double largPare, compriPare, largCera, compriCera, precoCera;
			Console.WriteLine("Largura da Parede(m): "); //PAREDE
			largPare = double.Parse(Console.ReadLine());
			Console.WriteLine("Comprimento da Parede(m): ");
			compriPare = double.Parse(Console.ReadLine());
			Console.WriteLine("Largura da Cerâmica(m): "); //CERÂMICA
			largCera = double.Parse(Console.ReadLine());
			Console.WriteLine("Comprimento da Cerâmica(m): ");
			compriCera = double.Parse(Console.ReadLine());
			Console.WriteLine("Preço Unitário(Cerâmica):");
			precoCera = double.Parse(Console.ReadLine());
			double areaPare = largPare * compriPare;
			double areaCera = largCera * compriCera;
			double qntdCera = Math.Ceiling(areaPare / areaCera);
			double totalGasto = qntdCera * precoCera;
			double maoDeObra = areaPare * 60;
			Console.WriteLine();
			Console.WriteLine("Quantidade de Cerâmicas que serão utilizadas: " + qntdCera);
			Console.WriteLine("Total Gasto em Cerâmica: R$" + totalGasto);
			Console.WriteLine("Valor da Mão de Obra: R$" + maoDeObra);
			Console.ReadKey();
		}
	}
}