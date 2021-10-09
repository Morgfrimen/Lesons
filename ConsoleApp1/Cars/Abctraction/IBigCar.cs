namespace ConsoleApp1.Cars.Abctraction
{
	internal interface IBigCar : ICar
	{
		public byte MaxWeight { get; } //тонны
	}
}
