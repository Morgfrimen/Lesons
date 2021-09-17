using ConsoleApp1;

using NUnit.Framework;

namespace UnitTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test_Calculation()
		{
			Calculation calc = new Calculation();
			int resultSum =  calc.Sum<int>(5, 10);
			int assetsResult = 15;
			Assert.AreEqual(resultSum, assetsResult);

			float resSum = calc.Sum<float>(5, 10);
			assetsResult = 15;

			Assert.AreEqual(resultSum, assetsResult,3);
		}
	}
}