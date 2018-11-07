namespace DesignPatternsCSharp.Builder
{
	public class SandwichDirector
	{
		private SandwichBuilder builder;

		public SandwichDirector(SandwichBuilder builder)
		{
			this.builder = builder;
		}

		public void buildSandwich()
		{
			builder.CreateNewSandwich();
			builder.prepareBread();
			builder.applyMeatAndCheese();
			builder.applyVegetables();
			builder.addCondiments();
		}

		public Sandwich Sandwhich
		{
			get
			{
                return builder.getSandwich();
			}
		}
	}
}