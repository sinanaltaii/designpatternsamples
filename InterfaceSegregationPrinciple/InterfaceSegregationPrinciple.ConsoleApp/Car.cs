using System;

namespace InterfaceSegregationPrinciple.ConsoleApp
{
	public class Car : ICar
	{
		public void Drive()
		{
			Console.WriteLine("Driving a car");
		}
	}
}
