using System;

using ConsoleApp1.Figure;
using ConsoleApp1.Figure.Abstraction;
using ConsoleApp1.Figure.FigureExtension;

using NUnit.Framework;

namespace UnitTest
{
	internal sealed class FigureTest
	{
		[Test]
		public void Test_Perimetr()
		{
			IFigure figure = new Сircle(2);

			double testResult = ((ICircles)figure).Radius * 2 * Math.PI;
			double actual = figure.Perimeter();

			Assert.AreEqual(testResult,actual,1e-3);
		}
	}
}
