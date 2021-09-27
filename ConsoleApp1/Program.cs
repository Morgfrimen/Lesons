using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;

using ConsoleApp1.Extension;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1;



public class Program
{
	private static void Main(string[] args)
	{
		int value = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(value.GetKube(new List<CustomNumber>()));
	}

	public struct CustomNumber
	{
		public double Value { get; set; }

		public static implicit  operator double (CustomNumber customNumber)
		{
			return customNumber.Value;
		}
	}

}