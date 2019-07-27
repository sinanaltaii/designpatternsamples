using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp9;

namespace SingleResponsibility.ConsoleApp
{
	internal class Program
	{
		internal static void Main(string[] args)
		{
			var shapes = GetAllShapes();
			DrawAllShapes(shapes);
		}

		private static void DrawAllShapes(IList<IShape> shapes)
		{
			var shapesList = shapes.ToList();
			shapesList.Sort(new ShapeComparer());
			shapesList.ForEach(s => s.Draw());
			Console.ReadKey(true);
		}

		private static IList<IShape> GetAllShapes()
		{
			return new List<IShape>
			{
				new Triangle(),
				new Triangle(),
				new Square(),
				new Circle(),
				new Square(),
				new Square(),
				new Square(),
				new Square(),
				new Triangle(),
				new Triangle(),
				new Triangle(),
				new Square(),
				new Circle(),
				new Circle(),
				new Triangle(),
				new Circle(),
				new Square(),
				new Square(),
				new Circle(),
				new Circle()
			};
		}
	}
}
