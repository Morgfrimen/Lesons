using System;

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
	}
}
