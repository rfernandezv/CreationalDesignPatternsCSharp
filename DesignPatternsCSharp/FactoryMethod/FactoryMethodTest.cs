using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.FactoryMethod
{
    class FactoryMethodTest
    {
        static void Main(string[] args)
        {
            initialize();
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.Logger;
            logger.log("A Message to Log");
            Console.ReadKey();
        }

        public static void initialize()
        {
            System.Environment.SetEnvironmentVariable("fileLogging", "ON");
        }

    }
}
