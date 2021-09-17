using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1
{
	internal class Calculation
	{
		internal T Sum<T>(T one, T two) where T : struct => Convert.ChangeType((dynamic)one + (dynamic)two, typeof(T));
	}
}
