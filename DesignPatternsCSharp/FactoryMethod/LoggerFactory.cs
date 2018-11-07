using System;
using System.IO;
using System.Configuration;

namespace DesignPatternsCSharp.FactoryMethod
{
     public class LoggerFactory
	{
		public bool isFileLoggingEnabled
        {
			get
			{
				try
				{
                    string fileLoggingValue = Environment.GetEnvironmentVariable("fileLogging");
					return fileLoggingValue.Equals("ON", StringComparison.OrdinalIgnoreCase);
				}
				catch (IOException)
				{
					return false;
				}
			}
		}

		// Factory Method
		public  ILogger Logger
		{
			get
			{
				if (isFileLoggingEnabled)
				{
					return new FileLogger();
				}
				else
				{
					return new ConsoleLogger();
				}
			}
		}
	}

}