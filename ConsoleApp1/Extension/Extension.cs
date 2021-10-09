using System;
using System.Collections.Generic;

using ConsoleApp1.Cars.Abctraction;

namespace ConsoleApp1.Extension
{
	internal static class Extension
	{
		public static T GetKube<T, Tout>(this T value, Tout str) where T : struct
																		where Tout : class
		{
			if (str is string)
				Console.WriteLine(str);

			var result = Convert.ChangeType((double)((dynamic)value * (dynamic)value * (dynamic)value), typeof(T));
			return (T)result;
		}


		public static void AddCar(this List<ICar> cars, ICar car) 
		{
			cars.Add(car);
		}
	}
}
