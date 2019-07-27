using System.Collections.Generic;
using LiskovSubstitution.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSubstitution.Tests
{
	[TestClass]
	public class AreaCalculatorsTests
	{
		[TestMethod]
		public void Sixfor2X3Rectangle()
		{
			var myRectangle = new Rectangle { Height = 2, Width = 3 };
			var result = myRectangle.Area();
			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void Ninefor3X3Square()
		{
			var mySquare = new Square(3);
			var result = mySquare.Area();
			Assert.AreEqual(9, result);
		}

		[TestMethod]
		public void TwentyFourfor4X6RectangleAnd9For3X3Square()
		{
			var shapes = new List<IShape>
			{
				new Rectangle {Height = 4, Width = 6},
				new Square(3)
			};
			var areas = new List<int>();
			foreach (var shape in shapes)
			{
				if (shape.GetType() == typeof(Rectangle))
				{
					areas.Add(((Rectangle)shape).Area());
				}

				if (shape.GetType() == typeof(Square))
				{
					areas.Add(((Square)shape).Area());
				}
			}

			Assert.AreEqual(24, areas[0]);
			Assert.AreEqual(9, areas[1]);
		}
	}
}
