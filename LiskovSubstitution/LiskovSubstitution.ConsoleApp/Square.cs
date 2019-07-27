namespace LiskovSubstitution.ConsoleApp
{
	public class Square : IShape
	{
		public int Sides { get; set; }

		public Square(int sides)
		{
			Sides = sides;
		}


		public int Area()
		{
			return Sides * Sides;
		}
	}
}
