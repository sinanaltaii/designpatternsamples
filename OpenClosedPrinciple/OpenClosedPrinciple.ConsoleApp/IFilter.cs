using System.Collections.Generic;

namespace OpenClosedPrinciple.ConsoleApp
{
	public interface IFilter<T>
	{
		List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
	}
}
