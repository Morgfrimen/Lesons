using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1
{
	public class Program
	{
		private static void Main(string[] args)
		{
			

			Console.WriteLine("Введи первое число");
			int q1 =Convert.ToInt32 (Console.ReadLine());
			Console.WriteLine("введи второе число");
			int q2 =Convert.ToInt32 (Console.ReadLine());

			if(q1<q2)
            {
			Console.WriteLine("первое число меньше чем второе");
			}
			else if (q1 > q2)
			{
			Console.WriteLine("первое число больше чем второе");
			}
			else
			{
			Console.WriteLine("оба числа равны");
			}
			Console.ReadKey();


			Console.WriteLine("введи число");
			int q3 =Convert.ToInt32 (Console.ReadLine());

			if (q3 > 5 && q3 < 10)

			Console.WriteLine("число больше 5 и меньше 10");

			else

			Console.WriteLine("неизвестное число");

			Console.ReadKey();
			

			Console.WriteLine("Ввдите число");
			int q4 = Convert.ToInt32 (Console.ReadLine());

			if (q4 == 5|| q4 == 10)

			Console.WriteLine("число либо равно 5 либо равно 10");

			else
			
			Console.WriteLine("неизвестное число");

			Console.ReadKey();

			

		}
	}
}