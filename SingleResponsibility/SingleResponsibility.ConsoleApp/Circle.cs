using System;
using ConsoleApp9;

namespace SingleResponsibility.ConsoleApp
{
	internal class Circle : IShape
	{
		public void Draw()
		{
			Console.WriteLine("Drawing {0}", nameof(Circle));
		}
	}
}
