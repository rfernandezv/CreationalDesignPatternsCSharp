using System;
using System.Diagnostics;

namespace DesignPatternsCSharp.FactoryMethod
{
	public class ConsoleLogger : ILogger
	{
		public  void log(string message)
		{
            Console.WriteLine("Console: " + message);
		}
	}

}