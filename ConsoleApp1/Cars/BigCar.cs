
using ConsoleApp1.Cars.Abctraction;

namespace ConsoleApp1.Cars
{
	internal sealed class BigCar : IBigCar
	{
		public BigCar(byte maxWeight,string stamp)
		{
			MaxWeight = maxWeight;
			Stamp = stamp;
		}

		public byte MaxWeight { get; }
		public string Stamp { get; }


	}
}
