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
				ICircles x => x.Radius * 2d * Math.PI,
				_ => throw new NotImplementedException("Пока не реализованно")
			};
		}
	}
}
