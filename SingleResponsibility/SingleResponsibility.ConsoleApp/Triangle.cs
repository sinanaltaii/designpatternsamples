using System;

namespace SingleResponsibility.ConsoleApp
{
	internal class Triangle : IShape
	{
		public void Draw()
		{
			Console.WriteLine("Drawing {0}", nameof(Triangle));
		}
	}
}
