using System;
using System.Diagnostics;

namespace DesignPatternsCSharp.FactoryMethod
{
	public class FileLogger : ILogger
	{
		public  void log(string message)
		{
            Console.WriteLine("File: " + message);
		}
	}

}