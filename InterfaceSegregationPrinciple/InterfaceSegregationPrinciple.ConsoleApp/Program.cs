namespace InterfaceSegregationPrinciple.ConsoleApp
{
	internal class Program
	{
		internal static void Main()
		{
			var multiVehicle = new MultiFunctionalCar(new Car(), new Airplane());
			multiVehicle.Drive();
			multiVehicle.Fly();

			var airplane = new Airplane();
			airplane.Fly();

			var car = new Car();
			car.Drive();
		}
	}
}
