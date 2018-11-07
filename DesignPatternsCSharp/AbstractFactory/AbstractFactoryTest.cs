using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.AbstractFactory
{
    class AbstractFactoryTest
    {
        static void Main(string[] args)
        {
            initialize();
            String hostingPlan = Environment.GetEnvironmentVariable("HostingOS");
            HostingPlanAbstractFactory hostingFactory = HostingPlanAbstractFactory.GetHostingFactory(hostingPlan);

            EconomyHostingPlan economyHostingPlan = hostingFactory.CreateEconomyHosting();
            Console.WriteLine(economyHostingPlan.GetFeatures());

            DeluxeHostingPlan deluxeHostingPlan = hostingFactory.CreateDeluxeHosting();
            Console.WriteLine(deluxeHostingPlan.GetFeatures());

            UltimateHostingPlan ultimateHostingPlan = hostingFactory.CreateUltimateHosting();
            Console.WriteLine(ultimateHostingPlan.GetFeatures());
            Console.ReadKey();
        }

        public static void initialize()
        {
            System.Environment.SetEnvironmentVariable("HostingOS", "Linux");
        }
    }
}
