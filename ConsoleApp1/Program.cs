using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]

namespace ConsoleApp1
{
	public class Program
	{
		private static void Main(string[] args)
		{
			decimal test = 10;
			long tast1 = -1;
			string ret = "hi";

			int aA = 22;
			int b = 300;
			int resultSum = aA + b;
			int resultMinus = aA * b;



			System.Console.WriteLine(resultSum);
			System.Console.WriteLine(resultMinus);
		}
	}
}