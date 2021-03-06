using ConsoleApp1;
using ConsoleApp1.StringTask;

using NUnit.Framework;

namespace UnitTest
{
	public class CalculationTest
	{
		[Test]
		public void Test_CalculationSum()
		{
			Calculation calc = new Calculation();
			int resultSum = calc.Sum<int>(5, 10);
			int assetsResult = 15;
			Assert.AreEqual(resultSum, assetsResult);

			float resSum = calc.Sum<float>(5, 10);
			assetsResult = 15;

			Assert.AreEqual(resultSum, assetsResult, 3);
		}

		[Test]
		public void Test_CalculationDifferent()
		{
			Calculation calc = new Calculation();
			int resultSum = calc.Different<int>(5, 10);
			int assetsResult = -5;
			Assert.AreEqual(resultSum, assetsResult);

			float resSum = calc.Sum<float>(5, 10);

			Assert.AreEqual(resultSum, assetsResult, 3);
		}

		[Test]
		public void Test_CalculationMultiplication()
		{
			Calculation calc = new Calculation();
			int resultSum = calc.Multiplication<int>(5, 10);
			int assetsResult = 50;
			Assert.AreEqual(resultSum, assetsResult);

			float resSum = calc.Sum<float>(5, 10);

			Assert.AreEqual(resultSum, assetsResult, 3);
		}

		[Test]
		public void Test_CalculationSubdivision()
		{
			Calculation calc = new Calculation();
			int resultSum = calc.Subdivision<int>(5, 10);
			int assetsResult = 0;
			Assert.AreEqual(resultSum, assetsResult);

			float resSum = calc.Sum<float>(5, 10);
			Assert.AreEqual(resultSum, assetsResult, 3);
		}


		[Test]
		public void TestStringTaskFirst()
		{
			StringTask strTask = new StringTask("abgsc");
			string[] actual = strTask.GetResultTask();

			string[] expected = new string[] { "ab", "gs", "c_" };

			CollectionAssert.AreEqual(expected, actual);

			strTask = new StringTask("abgscd");
			actual = strTask.GetResultTask();

			expected = new string[] { "ab", "gs", "cd" };

			CollectionAssert.AreEqual(expected, actual);
		}
	}
}