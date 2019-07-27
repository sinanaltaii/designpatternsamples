using System;
using SingleResponsibility.ConsoleApp;

namespace ConsoleApp9
{
	internal class Square : IShape
	{
		public void Draw()
		{
			Console.WriteLine("Drawing {0}", nameof(Square));
		}
	}
}
