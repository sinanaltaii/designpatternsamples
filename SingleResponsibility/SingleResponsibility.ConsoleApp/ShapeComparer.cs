using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp9;

namespace SingleResponsibility.ConsoleApp
{
	public class ShapeComparer : IComparer<IShape>
	{
		private static readonly Hashtable Priorities = new Hashtable();

		public ShapeComparer()
		{
			Priorities.Add(typeof(Circle), 1);
			Priorities.Add(typeof(Triangle), 2);
			Priorities.Add(typeof(Square), 3);
		}

		public int Compare(IShape firstObject, IShape seconObject)
		{
			var prioOne = PriorityFor(firstObject?.GetType());
			var prioTow = PriorityFor(seconObject?.GetType());

			return prioOne.CompareTo(prioTow);
		}

		private static int PriorityFor(Type type)
		{
			if (Priorities.Contains(type))
			{
				return (int)Priorities[type];
			}

			return 0;
		}
	}
}
