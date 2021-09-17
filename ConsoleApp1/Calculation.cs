using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1
{
	internal class Calculation
	{
		internal T Sum<T>(T one, T two) where T : struct => Convert.ChangeType((dynamic)one + (dynamic)two, typeof(T));

		internal T Different<T>(T value1, T value2)	where T : struct => Convert.ChangeType((dynamic)value1 - (dynamic)value2, typeof(T));

		internal T Subdivision<T>(T value1, T value2)  where T : struct => Convert.ChangeType((dynamic)value1 / (dynamic)value2, typeof(T));

		internal T Multiplication<T>(T value1, T value2) where T : struct => Convert.ChangeType((dynamic)value1 * (dynamic)value2, typeof(T));
	}
}
