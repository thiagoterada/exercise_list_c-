/*
 * Created by SharpDevelop.
 * User: Teste
 * Date: 28/08/2018
 * Time: 15:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListEx18
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("PRODUTO 1"); //Captura de Dados
			Console.WriteLine("Nome:");
			string nome1 = Console.ReadLine();
			Console.WriteLine("Preço:");
			double preco1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Início do Mês):");
			double qntdI1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Final do Mês):");
			double qntdF1 = double.Parse(Console.ReadLine());
			Console.WriteLine();
            Console.WriteLine("PRODUTO 2");
			Console.WriteLine("Nome:");
			string nome2 = Console.ReadLine();
			Console.WriteLine("Preço:");
			double preco2 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Início do Mês):");
			double qntdI2 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Final do Mês):");
			double qntdF2 = double.Parse(Console.ReadLine());
			Console.WriteLine();
            Console.WriteLine("PRODUTO 3");
			Console.WriteLine("Nome:");
			string nome3 = Console.ReadLine();
			Console.WriteLine("Preço:");
			double preco3 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Início do Mês):");
			double qntdI3 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Final do Mês):");
			double qntdF3 = double.Parse(Console.ReadLine());
			Console.WriteLine();
            Console.WriteLine("PRODUTO 4");
			Console.WriteLine("Nome:");
			string nome4 = Console.ReadLine();
			Console.WriteLine("Preço:");
			double preco4 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Início do Mês):");
			double qntdI4 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Final do Mês):");
			double qntdF4 = double.Parse(Console.ReadLine());
			Console.WriteLine();
            Console.WriteLine("PRODUTO 5");
			Console.WriteLine("Nome:");
			string nome5 = Console.ReadLine();
			Console.WriteLine("Preço:");
			double preco5 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Início do Mês):");
			double qntdI5 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Final do Mês):");
			double qntdF5 = double.Parse(Console.ReadLine());
            Console.WriteLine();
			Console.WriteLine("PRODUTO 6");
			Console.WriteLine("Nome:");
			string nome6 = Console.ReadLine();
			Console.WriteLine("Preço:");
			double preco6 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Início do Mês):");
			double qntdI6 = double.Parse(Console.ReadLine());
			Console.WriteLine("Quantidadade(Final do Mês):");
			double qntdF6 = double.Parse(Console.ReadLine());
			Console.WriteLine(); //Processamento dos Dados
			double vendUni1 = qntdI1 - qntdF1; //1
			double valor1 = vendUni1 * preco1; 
			double vendUni2 = qntdI1 - qntdF2; //2
			double valor2 = vendUni2 * preco2;
			double vendUni3 = qntdI3 - qntdF3; //3
			double valor3 = vendUni3 * preco3; 
			double vendUni4 = qntdI4 - qntdF4; //4
			double valor4 = vendUni4 * preco4;
			double vendUni5 = qntdI5 - qntdF5; //5
			double valor5 = vendUni5 * preco5; 
			double vendUni6 = qntdI6 - qntdF6; //6
			double valor6 = vendUni6 * preco6;
			double vendUniT = vendUni1 + vendUni2 + vendUni3 + vendUni4 + vendUni5 + vendUni6; //TOTAL
			double valorT = valor1 + valor2 + valor3 + valor4 + valor5 + valor6;
			Console.WriteLine();
			Console.WriteLine("RELATÓRIO DO MÊS"); //Exibição dos Resultados
			Console.WriteLine();
			Console.WriteLine("Produto: " + nome1); //1
			Console.WriteLine("Unidades Vendidas: " + vendUni1);
			Console.WriteLine("Valor Arrecadado: " + valor1);
			Console.WriteLine();
			Console.WriteLine("Produto: " + nome2); //2
			Console.WriteLine("Unidades Vendidas: " + vendUni2);
			Console.WriteLine("Valor Arrecadado: " + valor2);
			Console.WriteLine();
			Console.WriteLine("Produto: " + nome3); //3
			Console.WriteLine("Unidades Vendidas: " + vendUni3);
			Console.WriteLine("Valor Arrecadado: " + valor3);
			Console.WriteLine();
			Console.WriteLine("Produto: " + nome4); //4
			Console.WriteLine("Unidades Vendidas: " + vendUni4);
			Console.WriteLine("Valor Arrecadado: " + valor4);
			Console.WriteLine();
			Console.WriteLine("Produto: " + nome5); //5
			Console.WriteLine("Unidades Vendidas: " + vendUni5);
			Console.WriteLine("Valor Arrecadado: " + valor5);
			Console.WriteLine();
			Console.WriteLine("Produto: " + nome6); //6
			Console.WriteLine("Unidades Vendidas: " + vendUni6);
			Console.WriteLine("Valor Arrecadado: " + valor6);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("TOTAL GERAL"); //TOTAL
			Console.WriteLine("Unidades Vendidas: " + vendUniT);
			Console.WriteLine("Valor Arrecadado: " + valorT);
			Console.ReadKey();
		}
	}
}