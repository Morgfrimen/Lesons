using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Введи возраст");
			string valueInput = Console.ReadLine();

			if (int.TryParse(valueInput,out int result) && result >= 0 && result <= 100)
			{
				Console.WriteLine(result);
			}
			else
			{
				Console.WriteLine("Ошибка");
			}
		}
	}
}