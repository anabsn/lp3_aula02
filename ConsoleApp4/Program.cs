using System;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] nomes =
			{
				"Ana",
				"Damaris",
				"Alyson",
				"Fernanda toxica",
				"Fellipe Necrosado",
				"Angelozi Vive Menos",
				"Lari",
				"Mari"
			};
			for(int i = 0; i < nomes.Length; i++)
			{
				Console.WriteLine(nomes[i]);
			}
			Console.ReadKey();
		}
	}
}
