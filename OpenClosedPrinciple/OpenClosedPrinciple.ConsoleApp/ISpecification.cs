namespace OpenClosedPrinciple.ConsoleApp
{
	public interface ISpecification<in T>
	{
		bool IsSatisfied(T item);
	}
}
