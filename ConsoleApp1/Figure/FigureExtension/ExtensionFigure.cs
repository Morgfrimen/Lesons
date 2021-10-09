using System;
using ConsoleApp1.Figure.Abstraction;

namespace ConsoleApp1.Figure.FigureExtension
{
	internal static class ExtensionFigure
	{
		internal static double Perimeter<T>(this T figure) where T : IFigure
		{
			return figure switch 
			{
				ICircles circles => circles.Radius * 2d * Math.PI,
				_ => throw new NotImplementedException("Пока не реализованно")
			};
		}

		internal static double Square<T>(this T figure) where T : IFigure
		{
			return figure switch
			{
				ICircles circles => Math.Pow(circles.Radius * circles.Radius,2) * Math.PI,
				_ => throw new NotImplementedException("Пока не реализованно")
			};
		}

	}
}
