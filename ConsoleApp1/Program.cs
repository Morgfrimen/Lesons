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

			int a = 2;
			int b = 3;
			int resultSum = a + b;
			int resultMinus = a - b;



			System.Console.WriteLine(resultSum);
			System.Console.WriteLine(resultMinus);
		}
	}
}