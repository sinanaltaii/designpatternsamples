using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var monitors = new List<ComputerMonitor>
			{
				new ComputerMonitor {Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.Oled},
				new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.Lcd },
				new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.Led },
				new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.Oled },
				new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.Led }
			};

			var filter = new MonitorFilter();
			var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.Lcd));
			var wideScreenMonitors = filter.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
			Console.WriteLine("All LCD monitors");
			foreach (var monitor in lcdMonitors)
			{
				OutputToDisplay(monitor);
			}
			Console.WriteLine("All monitors filtered by screen: WideScreen");
			foreach (var monitor in wideScreenMonitors)
			{
				OutputToDisplay(monitor);
			}
		}

		private static void OutputToDisplay(ComputerMonitor monitor)
		{
			Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
		}
	}
}
