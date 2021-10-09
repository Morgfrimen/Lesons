using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

using ConsoleApp1.Cars;
using ConsoleApp1.Cars.Abctraction;
using ConsoleApp1.Extension;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1
{
	public class Program
	{
		private static List<IBigCar> big = new List<IBigCar>();
		private static List<ILittleCar> little = new List<ILittleCar>();

		private static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine($"{Command.AddCar} - добавить машину");
				Console.WriteLine($"{Command.FindLittleCar} - найти легковую машину");
				Console.WriteLine($"{Command.FindBigCar} - найти грузовую машину");
				Console.WriteLine($"{Command.Exit} - Выход");

				switch (Console.ReadLine())
				{
					case "exit":
						return;
					default:
						continue;
				}
			}
		}

		private static void AddCar() 
		{
			IBigCar bigCar = new BigCar(10,"Man");
			big.Add(bigCar);
		}

		private static IBigCar FindLittleCar(IBigCar bigCar)
		{
			var item = big.Find(car=>car.Stamp==bigCar.Stamp) ?? throw new NullReferenceException();
			return item;
		}

		private static void FindBigCar()
		{

		}




		private enum Command : byte
		{
			AddCar = 1,
			FindLittleCar,
			FindBigCar,
			Exit
		}

	}
}