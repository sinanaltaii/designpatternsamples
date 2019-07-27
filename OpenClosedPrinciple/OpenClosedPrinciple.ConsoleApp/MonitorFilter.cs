using System.Collections.Generic;
using System.Linq;

namespace OpenClosedPrinciple.ConsoleApp
{
	public class MonitorFilter : IFilter<ComputerMonitor>
	{
		public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
		{
			return monitors.Where(m => specification.IsSatisfied(m)).ToList();
		}
	}
}
