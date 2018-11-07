namespace DesignPatternsCSharp.AbstractFactory
{
	public class LinuxHostingPlanFactory : HostingPlanAbstractFactory
	{

		public override EconomyHostingPlan CreateEconomyHosting()
		{
			return new LinuxEconomyHostingPlan();
		}

		public override DeluxeHostingPlan CreateDeluxeHosting()
		{
			return new LinuxDeluxeHostingPlan();
		}

		public override UltimateHostingPlan CreateUltimateHosting()
		{
			return new LinuxUltimateHostingPlan();
		}

	}

}