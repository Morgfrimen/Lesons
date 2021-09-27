using ConsoleApp1.Figure.Abstraction;

namespace ConsoleApp1.Figure
{
	internal sealed class Сircle : ICircles
	{
		public Сircle(double radius)
		{
			Radius = radius;
		}

		public double Radius {get; }
	}
}
