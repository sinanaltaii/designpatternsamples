using System;

namespace InterfaceSegregationPrinciple.ConsoleApp
{
	public class Airplane : IAirplane
	{
		public void Fly()
		{
			Console.WriteLine("Flying airplane");
		}
	}
}
